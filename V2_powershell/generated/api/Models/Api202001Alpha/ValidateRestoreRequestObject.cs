namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Validate restore request object</summary>
    public partial class ValidateRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal
    {

        /// <summary>Internal Acessors for RestoreRequestObject</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal.RestoreRequestObject { get => (this._restoreRequestObject = this._restoreRequestObject ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AzureBackupRestoreRequest()); set { {_restoreRequestObject = value;} } }

        /// <summary>Internal Acessors for RestoreRequestObjectRestoreTargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal.RestoreRequestObjectRestoreTargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo = value; }

        /// <summary>Internal Acessors for RestoreTargetInfoRecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal.RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption = value; }

        /// <summary>Backing field for <see cref="RestoreRequestObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest _restoreRequestObject;

        /// <summary>Gets or sets the restore request object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest RestoreRequestObject { get => (this._restoreRequestObject = this._restoreRequestObject ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AzureBackupRestoreRequest()); set => this._restoreRequestObject = value; }

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType RestoreRequestObjectSourceDataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceDataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceDataStoreType = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreRequestObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ObjectType = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoObjectType = value; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRestoreLocation = value; }

        /// <summary>Creates an new <see cref="ValidateRestoreRequestObject" /> instance.</summary>
        public ValidateRestoreRequestObject()
        {

        }
    }
    /// Validate restore request object
    public partial interface IValidateRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the type of the source data store.",
        SerializedName = @"sourceDataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType RestoreRequestObjectSourceDataStoreType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreRequestObjectType { get; set; }
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

    }
    /// Validate restore request object
    internal partial interface IValidateRestoreRequestObjectInternal

    {
        /// <summary>Gets or sets the restore request object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest RestoreRequestObject { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase RestoreRequestObjectRestoreTargetInfo { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType RestoreRequestObjectSourceDataStoreType { get; set; }

        string RestoreRequestObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        string RestoreTargetInfoRecoveryOption { get; set; }
        /// <summary>Target Restore region</summary>
        string RestoreTargetInfoRestoreLocation { get; set; }

    }
}