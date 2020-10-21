namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Policy Info in backupInstance</summary>
    public partial class PolicyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfoInternal
    {

        /// <summary>Internal Acessors for PolicyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfoInternal.PolicyVersion { get => this._policyVersion; set { {_policyVersion = value;} } }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="PolicyVersion" /> property.</summary>
        private string _policyVersion;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string PolicyVersion { get => this._policyVersion; }

        /// <summary>Creates an new <see cref="PolicyInfo" /> instance.</summary>
        public PolicyInfo()
        {

        }
    }
    /// Policy Info in backupInstance
    public partial interface IPolicyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"policyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyVersion { get;  }

    }
    /// Policy Info in backupInstance
    internal partial interface IPolicyInfoInternal

    {
        string PolicyId { get; set; }

        string PolicyVersion { get; set; }

    }
}