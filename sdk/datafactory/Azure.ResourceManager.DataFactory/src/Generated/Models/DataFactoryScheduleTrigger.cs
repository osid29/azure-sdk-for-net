// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Trigger that creates pipeline runs periodically, on schedule. </summary>
    public partial class DataFactoryScheduleTrigger : MultiplePipelineTrigger
    {
        /// <summary> Initializes a new instance of DataFactoryScheduleTrigger. </summary>
        /// <param name="recurrence"> Recurrence schedule configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recurrence"/> is null. </exception>
        public DataFactoryScheduleTrigger(ScheduleTriggerRecurrence recurrence)
        {
            Argument.AssertNotNull(recurrence, nameof(recurrence));

            Recurrence = recurrence;
            TriggerType = "ScheduleTrigger";
        }

        /// <summary> Initializes a new instance of DataFactoryScheduleTrigger. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        /// <param name="recurrence"> Recurrence schedule configuration. </param>
        internal DataFactoryScheduleTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, IList<TriggerPipelineReference> pipelines, ScheduleTriggerRecurrence recurrence) : base(triggerType, description, runtimeState, annotations, additionalProperties, pipelines)
        {
            Recurrence = recurrence;
            TriggerType = triggerType ?? "ScheduleTrigger";
        }

        /// <summary> Recurrence schedule configuration. </summary>
        public ScheduleTriggerRecurrence Recurrence { get; set; }
    }
}
