// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Deploy Configuration operation.
    /// </summary>
    public partial class DeployConfigurationParameters
    {
        /// <summary>
        /// Initializes a new instance of the DeployConfigurationParameters
        /// class.
        /// </summary>
        public DeployConfigurationParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeployConfigurationParameters
        /// class.
        /// </summary>
        /// <param name="branch">The name of the Git branch from which the
        /// configuration is to be deployed to the configuration
        /// database.</param>
        /// <param name="force">The value enforcing deleting subscriptions to
        /// products that are deleted in this update.</param>
        public DeployConfigurationParameters(string branch, bool? force = default(bool?))
        {
            Branch = branch;
            Force = force;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Git branch from which the
        /// configuration is to be deployed to the configuration database.
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the value enforcing deleting subscriptions to products
        /// that are deleted in this update.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Branch == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Branch");
            }
        }
    }
}
