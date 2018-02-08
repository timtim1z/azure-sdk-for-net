// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information on the configuration of flow log.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FlowLogInformation
    {
        /// <summary>
        /// Initializes a new instance of the FlowLogInformation class.
        /// </summary>
        public FlowLogInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlowLogInformation class.
        /// </summary>
        /// <param name="targetResourceId">The ID of the resource to configure
        /// for flow logging.</param>
        /// <param name="storageId">ID of the storage account which is used to
        /// store the flow log.</param>
        /// <param name="enabled">Flag to enable/disable flow logging.</param>
        public FlowLogInformation(string targetResourceId, string storageId, bool enabled, RetentionPolicyParameters retentionPolicy = default(RetentionPolicyParameters))
        {
            TargetResourceId = targetResourceId;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the resource to configure for flow logging.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets or sets ID of the storage account which is used to store the
        /// flow log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// Gets or sets flag to enable/disable flow logging.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicyParameters RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (StorageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageId");
            }
        }
    }
}
