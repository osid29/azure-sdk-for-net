﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Samples
{
    public class Sample2_ClassificationWithWorkerSelectorAsync : SamplesBase<RouterTestEnvironment>
    {
        [Test]
        public async Task WorkerSelection_StaticSelectors()
        {
            JobRouterClient routerClient = new JobRouterClient("<< CONNECTION STRING >>");
            JobRouterAdministrationClient routerAdministrationClient = new JobRouterAdministrationClient("<< CONNECTION STRING >>");

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_StaticWorkerSelectors
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'WorkerSelectors' attribute on the classification policy to attach
            // custom worker selectors to the job. For this scenario, we are going to demonstrate
            // StaticWorkerSelector to filter workers on static values.
            // We would like to filter workers on the following criteria:-
            // 1. "Location": "United States"
            // 2. "Language": "en-us"
            // 3. "Geo": "NA"
            //
            // We will create 2 workers, one without the aforementioned labels and the other one with.
            //
            // We will observe the following:-
            //
            // Output:
            // 1. Incoming job will have the aforementioned worker selectors attached to it.
            // 2. Offer will be sent only to the worker who satisfies all three criteria
            //
            // NOTE: All jobs with referencing the classification policy will have the WorkerSelectors attached to them

            // Set up queue
            string distributionPolicyId = "distribution-policy-id-2";
            Response<DistributionPolicy> distributionPolicy = await routerAdministrationClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: distributionPolicyId,
                    offerExpiresAfter: TimeSpan.FromMinutes(5),
                    mode: new LongestIdleMode())
                {
                    Name = "My LongestIdle Distribution Policy",
                }
                );

            string queueId = "Queue-1";
            Response<RouterQueue> queue1 = await routerAdministrationClient.CreateQueueAsync(
                new CreateQueueOptions(queueId: queueId, distributionPolicyId: distributionPolicy.Value.Id)
                {
                    Name = "Queue_365",
                });

            // Set up classification policy
            string cpId = "classification-policy-o365";
            Response<ClassificationPolicy> cp1 = await routerAdministrationClient.CreateClassificationPolicyAsync(
                new CreateClassificationPolicyOptions(classificationPolicyId: cpId)
                {
                    Name = "Classification_Policy_O365",
                    WorkerSelectors =
                    {
                        new StaticWorkerSelectorAttachment(new RouterWorkerSelector("Location", LabelOperator.Equal, new LabelValue("United States"))),
                        new StaticWorkerSelectorAttachment(new RouterWorkerSelector("Language", LabelOperator.Equal, new LabelValue("en-us"))),
                        new StaticWorkerSelectorAttachment(new RouterWorkerSelector("Geo", LabelOperator.Equal, new LabelValue("NA")))
                    }
                });

            // Set up job
            Response<RouterJob> jobO365 = await routerClient.CreateJobWithClassificationPolicyAsync(
                new CreateJobWithClassificationPolicyOptions(jobId: "jobO365", channelId: "general", classificationPolicyId: cp1.Value.Id)
                {
                    ChannelReference = "12345",
                    QueueId = queueId, // We only want to attach WorkerSelectors with classification policy this time, so we will specify queueId
                    Priority = 10, // We only want to attach WorkerSelectors with classification policy this time, so we will specify priority
                });

#if !SNIPPET
            bool condition = false;
            DateTimeOffset startTime = DateTimeOffset.UtcNow;
            TimeSpan maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterJob> jobO365Dto = await routerClient.GetJobAsync(jobO365.Value.Id);
                condition = jobO365Dto.Value.Status == RouterJobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            Response<RouterJob> jobO365Result = await routerClient.GetJobAsync(jobO365.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobO365Result.Value.QueueId == queue1.Value.Id}");

            // Set up two workers
            string workerId1 = "worker-id-1";

            Response<RouterWorker> worker1 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId1, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10), },
                    Labels =
                    {
                        ["Location"] = new LabelValue("United States"),
                        ["Language"] = new LabelValue("en-us"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Skill_English_Lvl"] = new LabelValue(7),
                    }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

            string workerId2 = "worker-id-2";

            Response<RouterWorker> worker2 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId2, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10), },
                    Labels = { ["Skill_English_Lvl"] = new LabelValue(7) }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

#if !SNIPPET
            condition = false;
            startTime = DateTimeOffset.UtcNow;
            maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterWorker> worker1Dto = await routerClient.GetWorkerAsync(workerId1);
                condition = worker1Dto.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id);
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            // we expect worker1 to get an offer for the job, and worker2 to not

            Response<RouterWorker> queriedWorker1 = await routerClient.GetWorkerAsync(workerId1);
            Response<RouterWorker> queriedWorker2 = await routerClient.GetWorkerAsync(workerId2);

            Console.WriteLine($"Worker 1 has successfully received offer for job: {queriedWorker1.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)}");
            Console.WriteLine($"Worker 2 has not received offer for job: {queriedWorker2.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_StaticWorkerSelectors

        }

        [Test]
        public async Task WorkerSelection_ByCondition()
        {
            JobRouterClient routerClient = new JobRouterClient("<< CONNECTION STRING >>");
            JobRouterAdministrationClient routerAdministrationClient = new JobRouterAdministrationClient("<< CONNECTION STRING >>");

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_CondtitionalWorkerSelectors
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'WorkerSelectors' attribute on the classification policy to attach
            // custom worker selectors to the job. For this scenario, we are going to demonstrate
            // ConditionalWorkerSelector to filter workers based on a condition.
            // We would like to filter workers on the following criteria:-
            // 1. If job "Location": "United States",
            // then find workers with:
            //     1. "Language": "en-us"
            //     2. "Geo": "NA"
            //     3. "Skill_English_Lvl" >= 5
            //   If job "Location": "Canada"
            // then find workers with:
            //     1. "Language": "en-ca"
            //     2. "Geo": "NA"
            //     3. "Skill_English_Lvl" >= 5
            //
            // We will create 2 workers, one without the aforementioned labels and the other one with.
            // We will create a job, which has some meaningful labels associated with itself.
            //
            // We will observe the following:-
            //
            // Output:
            // 1. Incoming job will have the aforementioned worker selectors attached to it.
            // 2. Offer will be sent only to the worker who satisfies all three criteria

            // Set up queue
            string distributionPolicyId = "distribution-policy-id-3";
            Response<DistributionPolicy> distributionPolicy = await routerAdministrationClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: distributionPolicyId,
                    offerExpiresAfter: TimeSpan.FromMinutes(5),
                    mode: new LongestIdleMode())
                {
                    Name = "My LongestIdle Distribution Policy",
                }
                );

            string queueId = "Queue-1";
            Response<RouterQueue> queue1 = await routerAdministrationClient.CreateQueueAsync(
                new CreateQueueOptions(queueId: queueId, distributionPolicyId: distributionPolicy.Value.Id)
                {
                    Name = "Queue_365",
                });

            // Set up classification policy
            string cpId = "classification-policy-o365";
            Response<ClassificationPolicy> cp1 = await routerAdministrationClient.CreateClassificationPolicyAsync(
                new CreateClassificationPolicyOptions(classificationPolicyId: cpId)
                {
                    Name = "Classification_Policy_O365",
                    WorkerSelectors =
                    {
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRouterRule("If(job.Location = \"United States\", true, false)"),
                            workerSelectors: new List<RouterWorkerSelector>()
                            {
                                new RouterWorkerSelector("Language", LabelOperator.Equal, new LabelValue("en-us")),
                                new RouterWorkerSelector("Geo", LabelOperator.Equal, new LabelValue("NA")),
                                new RouterWorkerSelector("Skill_English_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(5))
                            }),
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRouterRule("If(job.Location = \"Canada\", true, false)"),
                            workerSelectors: new List<RouterWorkerSelector>()
                            {
                                new RouterWorkerSelector("Language", LabelOperator.Equal, new LabelValue("en-ca")),
                                new RouterWorkerSelector("Geo", LabelOperator.Equal, new LabelValue("NA")),
                                new RouterWorkerSelector("Skill_English_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(5))
                            }),
                    }
                });

            // Set up job
            Response<RouterJob> jobO365 = await routerClient.CreateJobWithClassificationPolicyAsync(
                new CreateJobWithClassificationPolicyOptions(jobId: "jobO365", channelId: "general", classificationPolicyId: cp1.Value.Id)
                {
                    ChannelReference = "12345",
                    QueueId = queueId, // We only want to attach WorkerSelectors with classification policy this time, so we will specify queueId
                    Priority = 10, // We only want to attach WorkerSelectors with classification policy this time, so we will specify priority
                    Labels = // we will attach a label to the job which will affects its classification
                    {
                        ["Location"] = new LabelValue("United States"),
                    }
                });

#if !SNIPPET
            bool condition = false;
            DateTimeOffset startTime = DateTimeOffset.UtcNow;
            TimeSpan maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterJob> jobO365Dto = await routerClient.GetJobAsync(jobO365.Value.Id);
                condition = jobO365Dto.Value.Status == RouterJobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            Response<RouterJob> jobO365Result = await routerClient.GetJobAsync(jobO365.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobO365Result.Value.QueueId == queue1.Value.Id}");  // true
            Console.Write($"O365 job has the following worker selectors attached to it after classification: {jobO365Result.Value.AttachedWorkerSelectors}"); // { "Language" = "en-us", "Geo" = "NA", "Skill_English_Lvl" >= 5 }

            // Set up two workers
            string workerId1 = "worker-id-1";
            Response<RouterWorker> worker1 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId1, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10), },
                    Labels =
                    {
                        ["Language"] = new LabelValue("en-us"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Skill_English_Lvl"] = new LabelValue(7)
                    }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

            string workerId2 = "worker-id-2";
            Response<RouterWorker> worker2 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId2, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10) },
                    Labels =
                    {
                        ["Language"] = new LabelValue("en-ca"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Skill_English_Lvl"] = new LabelValue(7)
                    }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

#if !SNIPPET
            condition = false;
            startTime = DateTimeOffset.UtcNow;
            maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterWorker> worker1Dto = await routerClient.GetWorkerAsync(workerId1);
                condition = worker1Dto.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id);
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            // we expect worker1 to get an offer for the job, and worker2 to not

            Response<RouterWorker> queriedWorker1 = await routerClient.GetWorkerAsync(workerId1);
            Response<RouterWorker> queriedWorker2 = await routerClient.GetWorkerAsync(workerId2);

            Console.WriteLine($"Worker 1 has successfully received offer for job: {queriedWorker1.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)}");
            Console.WriteLine($"Worker 2 has not received offer for job: {queriedWorker2.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_CondtitionalWorkerSelectors
        }

        [Test]
        public async Task WorkerSelection_ByPassThroughValues()
        {
            JobRouterClient routerClient = new JobRouterClient("<< CONNECTION STRING >>");
            JobRouterAdministrationClient routerAdministrationClient = new JobRouterAdministrationClient("<< CONNECTION STRING >>");

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_PassThroughWorkerSelectors
            // cSpell:ignore XBOX, Xbox
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'WorkerSelectors' attribute on the classification policy to attach
            // custom worker selectors to the job. For this scenario, we are going to demonstrate
            // PassThroughWorkerSelectors to filter workers based on a conditions already attached to job.
            // We would like to filter workers on the following criteria already attached to job:-
            // "Location", "Geo", "Language", "Dept"
            // Additionally, we attach a static selector to specify a skill level
            //
            // We will create 2 workers, one without the aforementioned labels and the other one with.
            // We will create 2 jobs, which has some meaningful labels associated with itself.
            //
            // We will observe the following:-
            //
            // Output:
            // 1. Incoming jobs will have the aforementioned worker selectors attached to it.
            // 2. Offer will be sent only to the worker who satisfies all criteria

            // Set up queue
            string distributionPolicyId = "distribution-policy-id-4";
            Response<DistributionPolicy> distributionPolicy = await routerAdministrationClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: distributionPolicyId,
                    offerExpiresAfter: TimeSpan.FromMinutes(5),
                    mode: new LongestIdleMode())
                {
                    Name = "My LongestIdle Distribution Policy",
                }
                );

            string queueId = "Queue-1";
            Response<RouterQueue> queue1 = await routerAdministrationClient.CreateQueueAsync(
                new CreateQueueOptions(
                    queueId: queueId,
                    distributionPolicyId: distributionPolicy.Value.Id)
                {
                    Name = "Queue_365",
                });

            // Set up classification policy
            string cpId = "classification-policy-o365";
            Response<ClassificationPolicy> cp1 = await routerAdministrationClient.CreateClassificationPolicyAsync(
                new CreateClassificationPolicyOptions(classificationPolicyId: cpId)
                {
                    Name = "Classification_Policy_O365_XBOX",
                    WorkerSelectors =
                    {
                        new PassThroughWorkerSelectorAttachment("Location", LabelOperator.Equal),
                        new PassThroughWorkerSelectorAttachment("Geo", LabelOperator.Equal),
                        new PassThroughWorkerSelectorAttachment("Language", LabelOperator.Equal),
                        new PassThroughWorkerSelectorAttachment("Dept", LabelOperator.Equal),
                        new StaticWorkerSelectorAttachment(new RouterWorkerSelector("Skill_English_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(5))),
                    }
                });

            // Set up jobs
            Response<RouterJob> jobO365 = await routerClient.CreateJobWithClassificationPolicyAsync(
                new CreateJobWithClassificationPolicyOptions(jobId: "jobO365", channelId: "general", classificationPolicyId: cp1.Value.Id)
                {
                    ChannelReference = "12345",
                    QueueId = queueId, // We only want to attach WorkerSelectors with classification policy this time, so we will specify queueId
                    Priority = 10, // We only want to attach WorkerSelectors with classification policy this time, so we will specify priority
                    Labels = // we will attach a label to the job which will affects its classification
                    {
                        ["Location"] = new LabelValue("United States"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Language"] = new LabelValue("en-us"),
                        ["Dept"] = new LabelValue("O365")
                    }
                });

            Response<RouterJob> jobXbox = await routerClient.CreateJobWithClassificationPolicyAsync(
                new CreateJobWithClassificationPolicyOptions(jobId: "jobXbox", channelId: "general", classificationPolicyId: cp1.Value.Id)
                {
                    ChannelReference = "12345",
                    QueueId = queueId, // We only want to attach WorkerSelectors with classification policy this time, so we will specify queueId
                    Priority = 10, // We only want to attach WorkerSelectors with classification policy this time, so we will specify priority
                    Labels = // we will attach a label to the job which will affects its classification
                    {
                        ["Location"] = new LabelValue("United States"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Language"] = new LabelValue("en-us"),
                        ["Dept"] = new LabelValue("Xbox")
                    }
                });

#if !SNIPPET
            bool condition = false;
            DateTimeOffset startTime = DateTimeOffset.UtcNow;
            TimeSpan maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterJob> jobO365Dto = await routerClient.GetJobAsync(jobO365.Value.Id);
                Response<RouterJob> jobXboxDto = await routerClient.GetJobAsync(jobXbox.Value.Id);
                condition = jobO365Dto.Value.Status == RouterJobStatus.Queued && jobXboxDto.Value.Status == RouterJobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            Response<RouterJob> jobO365Result1 = await routerClient.GetJobAsync(jobO365.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobO365Result1.Value.QueueId == queue1.Value.Id}");  // true
            Console.Write($"O365 job has the following worker selectors attached to it after classification: {jobO365Result1.Value.AttachedWorkerSelectors}"); // { "Location" = "United States, "Language" = "en-us", "Geo" = "NA", "Dept" = "O365", "Skill_English_Lvl" >= 5 }

            Response<RouterJob> jobXboxResult = await routerClient.GetJobAsync(jobXbox.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobXboxResult.Value.QueueId == queue1.Value.Id}");  // true
            Console.Write($"O365 job has the following worker selectors attached to it after classification: {jobXboxResult.Value.AttachedWorkerSelectors}"); // { "Location" = "United States, "Language" = "en-us", "Geo" = "NA", "Dept" = "Xbox", "Skill_English_Lvl" >= 5 }

            // Set up two workers
            string workerId1 = "worker-id-1";
            Response<RouterWorker> worker1 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId1, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10), },
                    Labels =
                    {
                        ["Location"] = new LabelValue("United States"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Language"] = new LabelValue("en-us"),
                        ["Dept"] = new LabelValue("O365"),
                        ["Skill_English_Lvl"] = new LabelValue(10),
                    }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

            string workerId2 = "worker-id-2";

            Response<RouterWorker> worker2 = await routerClient.CreateWorkerAsync(
                options: new CreateWorkerOptions(workerId: workerId2, totalCapacity: 100)
                {
                    AvailableForOffers = true, // registering worker at the time of creation
                    ChannelConfigurations = { ["general"] = new ChannelConfiguration(10), },
                    Labels =
                    {
                        ["Location"] = new LabelValue("United States"),
                        ["Geo"] = new LabelValue("NA"),
                        ["Language"] = new LabelValue("en-us"),
                        ["Dept"] = new LabelValue("Xbox"),
                        ["Skill_English_Lvl"] = new LabelValue(10),
                    }, // attaching labels associated with worker
                    QueueAssignments = { [queueId] = new RouterQueueAssignment() }
                });

#if !SNIPPET
            condition = false;
            startTime = DateTimeOffset.UtcNow;
            maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                Response<RouterWorker> worker1Dto = await routerClient.GetWorkerAsync(workerId1);
                Response<RouterWorker> worker2Dto = await routerClient.GetWorkerAsync(workerId2);
                condition = worker1Dto.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)
                            && worker2Dto.Value.Offers.Any(offer => offer.JobId == jobXbox.Value.Id);
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            // we expect worker1 to get an offer for the jobO365, and worker2 to get an offer for jobXbox

            Response<RouterWorker> queriedWorker1 = await routerClient.GetWorkerAsync(workerId1);
            Response<RouterWorker> queriedWorker2 = await routerClient.GetWorkerAsync(workerId2);

            Console.WriteLine($"Worker 1 has successfully received offer for jobO365: {queriedWorker1.Value.Offers.Any(offer => offer.JobId == jobO365.Value.Id)}");
            Console.WriteLine($"Worker 2 has successfully received offer for jobXbox: {queriedWorker2.Value.Offers.Any(offer => offer.JobId == jobXbox.Value.Id)}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_PassThroughWorkerSelectors
        }

        // TODO
        /*[Test]
        public async Task WorkerSelection_ByRuleEngineLabels()
        {
            throw new NotImplementedException();
        }*/

        // TODO
        /*[Test]
        public async Task WorkerSelection_ByWeightedAllocation()
        {
            throw new NotImplementedException();
        }*/
    }
}
