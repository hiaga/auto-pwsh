namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Adhoc backup rules</summary>
    public partial class AdHocBackupRuleOptions :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdHocBackupRuleOptions,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdHocBackupRuleOptionsInternal
    {

        /// <summary>Internal Acessors for TriggerOption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOption Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdHocBackupRuleOptionsInternal.TriggerOption { get => (this._triggerOption = this._triggerOption ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AdhocBackupTriggerOption()); set { {_triggerOption = value;} } }

        /// <summary>Backing field for <see cref="RuleName" /> property.</summary>
        private string _ruleName;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string RuleName { get => this._ruleName; set => this._ruleName = value; }

        /// <summary>Backing field for <see cref="TriggerOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOption _triggerOption;

        /// <summary>Adhoc backup trigger option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOption TriggerOption { get => (this._triggerOption = this._triggerOption ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AdhocBackupTriggerOption()); set => this._triggerOption = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string TriggerOptionRetentionTagOverride { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOptionInternal)TriggerOption).RetentionTagOverride; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOptionInternal)TriggerOption).RetentionTagOverride = value; }

        /// <summary>Creates an new <see cref="AdHocBackupRuleOptions" /> instance.</summary>
        public AdHocBackupRuleOptions()
        {

        }
    }
    /// Adhoc backup rules
    public partial interface IAdHocBackupRuleOptions :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ruleName",
        PossibleTypes = new [] { typeof(string) })]
        string RuleName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"retentionTagOverride",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerOptionRetentionTagOverride { get; set; }

    }
    /// Adhoc backup rules
    internal partial interface IAdHocBackupRuleOptionsInternal

    {
        string RuleName { get; set; }
        /// <summary>Adhoc backup trigger option</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAdhocBackupTriggerOption TriggerOption { get; set; }

        string TriggerOptionRetentionTagOverride { get; set; }

    }
}