namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Validate for backup request</summary>
    public partial class ValidateForBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IValidateForBackupRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IValidateForBackupRequestInternal
    {

        /// <summary>Backing field for <see cref="BackupInstance" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance _backupInstance;

        /// <summary>Backup instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance BackupInstance { get => (this._backupInstance = this._backupInstance ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupInstance()); set => this._backupInstance = value; }

        /// <summary>Creates an new <see cref="ValidateForBackupRequest" /> instance.</summary>
        public ValidateForBackupRequest()
        {

        }
    }
    /// Validate for backup request
    public partial interface IValidateForBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Backup instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Backup instance",
        SerializedName = @"backupInstance",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance BackupInstance { get; set; }

    }
    /// Validate for backup request
    internal partial interface IValidateForBackupRequestInternal

    {
        /// <summary>Backup instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance BackupInstance { get; set; }

    }
}