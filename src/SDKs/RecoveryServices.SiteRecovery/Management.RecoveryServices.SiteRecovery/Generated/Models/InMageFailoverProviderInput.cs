// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provider specific input for InMage failover.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMage")]
    public partial class InMageFailoverProviderInput : ProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageFailoverProviderInput
        /// class.
        /// </summary>
        public InMageFailoverProviderInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageFailoverProviderInput
        /// class.
        /// </summary>
        /// <param name="recoveryPointType">The recovery point type. Values
        /// from LatestTime, LatestTag or Custom. In the case of custom, the
        /// recovery point provided by RecoveryPointId will be used. In the
        /// other two cases, recovery point id will be ignored. Possible values
        /// include: 'LatestTime', 'LatestTag', 'Custom'</param>
        /// <param name="recoveryPointId">The recovery point id to be passed to
        /// failover to a particular recovery point. In case of latest recovery
        /// point, null should be passed.</param>
        public InMageFailoverProviderInput(RecoveryPointType? recoveryPointType = default(RecoveryPointType?), string recoveryPointId = default(string))
        {
            RecoveryPointType = recoveryPointType;
            RecoveryPointId = recoveryPointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point type. Values from LatestTime,
        /// LatestTag or Custom. In the case of custom, the recovery point
        /// provided by RecoveryPointId will be used. In the other two cases,
        /// recovery point id will be ignored. Possible values include:
        /// 'LatestTime', 'LatestTag', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public RecoveryPointType? RecoveryPointType { get; set; }

        /// <summary>
        /// Gets or sets the recovery point id to be passed to failover to a
        /// particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

    }
}
