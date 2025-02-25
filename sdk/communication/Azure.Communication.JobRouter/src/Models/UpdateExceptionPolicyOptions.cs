﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable
using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Options for updating exception policy.
    /// </summary>
    public class UpdateExceptionPolicyOptions
    {
        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="exceptionPolicyId"> Id of the policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exceptionPolicyId"/> is null. </exception>
        public UpdateExceptionPolicyOptions(string exceptionPolicyId)
        {
            Argument.AssertNotNullOrWhiteSpace(exceptionPolicyId, nameof(exceptionPolicyId));

            ExceptionPolicyId = exceptionPolicyId;
        }

        /// <summary>
        /// The Id of this policy.
        /// </summary>
        public string ExceptionPolicyId { get; }

        /// <summary> (Optional) The name of the exception policy. </summary>
        public string Name { get; set; } = default!;

        /// <summary> (Optional) A dictionary collection of exception rules on the exception policy. Key is the Id of each exception rule. </summary>
        public IDictionary<string, ExceptionRule?> ExceptionRules { get; } = new Dictionary<string, ExceptionRule?>();

        /// <summary>
        /// The content to send as the request conditions of the request.
        /// </summary>
        public RequestConditions RequestConditions { get; set; } = new();
    }
}
