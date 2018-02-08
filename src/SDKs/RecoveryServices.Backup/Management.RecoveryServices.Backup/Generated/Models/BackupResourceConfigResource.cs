// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource storage details.
    /// </summary>
    public partial class BackupResourceConfigResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BackupResourceConfigResource
        /// class.
        /// </summary>
        public BackupResourceConfigResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupResourceConfigResource
        /// class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="eTag">Optional ETag.</param>
        /// <param name="properties">BackupResourceConfigResource
        /// properties</param>
        public BackupResourceConfigResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string eTag = default(string), BackupResourceConfig properties = default(BackupResourceConfig))
            : base(id, name, type, location, tags, eTag)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backupResourceConfigResource properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BackupResourceConfig Properties { get; set; }

    }
}
