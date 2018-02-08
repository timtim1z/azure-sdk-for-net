// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Consumer group operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConsumerGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConsumerGroup class.
        /// </summary>
        public ConsumerGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumerGroup class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="createdAt">Exact time the message was created.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        /// <param name="userMetadata">Usermetadata is a placeholder to store
        /// user-defined string data with maximum length 1024. e.g. it can be
        /// used to store descriptive data, such as list of teams and their
        /// contact information also user-defined configuration settings can be
        /// stored.</param>
        public ConsumerGroup(string id = default(string), string name = default(string), string type = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string userMetadata = default(string))
            : base(id, name, type)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserMetadata = userMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or sets usermetadata is a placeholder to store user-defined
        /// string data with maximum length 1024. e.g. it can be used to store
        /// descriptive data, such as list of teams and their contact
        /// information also user-defined configuration settings can be stored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userMetadata")]
        public string UserMetadata { get; set; }

    }
}
