// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB table resource object. </summary>
    public partial class CosmosDBTableResourceInfo
    {
        /// <summary> Initializes a new instance of CosmosDBTableResourceInfo. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public CosmosDBTableResourceInfo(string tableName)
        {
            Argument.AssertNotNull(tableName, nameof(tableName));

            TableName = tableName;
        }

        /// <summary> Initializes a new instance of CosmosDBTableResourceInfo. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        internal CosmosDBTableResourceInfo(string tableName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode)
        {
            TableName = tableName;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
        }

        /// <summary> Name of the Cosmos DB table. </summary>
        public string TableName { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
