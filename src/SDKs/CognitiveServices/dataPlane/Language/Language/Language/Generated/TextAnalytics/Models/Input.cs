// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.CognitiveServices;
    using Microsoft.Azure.CognitiveServices.Language;
    using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Input
    {
        /// <summary>
        /// Initializes a new instance of the Input class.
        /// </summary>
        public Input()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Input class.
        /// </summary>
        /// <param name="id">Unique, non-empty document identifier.</param>
        public Input(string id = default(string), string text = default(string))
        {
            Id = id;
            Text = text;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique, non-empty document identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

    }
}
