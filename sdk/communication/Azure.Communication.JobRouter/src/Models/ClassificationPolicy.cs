﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    [CodeGenModel("ClassificationPolicy")]
    [CodeGenSuppress("ClassificationPolicy")]
    public partial class ClassificationPolicy: IUtf8JsonSerializable
    {
        /// <summary> Initializes a new instance of ClassificationPolicy. </summary>
        internal ClassificationPolicy()
        {
            _queueSelectors = new ChangeTrackingList<QueueSelectorAttachment>();
            _workerSelectors = new ChangeTrackingList<WorkerSelectorAttachment>();
        }

        [CodeGenMember("QueueSelectors")]
        internal IList<QueueSelectorAttachment> _queueSelectors
        {
            get
            {
                return QueueSelectors != null && QueueSelectors.Any()
                    ? QueueSelectors.ToList()
                    : new ChangeTrackingList<QueueSelectorAttachment>();
            }
            set
            {
                QueueSelectors.AddRange(value);
            }
        }

        [CodeGenMember("WorkerSelectors")]
        internal IList<WorkerSelectorAttachment> _workerSelectors
        {
            get
            {
                return WorkerSelectors != null && WorkerSelectors.Any()
                    ? WorkerSelectors.ToList()
                    : new ChangeTrackingList<WorkerSelectorAttachment>();
            }
            set
            {
                WorkerSelectors.AddRange(value);
            }
        }

        /// <summary> The queue selectors to resolve a queue for a given job. </summary>
        public List<QueueSelectorAttachment> QueueSelectors { get; } = new List<QueueSelectorAttachment>();

        /// <summary> The worker label selectors to attach to a given job. </summary>
        public List<WorkerSelectorAttachment> WorkerSelectors { get; } = new List<WorkerSelectorAttachment>();

        /// <summary> (Optional) The name of the classification policy. </summary>
        public string Name { get; internal set; }

        /// <summary> The fallback queue to select if the queue selector doesn't find a match. </summary>
        public string FallbackQueueId { get; internal set; }
        /// <summary>
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
        /// DirectMapRule:  A rule that return the same labels as the input labels.
        /// ExpressionRule: A rule providing inline expression rules.
        /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
        /// WebhookRule: A rule providing a binding to a webserver following OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionRouterRule"/>, <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </summary>
        public RouterRule PrioritizationRule { get; internal set; }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FallbackQueueId))
            {
                writer.WritePropertyName("fallbackQueueId"u8);
                writer.WriteStringValue(FallbackQueueId);
            }
            if (Optional.IsCollectionDefined(_queueSelectors))
            {
                writer.WritePropertyName("queueSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _queueSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrioritizationRule))
            {
                writer.WritePropertyName("prioritizationRule"u8);
                writer.WriteObjectValue(PrioritizationRule);
            }
            if (Optional.IsCollectionDefined(_workerSelectors))
            {
                writer.WritePropertyName("workerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _workerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
