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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of a Master Target Server.
    /// </summary>
    public partial class MasterTargetServer
    {
        /// <summary>
        /// Initializes a new instance of the MasterTargetServer class.
        /// </summary>
        public MasterTargetServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MasterTargetServer class.
        /// </summary>
        /// <param name="id">The server Id.</param>
        /// <param name="ipAddress">The IP address of the server.</param>
        /// <param name="name">The server name.</param>
        /// <param name="osType">The OS type of the server.</param>
        /// <param name="agentVersion">The version of the scout component on
        /// the server.</param>
        /// <param name="lastHeartbeat">The last heartbeat received from the
        /// server.</param>
        /// <param name="versionStatus">Version status</param>
        /// <param name="retentionVolumes">The retention volumes of Master
        /// target Server.</param>
        /// <param name="dataStores">The list of data stores in the
        /// fabric.</param>
        /// <param name="validationErrors">Validation errors.</param>
        /// <param name="diskCount">Disk count of the master target.</param>
        /// <param name="osVersion">OS Version of the master target.</param>
        public MasterTargetServer(string id = default(string), string ipAddress = default(string), string name = default(string), string osType = default(string), string agentVersion = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string versionStatus = default(string), IList<RetentionVolume> retentionVolumes = default(IList<RetentionVolume>), IList<DataStore> dataStores = default(IList<DataStore>), IList<HealthError> validationErrors = default(IList<HealthError>), int? diskCount = default(int?), string osVersion = default(string))
        {
            Id = id;
            IpAddress = ipAddress;
            Name = name;
            OsType = osType;
            AgentVersion = agentVersion;
            LastHeartbeat = lastHeartbeat;
            VersionStatus = versionStatus;
            RetentionVolumes = retentionVolumes;
            DataStores = dataStores;
            ValidationErrors = validationErrors;
            DiskCount = diskCount;
            OsVersion = osVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the server Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the server.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the server name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the OS type of the server.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the version of the scout component on the server.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets version status
        /// </summary>
        [JsonProperty(PropertyName = "versionStatus")]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Gets or sets the retention volumes of Master target Server.
        /// </summary>
        [JsonProperty(PropertyName = "retentionVolumes")]
        public IList<RetentionVolume> RetentionVolumes { get; set; }

        /// <summary>
        /// Gets or sets the list of data stores in the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "dataStores")]
        public IList<DataStore> DataStores { get; set; }

        /// <summary>
        /// Gets or sets validation errors.
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<HealthError> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets disk count of the master target.
        /// </summary>
        [JsonProperty(PropertyName = "diskCount")]
        public int? DiskCount { get; set; }

        /// <summary>
        /// Gets or sets OS Version of the master target.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

    }
}
