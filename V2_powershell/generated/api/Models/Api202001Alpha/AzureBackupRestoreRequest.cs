namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Azure backup restore request</summary>
    public partial class AzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal
    {

        /// <summary>Internal Acessors for RestoreTargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal.RestoreTargetInfo { get => (this._restoreTargetInfo = this._restoreTargetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.RestoreTargetInfoBase()); set { {_restoreTargetInfo = value;} } }

        /// <summary>Internal Acessors for RestoreTargetInfoRecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal.RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption = value; }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="RestoreTargetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase _restoreTargetInfo;

        /// <summary>Gets or sets the restore target information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase RestoreTargetInfo { get => (this._restoreTargetInfo = this._restoreTargetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.RestoreTargetInfoBase()); set => this._restoreTargetInfo = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).ObjectType = value; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RestoreLocation = value; }

        /// <summary>Backing field for <see cref="SourceDataStoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType _sourceDataStoreType;

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType SourceDataStoreType { get => this._sourceDataStoreType; set => this._sourceDataStoreType = value; }

        /// <summary>Creates an new <see cref="AzureBackupRestoreRequest" /> instance.</summary>
        public AzureBackupRestoreRequest()
        {

        }
    }
    /// Azure backup restore request
    public partial interface IAzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Recovery Option",
        SerializedName = @"recoveryOption",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoRecoveryOption { get;  }
        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target Restore region",
        SerializedName = @"restoreLocation",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoRestoreLocation { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the type of the source data store.",
        SerializedName = @"sourceDataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType SourceDataStoreType { get; set; }

    }
    /// Azure backup restore request
    internal partial interface IAzureBackupRestoreRequestInternal

    {
        string ObjectType { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase RestoreTargetInfo { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        string RestoreTargetInfoRecoveryOption { get; set; }
        /// <summary>Target Restore region</summary>
        string RestoreTargetInfoRestoreLocation { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType SourceDataStoreType { get; set; }

    }
}