// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Delete activity. </summary>
    public partial class DeleteActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataset"> Delete activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public DeleteActivity(string name, DatasetReference dataset) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(dataset, nameof(dataset));

            Dataset = dataset;
            Type = "Delete";
        }

        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="recursive"> If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="maxConcurrentConnections"> The max concurrent connections to connect data source at the same time. </param>
        /// <param name="enableLogging"> Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="logStorageSettings"> Log storage settings customer need to provide when enableLogging is true. </param>
        /// <param name="dataset"> Delete activity dataset reference. </param>
        /// <param name="storeSettings">
        /// Delete activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </param>
        internal DeleteActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object recursive, int? maxConcurrentConnections, object enableLogging, LogStorageSettings logStorageSettings, DatasetReference dataset, StoreReadSettings storeSettings) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Recursive = recursive;
            MaxConcurrentConnections = maxConcurrentConnections;
            EnableLogging = enableLogging;
            LogStorageSettings = logStorageSettings;
            Dataset = dataset;
            StoreSettings = storeSettings;
            Type = type ?? "Delete";
        }

        /// <summary> If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
        /// <summary> The max concurrent connections to connect data source at the same time. </summary>
        public int? MaxConcurrentConnections { get; set; }
        /// <summary> Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableLogging { get; set; }
        /// <summary> Log storage settings customer need to provide when enableLogging is true. </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary> Delete activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary>
        /// Delete activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </summary>
        public StoreReadSettings StoreSettings { get; set; }
    }
}
