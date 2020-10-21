namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Azure Backup Rehydrate Request</summary>
    public partial class AzureBackupRehydrationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRehydrationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRehydrationRequestInternal
    {

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>Id of the recovery point to be recovered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Backing field for <see cref="RehydrationPriority" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority? _rehydrationPriority;

        /// <summary>Priority to be used for rehydration. Values High or Standard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority? RehydrationPriority { get => this._rehydrationPriority; set => this._rehydrationPriority = value; }

        /// <summary>Backing field for <see cref="RehydrationRetentionDuration" /> property.</summary>
        private string _rehydrationRetentionDuration;

        /// <summary>Retention duration in ISO 8601 format i.e P10D .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string RehydrationRetentionDuration { get => this._rehydrationRetentionDuration; set => this._rehydrationRetentionDuration = value; }

        /// <summary>Creates an new <see cref="AzureBackupRehydrationRequest" /> instance.</summary>
        public AzureBackupRehydrationRequest()
        {

        }
    }
    /// Azure Backup Rehydrate Request
    public partial interface IAzureBackupRehydrationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Id of the recovery point to be recovered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Id of the recovery point to be recovered",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }
        /// <summary>Priority to be used for rehydration. Values High or Standard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Priority to be used for rehydration. Values High or Standard",
        SerializedName = @"rehydrationPriority",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority? RehydrationPriority { get; set; }
        /// <summary>Retention duration in ISO 8601 format i.e P10D .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Retention duration in ISO 8601 format i.e P10D .",
        SerializedName = @"rehydrationRetentionDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RehydrationRetentionDuration { get; set; }

    }
    /// Azure Backup Rehydrate Request
    internal partial interface IAzureBackupRehydrationRequestInternal

    {
        /// <summary>Id of the recovery point to be recovered</summary>
        string RecoveryPointId { get; set; }
        /// <summary>Priority to be used for rehydration. Values High or Standard</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority? RehydrationPriority { get; set; }
        /// <summary>Retention duration in ISO 8601 format i.e P10D .</summary>
        string RehydrationRetentionDuration { get; set; }

    }
}