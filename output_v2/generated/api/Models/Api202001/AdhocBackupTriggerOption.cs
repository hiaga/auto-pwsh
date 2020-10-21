namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Adhoc backup trigger option</summary>
    public partial class AdhocBackupTriggerOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdhocBackupTriggerOption,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdhocBackupTriggerOptionInternal
    {

        /// <summary>Backing field for <see cref="RetentionTagOverride" /> property.</summary>
        private string _retentionTagOverride;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string RetentionTagOverride { get => this._retentionTagOverride; set => this._retentionTagOverride = value; }

        /// <summary>Creates an new <see cref="AdhocBackupTriggerOption" /> instance.</summary>
        public AdhocBackupTriggerOption()
        {

        }
    }
    /// Adhoc backup trigger option
    public partial interface IAdhocBackupTriggerOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"retentionTagOverride",
        PossibleTypes = new [] { typeof(string) })]
        string RetentionTagOverride { get; set; }

    }
    /// Adhoc backup trigger option
    internal partial interface IAdhocBackupTriggerOptionInternal

    {
        string RetentionTagOverride { get; set; }

    }
}