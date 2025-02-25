// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Online endpoint configuration. </summary>
    public partial class MachineLearningOnlineEndpointProperties : MachineLearningEndpointProperties
    {
        /// <summary> Initializes a new instance of MachineLearningOnlineEndpointProperties. </summary>
        /// <param name="authMode"> [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does. </param>
        public MachineLearningOnlineEndpointProperties(MachineLearningEndpointAuthMode authMode) : base(authMode)
        {
            MirrorTraffic = new ChangeTrackingDictionary<string, int>();
            Traffic = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of MachineLearningOnlineEndpointProperties. </summary>
        /// <param name="authMode"> [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does. </param>
        /// <param name="description"> Description of the inference endpoint. </param>
        /// <param name="keys">
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="scoringUri"> Endpoint URI. </param>
        /// <param name="swaggerUri"> Endpoint Swagger URI. </param>
        /// <param name="compute">
        /// ARM resource ID of the compute if it exists.
        /// optional
        /// </param>
        /// <param name="mirrorTraffic"> Percentage of traffic to be mirrored to each deployment without using returned scoring. Traffic values need to sum to utmost 50. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint. </param>
        /// <param name="publicNetworkAccess"> Set to "Enabled" for endpoints that should allow public access when Private Link is enabled. </param>
        /// <param name="traffic"> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </param>
        internal MachineLearningOnlineEndpointProperties(MachineLearningEndpointAuthMode authMode, string description, MachineLearningEndpointAuthKeys keys, IDictionary<string, string> properties, Uri scoringUri, Uri swaggerUri, string compute, IDictionary<string, int> mirrorTraffic, MachineLearningEndpointProvisioningState? provisioningState, MachineLearningPublicNetworkAccessType? publicNetworkAccess, IDictionary<string, int> traffic) : base(authMode, description, keys, properties, scoringUri, swaggerUri)
        {
            Compute = compute;
            MirrorTraffic = mirrorTraffic;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
            Traffic = traffic;
        }

        /// <summary>
        /// ARM resource ID of the compute if it exists.
        /// optional
        /// </summary>
        public string Compute { get; set; }
        /// <summary> Percentage of traffic to be mirrored to each deployment without using returned scoring. Traffic values need to sum to utmost 50. </summary>
        public IDictionary<string, int> MirrorTraffic { get; set; }
        /// <summary> Provisioning state for the endpoint. </summary>
        public MachineLearningEndpointProvisioningState? ProvisioningState { get; }
        /// <summary> Set to "Enabled" for endpoints that should allow public access when Private Link is enabled. </summary>
        public MachineLearningPublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </summary>
        public IDictionary<string, int> Traffic { get; set; }
    }
}
