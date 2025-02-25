// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningJobCollectionGetAllOptions. </summary>
    public partial class MachineLearningJobCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of MachineLearningJobCollectionGetAllOptions. </summary>
        public MachineLearningJobCollectionGetAllOptions()
        {
        }

        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
        /// <summary> Type of job to be returned. </summary>
        public string JobType { get; set; }
        /// <summary> Jobs returned will have this tag key. </summary>
        public string Tag { get; set; }
        /// <summary> View type for including/excluding (for example) archived entities. </summary>
        public MachineLearningListViewType? ListViewType { get; set; }
        /// <summary> Asset name the job's named output is registered with. </summary>
        public string AssetName { get; set; }
        /// <summary> Indicator whether the job is scheduled job. </summary>
        public bool? Scheduled { get; set; }
        /// <summary> The scheduled id for listing the job triggered from. </summary>
        public string ScheduleId { get; set; }
    }
}
