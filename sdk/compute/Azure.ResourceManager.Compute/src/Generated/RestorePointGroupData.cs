// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the RestorePointGroup data model. </summary>
    public partial class RestorePointGroupData : TrackedResource
    {
        /// <summary> Initializes a new instance of RestorePointGroupData. </summary>
        /// <param name="location"> The location. </param>
        public RestorePointGroupData(AzureLocation location) : base(location)
        {
            RestorePoints = new ChangeTrackingList<RestorePointData>();
        }

        /// <summary> Initializes a new instance of RestorePointGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="source"> The properties of the source resource that this restore point collection is created from. </param>
        /// <param name="provisioningState"> The provisioning state of the restore point collection. </param>
        /// <param name="restorePointCollectionId"> The unique id of the restore point collection. </param>
        /// <param name="restorePoints"> A list containing all restore points created under this restore point collection. </param>
        internal RestorePointGroupData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, RestorePointCollectionSourceProperties source, string provisioningState, string restorePointCollectionId, IReadOnlyList<RestorePointData> restorePoints) : base(id, name, type, tags, location)
        {
            Source = source;
            ProvisioningState = provisioningState;
            RestorePointCollectionId = restorePointCollectionId;
            RestorePoints = restorePoints;
        }

        /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
        public RestorePointCollectionSourceProperties Source { get; set; }
        /// <summary> The provisioning state of the restore point collection. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique id of the restore point collection. </summary>
        public string RestorePointCollectionId { get; }
        /// <summary> A list containing all restore points created under this restore point collection. </summary>
        public IReadOnlyList<RestorePointData> RestorePoints { get; }
    }
}
