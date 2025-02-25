// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Details about the download progress of update. </summary>
    public partial class UpdateDownloadProgress
    {
        /// <summary> Initializes a new instance of UpdateDownloadProgress. </summary>
        internal UpdateDownloadProgress()
        {
        }

        /// <summary> Initializes a new instance of UpdateDownloadProgress. </summary>
        /// <param name="downloadPhase"> The download phase. </param>
        /// <param name="percentComplete"> Percentage of completion. </param>
        /// <param name="totalBytesToDownload"> Total bytes to download. </param>
        /// <param name="totalBytesDownloaded"> Total bytes downloaded. </param>
        /// <param name="numberOfUpdatesToDownload"> Number of updates to download. </param>
        /// <param name="numberOfUpdatesDownloaded"> Number of updates downloaded. </param>
        internal UpdateDownloadProgress(DataBoxEdgeDownloadPhase? downloadPhase, int? percentComplete, double? totalBytesToDownload, double? totalBytesDownloaded, int? numberOfUpdatesToDownload, int? numberOfUpdatesDownloaded)
        {
            DownloadPhase = downloadPhase;
            PercentComplete = percentComplete;
            TotalBytesToDownload = totalBytesToDownload;
            TotalBytesDownloaded = totalBytesDownloaded;
            NumberOfUpdatesToDownload = numberOfUpdatesToDownload;
            NumberOfUpdatesDownloaded = numberOfUpdatesDownloaded;
        }

        /// <summary> The download phase. </summary>
        public DataBoxEdgeDownloadPhase? DownloadPhase { get; }
        /// <summary> Percentage of completion. </summary>
        public int? PercentComplete { get; }
        /// <summary> Total bytes to download. </summary>
        public double? TotalBytesToDownload { get; }
        /// <summary> Total bytes downloaded. </summary>
        public double? TotalBytesDownloaded { get; }
        /// <summary> Number of updates to download. </summary>
        public int? NumberOfUpdatesToDownload { get; }
        /// <summary> Number of updates downloaded. </summary>
        public int? NumberOfUpdatesDownloaded { get; }
    }
}
