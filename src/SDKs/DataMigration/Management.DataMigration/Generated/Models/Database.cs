// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about a single database
    /// </summary>
    public partial class Database
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="id">Unique identifier for the database</param>
        /// <param name="name">Name of the database</param>
        /// <param name="compatibilityLevel">SQL Server compatibility level of
        /// database. Possible values include: 'CompatLevel80',
        /// 'CompatLevel90', 'CompatLevel100', 'CompatLevel110',
        /// 'CompatLevel120', 'CompatLevel130', 'CompatLevel140'</param>
        /// <param name="collation">Collation name of the database</param>
        /// <param name="serverName">Name of the server</param>
        /// <param name="fqdn">Fully qualified name</param>
        /// <param name="installId">Install id of the database</param>
        /// <param name="serverVersion">Version of the server</param>
        /// <param name="serverEdition">Edition of the server</param>
        /// <param name="serverLevel">Product level of the server (RTM, SP,
        /// CTP).</param>
        /// <param name="serverDefaultDataPath">Default path of the data
        /// files</param>
        /// <param name="serverDefaultLogPath">Default path of the log
        /// files</param>
        /// <param name="serverDefaultBackupPath">Default path of the backup
        /// folder</param>
        /// <param name="serverCoreCount">Number of cores on the server</param>
        /// <param name="serverVisibleOnlineCoreCount">Number of cores on the
        /// server that have VISIBLE ONLINE status</param>
        /// <param name="databaseState">State of the database. Possible values
        /// include: 'Online', 'Restoring', 'Recovering', 'RecoveryPending',
        /// 'Suspect', 'Emergency', 'Offline', 'Copying',
        /// 'OfflineSecondary'</param>
        /// <param name="serverId">The unique Server Id</param>
        public Database(string id = default(string), string name = default(string), DatabaseCompatLevel? compatibilityLevel = default(DatabaseCompatLevel?), string collation = default(string), string serverName = default(string), string fqdn = default(string), string installId = default(string), string serverVersion = default(string), string serverEdition = default(string), string serverLevel = default(string), string serverDefaultDataPath = default(string), string serverDefaultLogPath = default(string), string serverDefaultBackupPath = default(string), int? serverCoreCount = default(int?), int? serverVisibleOnlineCoreCount = default(int?), DatabaseState? databaseState = default(DatabaseState?), string serverId = default(string))
        {
            Id = id;
            Name = name;
            CompatibilityLevel = compatibilityLevel;
            Collation = collation;
            ServerName = serverName;
            Fqdn = fqdn;
            InstallId = installId;
            ServerVersion = serverVersion;
            ServerEdition = serverEdition;
            ServerLevel = serverLevel;
            ServerDefaultDataPath = serverDefaultDataPath;
            ServerDefaultLogPath = serverDefaultLogPath;
            ServerDefaultBackupPath = serverDefaultBackupPath;
            ServerCoreCount = serverCoreCount;
            ServerVisibleOnlineCoreCount = serverVisibleOnlineCoreCount;
            DatabaseState = databaseState;
            ServerId = serverId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the database
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the database
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SQL Server compatibility level of database. Possible
        /// values include: 'CompatLevel80', 'CompatLevel90', 'CompatLevel100',
        /// 'CompatLevel110', 'CompatLevel120', 'CompatLevel130',
        /// 'CompatLevel140'
        /// </summary>
        [JsonProperty(PropertyName = "compatibilityLevel")]
        public DatabaseCompatLevel? CompatibilityLevel { get; set; }

        /// <summary>
        /// Gets or sets collation name of the database
        /// </summary>
        [JsonProperty(PropertyName = "collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets name of the server
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets fully qualified name
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets install id of the database
        /// </summary>
        [JsonProperty(PropertyName = "installId")]
        public string InstallId { get; set; }

        /// <summary>
        /// Gets or sets version of the server
        /// </summary>
        [JsonProperty(PropertyName = "serverVersion")]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Gets or sets edition of the server
        /// </summary>
        [JsonProperty(PropertyName = "serverEdition")]
        public string ServerEdition { get; set; }

        /// <summary>
        /// Gets or sets product level of the server (RTM, SP, CTP).
        /// </summary>
        [JsonProperty(PropertyName = "serverLevel")]
        public string ServerLevel { get; set; }

        /// <summary>
        /// Gets or sets default path of the data files
        /// </summary>
        [JsonProperty(PropertyName = "serverDefaultDataPath")]
        public string ServerDefaultDataPath { get; set; }

        /// <summary>
        /// Gets or sets default path of the log files
        /// </summary>
        [JsonProperty(PropertyName = "serverDefaultLogPath")]
        public string ServerDefaultLogPath { get; set; }

        /// <summary>
        /// Gets or sets default path of the backup folder
        /// </summary>
        [JsonProperty(PropertyName = "serverDefaultBackupPath")]
        public string ServerDefaultBackupPath { get; set; }

        /// <summary>
        /// Gets or sets number of cores on the server
        /// </summary>
        [JsonProperty(PropertyName = "serverCoreCount")]
        public int? ServerCoreCount { get; set; }

        /// <summary>
        /// Gets or sets number of cores on the server that have VISIBLE ONLINE
        /// status
        /// </summary>
        [JsonProperty(PropertyName = "serverVisibleOnlineCoreCount")]
        public int? ServerVisibleOnlineCoreCount { get; set; }

        /// <summary>
        /// Gets or sets state of the database. Possible values include:
        /// 'Online', 'Restoring', 'Recovering', 'RecoveryPending', 'Suspect',
        /// 'Emergency', 'Offline', 'Copying', 'OfflineSecondary'
        /// </summary>
        [JsonProperty(PropertyName = "databaseState")]
        public DatabaseState? DatabaseState { get; set; }

        /// <summary>
        /// Gets or sets the unique Server Id
        /// </summary>
        [JsonProperty(PropertyName = "serverId")]
        public string ServerId { get; set; }

    }
}
