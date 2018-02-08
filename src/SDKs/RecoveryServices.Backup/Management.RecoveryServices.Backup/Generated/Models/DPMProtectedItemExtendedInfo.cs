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
    /// Additional information of DPM Protected item.
    /// </summary>
    public partial class DPMProtectedItemExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the DPMProtectedItemExtendedInfo
        /// class.
        /// </summary>
        public DPMProtectedItemExtendedInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DPMProtectedItemExtendedInfo
        /// class.
        /// </summary>
        /// <param name="protectableObjectLoadPath">Attribute to provide
        /// information on various DBs.</param>
        /// <param name="protectedProperty">To check if backup item is disk
        /// protected.</param>
        /// <param name="isPresentOnCloud">To check if backup item is cloud
        /// protected.</param>
        /// <param name="lastBackupStatus">Last backup status information on
        /// backup item.</param>
        /// <param name="lastRefreshedAt">Last refresh time on backup
        /// item.</param>
        /// <param name="oldestRecoveryPoint">Oldest cloud recovery point
        /// time.</param>
        /// <param name="recoveryPointCount">cloud recovery point
        /// count.</param>
        /// <param name="onPremiseOldestRecoveryPoint">Oldest disk recovery
        /// point time.</param>
        /// <param name="onPremiseLatestRecoveryPoint">latest disk recovery
        /// point time.</param>
        /// <param name="onPremiseRecoveryPointCount">disk recovery point
        /// count.</param>
        /// <param name="isCollocated">To check if backup item is
        /// collocated.</param>
        /// <param name="protectionGroupName">Protection group name of the
        /// backup item.</param>
        /// <param name="diskStorageUsedInBytes">Used Disk storage in
        /// bytes.</param>
        /// <param name="totalDiskStorageSizeInBytes">total Disk storage in
        /// bytes.</param>
        public DPMProtectedItemExtendedInfo(IDictionary<string, string> protectableObjectLoadPath = default(IDictionary<string, string>), bool? protectedProperty = default(bool?), bool? isPresentOnCloud = default(bool?), string lastBackupStatus = default(string), System.DateTime? lastRefreshedAt = default(System.DateTime?), System.DateTime? oldestRecoveryPoint = default(System.DateTime?), int? recoveryPointCount = default(int?), System.DateTime? onPremiseOldestRecoveryPoint = default(System.DateTime?), System.DateTime? onPremiseLatestRecoveryPoint = default(System.DateTime?), int? onPremiseRecoveryPointCount = default(int?), bool? isCollocated = default(bool?), string protectionGroupName = default(string), string diskStorageUsedInBytes = default(string), string totalDiskStorageSizeInBytes = default(string))
        {
            ProtectableObjectLoadPath = protectableObjectLoadPath;
            ProtectedProperty = protectedProperty;
            IsPresentOnCloud = isPresentOnCloud;
            LastBackupStatus = lastBackupStatus;
            LastRefreshedAt = lastRefreshedAt;
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            OnPremiseOldestRecoveryPoint = onPremiseOldestRecoveryPoint;
            OnPremiseLatestRecoveryPoint = onPremiseLatestRecoveryPoint;
            OnPremiseRecoveryPointCount = onPremiseRecoveryPointCount;
            IsCollocated = isCollocated;
            ProtectionGroupName = protectionGroupName;
            DiskStorageUsedInBytes = diskStorageUsedInBytes;
            TotalDiskStorageSizeInBytes = totalDiskStorageSizeInBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets attribute to provide information on various DBs.
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectLoadPath")]
        public IDictionary<string, string> ProtectableObjectLoadPath { get; set; }

        /// <summary>
        /// Gets or sets to check if backup item is disk protected.
        /// </summary>
        [JsonProperty(PropertyName = "protected")]
        public bool? ProtectedProperty { get; set; }

        /// <summary>
        /// Gets or sets to check if backup item is cloud protected.
        /// </summary>
        [JsonProperty(PropertyName = "isPresentOnCloud")]
        public bool? IsPresentOnCloud { get; set; }

        /// <summary>
        /// Gets or sets last backup status information on backup item.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupStatus")]
        public string LastBackupStatus { get; set; }

        /// <summary>
        /// Gets or sets last refresh time on backup item.
        /// </summary>
        [JsonProperty(PropertyName = "lastRefreshedAt")]
        public System.DateTime? LastRefreshedAt { get; set; }

        /// <summary>
        /// Gets or sets oldest cloud recovery point time.
        /// </summary>
        [JsonProperty(PropertyName = "oldestRecoveryPoint")]
        public System.DateTime? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets cloud recovery point count.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointCount")]
        public int? RecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets oldest disk recovery point time.
        /// </summary>
        [JsonProperty(PropertyName = "onPremiseOldestRecoveryPoint")]
        public System.DateTime? OnPremiseOldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets latest disk recovery point time.
        /// </summary>
        [JsonProperty(PropertyName = "onPremiseLatestRecoveryPoint")]
        public System.DateTime? OnPremiseLatestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets disk recovery point count.
        /// </summary>
        [JsonProperty(PropertyName = "onPremiseRecoveryPointCount")]
        public int? OnPremiseRecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets to check if backup item is collocated.
        /// </summary>
        [JsonProperty(PropertyName = "isCollocated")]
        public bool? IsCollocated { get; set; }

        /// <summary>
        /// Gets or sets protection group name of the backup item.
        /// </summary>
        [JsonProperty(PropertyName = "protectionGroupName")]
        public string ProtectionGroupName { get; set; }

        /// <summary>
        /// Gets or sets used Disk storage in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskStorageUsedInBytes")]
        public string DiskStorageUsedInBytes { get; set; }

        /// <summary>
        /// Gets or sets total Disk storage in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "totalDiskStorageSizeInBytes")]
        public string TotalDiskStorageSizeInBytes { get; set; }

    }
}
