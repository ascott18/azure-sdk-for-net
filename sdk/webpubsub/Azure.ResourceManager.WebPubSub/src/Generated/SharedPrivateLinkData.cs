// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing the SharedPrivateLink data model. </summary>
    public partial class SharedPrivateLinkData : Resource
    {
        /// <summary> Initializes a new instance of SharedPrivateLinkData. </summary>
        public SharedPrivateLinkData()
        {
        }

        /// <summary> Initializes a new instance of SharedPrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="groupId"> The group id from the provider of resource the shared private link resource is for. </param>
        /// <param name="privateLinkResourceId"> The resource id of the resource the shared private link resource is for. </param>
        /// <param name="provisioningState"> Provisioning state of the shared private link resource. </param>
        /// <param name="requestMessage"> The request message for requesting approval of the shared private link resource. </param>
        /// <param name="status"> Status of the shared private link resource. </param>
        internal SharedPrivateLinkData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string groupId, string privateLinkResourceId, ProvisioningState? provisioningState, string requestMessage, SharedPrivateLinkStatus? status) : base(id, name, type)
        {
            SystemData = systemData;
            GroupId = groupId;
            PrivateLinkResourceId = privateLinkResourceId;
            ProvisioningState = provisioningState;
            RequestMessage = requestMessage;
            Status = status;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> The group id from the provider of resource the shared private link resource is for. </summary>
        public string GroupId { get; set; }
        /// <summary> The resource id of the resource the shared private link resource is for. </summary>
        public string PrivateLinkResourceId { get; set; }
        /// <summary> Provisioning state of the shared private link resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The request message for requesting approval of the shared private link resource. </summary>
        public string RequestMessage { get; set; }
        /// <summary> Status of the shared private link resource. </summary>
        public SharedPrivateLinkStatus? Status { get; }
    }
}
