// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine boot diagnostics. </summary>
    public partial class BootDiagnosticsInstanceView
    {
        /// <summary> Initializes a new instance of BootDiagnosticsInstanceView. </summary>
        internal BootDiagnosticsInstanceView()
        {
        }

        /// <summary> Initializes a new instance of BootDiagnosticsInstanceView. </summary>
        /// <param name="consoleScreenshotBlobUri"> The console screenshot blob URI. **Note:** This will **not** be set if boot diagnostics is currently enabled with managed storage. </param>
        /// <param name="serialConsoleLogBlobUri"> The serial console log blob Uri. **Note:** This will **not** be set if boot diagnostics is currently enabled with managed storage. </param>
        /// <param name="status"> The boot diagnostics status information for the VM. **Note:** It will be set only if there are errors encountered in enabling boot diagnostics. </param>
        internal BootDiagnosticsInstanceView(Uri consoleScreenshotBlobUri, Uri serialConsoleLogBlobUri, InstanceViewStatus status)
        {
            ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
            Status = status;
        }

        /// <summary> The console screenshot blob URI. **Note:** This will **not** be set if boot diagnostics is currently enabled with managed storage. </summary>
        public Uri ConsoleScreenshotBlobUri { get; }
        /// <summary> The serial console log blob Uri. **Note:** This will **not** be set if boot diagnostics is currently enabled with managed storage. </summary>
        public Uri SerialConsoleLogBlobUri { get; }
        /// <summary> The boot diagnostics status information for the VM. **Note:** It will be set only if there are errors encountered in enabling boot diagnostics. </summary>
        public InstanceViewStatus Status { get; }
    }
}
