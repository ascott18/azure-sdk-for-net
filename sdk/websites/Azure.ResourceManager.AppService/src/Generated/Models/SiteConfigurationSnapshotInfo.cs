// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A snapshot of a web app configuration. </summary>
    public partial class SiteConfigurationSnapshotInfo : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfo. </summary>
        public SiteConfigurationSnapshotInfo()
        {
        }

        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="time"> The time the snapshot was taken. </param>
        /// <param name="snapshotId"> The id of the snapshot. </param>
        internal SiteConfigurationSnapshotInfo(ResourceIdentifier id, string name, ResourceType type, string kind, DateTimeOffset? time, int? snapshotId) : base(id, name, type, kind)
        {
            Time = time;
            SnapshotId = snapshotId;
        }

        /// <summary> The time the snapshot was taken. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The id of the snapshot. </summary>
        public int? SnapshotId { get; }
    }
}
