// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the RecoverableManagedDatabase data model. </summary>
    public partial class RecoverableManagedDatabaseData : Resource
    {
        /// <summary> Initializes a new instance of RecoverableManagedDatabaseData. </summary>
        public RecoverableManagedDatabaseData()
        {
        }

        /// <summary> Initializes a new instance of RecoverableManagedDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="lastAvailableBackupDate"> The last available backup date. </param>
        internal RecoverableManagedDatabaseData(ResourceIdentifier id, string name, ResourceType type, string lastAvailableBackupDate) : base(id, name, type)
        {
            LastAvailableBackupDate = lastAvailableBackupDate;
        }

        /// <summary> The last available backup date. </summary>
        public string LastAvailableBackupDate { get; }
    }
}
