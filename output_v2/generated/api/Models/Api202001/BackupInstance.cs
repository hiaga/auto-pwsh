namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Backup instance</summary>
    public partial class BackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal
    {

        /// <summary>Backing field for <see cref="DataSourceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource _dataSourceInfo;

        /// <summary>Gets or sets the data source information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource DataSourceInfo { get => (this._dataSourceInfo = this._dataSourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.Datasource()); set => this._dataSourceInfo = value; }

        /// <summary>Backing field for <see cref="DataSourceSetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet _dataSourceSetInfo;

        /// <summary>Gets or sets the data source set information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet DataSourceSetInfo { get => (this._dataSourceSetInfo = this._dataSourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceSet()); set => this._dataSourceSetInfo = value; }

        /// <summary>Internal Acessors for ProtectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal.ProtectionStatus { get => (this._protectionStatus = this._protectionStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails()); set { {_protectionStatus = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="PolicyInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo _policyInfo;

        /// <summary>Gets or sets the policy information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo PolicyInfo { get => (this._policyInfo = this._policyInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.PolicyInfo()); set => this._policyInfo = value; }

        /// <summary>Backing field for <see cref="ProtectionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails _protectionStatus;

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails ProtectionStatus { get => (this._protectionStatus = this._protectionStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails()); }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="BackupInstance" /> instance.</summary>
        public BackupInstance()
        {

        }
    }
    /// Backup instance
    public partial interface IBackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the data source information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the data source information.",
        SerializedName = @"dataSourceInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource DataSourceInfo { get; set; }
        /// <summary>Gets or sets the data source set information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the data source set information.",
        SerializedName = @"dataSourceSetInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet DataSourceSetInfo { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
        /// <summary>Gets or sets the policy information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the policy information.",
        SerializedName = @"policyInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo PolicyInfo { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the protection status of the resource",
        SerializedName = @"protectionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails ProtectionStatus { get;  }
        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// Backup instance
    internal partial interface IBackupInstanceInternal

    {
        /// <summary>Gets or sets the data source information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource DataSourceInfo { get; set; }
        /// <summary>Gets or sets the data source set information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet DataSourceSetInfo { get; set; }

        string ObjectType { get; set; }
        /// <summary>Gets or sets the policy information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo PolicyInfo { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails ProtectionStatus { get; set; }
        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        string ProvisioningState { get; set; }

    }
}