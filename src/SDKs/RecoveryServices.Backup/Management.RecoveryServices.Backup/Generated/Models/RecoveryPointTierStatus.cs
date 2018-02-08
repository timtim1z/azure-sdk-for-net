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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecoveryPointTierStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecoveryPointTierStatus
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "Valid")]
        Valid,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    internal static class RecoveryPointTierStatusEnumExtension
    {
        internal static string ToSerializedValue(this RecoveryPointTierStatus? value)  =>
            value == null ? null : ((RecoveryPointTierStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this RecoveryPointTierStatus value)
        {
            switch( value )
            {
                case RecoveryPointTierStatus.Invalid:
                    return "Invalid";
                case RecoveryPointTierStatus.Valid:
                    return "Valid";
                case RecoveryPointTierStatus.Disabled:
                    return "Disabled";
                case RecoveryPointTierStatus.Deleted:
                    return "Deleted";
            }
            return null;
        }

        internal static RecoveryPointTierStatus? ParseRecoveryPointTierStatus(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return RecoveryPointTierStatus.Invalid;
                case "Valid":
                    return RecoveryPointTierStatus.Valid;
                case "Disabled":
                    return RecoveryPointTierStatus.Disabled;
                case "Deleted":
                    return RecoveryPointTierStatus.Deleted;
            }
            return null;
        }
    }
}
