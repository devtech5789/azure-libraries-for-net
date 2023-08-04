// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Status of packet capture session.
    /// </summary>
    public partial class PacketCaptureQueryStatusResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PacketCaptureQueryStatusResultInner class.
        /// </summary>
        public PacketCaptureQueryStatusResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PacketCaptureQueryStatusResultInner class.
        /// </summary>
        /// <param name="name">The name of the packet capture resource.</param>
        /// <param name="id">The ID of the packet capture resource.</param>
        /// <param name="captureStartTime">The start time of the packet capture
        /// session.</param>
        /// <param name="packetCaptureStatus">The status of the packet capture
        /// session. Possible values include: 'NotStarted', 'Running',
        /// 'Stopped', 'Error', 'Unknown'</param>
        /// <param name="stopReason">The reason the current packet capture
        /// session was stopped.</param>
        /// <param name="packetCaptureError">List of errors of packet capture
        /// session.</param>
        public PacketCaptureQueryStatusResultInner(string name = default(string), string id = default(string), System.DateTime? captureStartTime = default(System.DateTime?), PcStatus packetCaptureStatus = default(PcStatus), string stopReason = default(string), IList<PcError> packetCaptureError = default(IList<PcError>))
        {
            Name = name;
            Id = id;
            CaptureStartTime = captureStartTime;
            PacketCaptureStatus = packetCaptureStatus;
            StopReason = stopReason;
            PacketCaptureError = packetCaptureError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the packet capture resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the packet capture resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the start time of the packet capture session.
        /// </summary>
        [JsonProperty(PropertyName = "captureStartTime")]
        public System.DateTime? CaptureStartTime { get; set; }

        /// <summary>
        /// Gets or sets the status of the packet capture session. Possible
        /// values include: 'NotStarted', 'Running', 'Stopped', 'Error',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "packetCaptureStatus")]
        public PcStatus PacketCaptureStatus { get; set; }

        /// <summary>
        /// Gets or sets the reason the current packet capture session was
        /// stopped.
        /// </summary>
        [JsonProperty(PropertyName = "stopReason")]
        public string StopReason { get; set; }

        /// <summary>
        /// Gets or sets list of errors of packet capture session.
        /// </summary>
        [JsonProperty(PropertyName = "packetCaptureError")]
        public IList<PcError> PacketCaptureError { get; set; }

    }
}