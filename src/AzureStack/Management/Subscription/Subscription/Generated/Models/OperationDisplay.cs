// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Display information for the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="description">Description for the operation.</param>
        /// <param name="operation">Display name of the operation.</param>
        /// <param name="provider">Resource provider display name.</param>
        /// <param name="resource">Resource type display name related to the
        /// operation.</param>
        public OperationDisplay(string description = default(string), string operation = default(string), string provider = default(string), string resource = default(string))
        {
            Description = description;
            Operation = operation;
            Provider = provider;
            Resource = resource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets description for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets display name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

        /// <summary>
        /// Gets resource provider display name.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets resource type display name related to the operation.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

    }
}
