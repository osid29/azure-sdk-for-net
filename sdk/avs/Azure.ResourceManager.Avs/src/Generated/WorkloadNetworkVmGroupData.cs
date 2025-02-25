// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkVmGroup data model.
    /// NSX VM Group
    /// </summary>
    public partial class WorkloadNetworkVmGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkloadNetworkVmGroupData. </summary>
        public WorkloadNetworkVmGroupData()
        {
            Members = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkVmGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the VM group. </param>
        /// <param name="members"> Virtual machine members of this group. </param>
        /// <param name="status"> VM Group status. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        internal WorkloadNetworkVmGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, IList<string> members, WorkloadNetworkVmGroupStatus? status, WorkloadNetworkVmGroupProvisioningState? provisioningState, long? revision) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Members = members;
            Status = status;
            ProvisioningState = provisioningState;
            Revision = revision;
        }

        /// <summary> Display name of the VM group. </summary>
        public string DisplayName { get; set; }
        /// <summary> Virtual machine members of this group. </summary>
        public IList<string> Members { get; }
        /// <summary> VM Group status. </summary>
        public WorkloadNetworkVmGroupStatus? Status { get; }
        /// <summary> The provisioning state. </summary>
        public WorkloadNetworkVmGroupProvisioningState? ProvisioningState { get; }
        /// <summary> NSX revision number. </summary>
        public long? Revision { get; set; }
    }
}
