namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Azure retention rule</summary>
    public partial class AzureRetentionRule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureRetentionRule,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureRetentionRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRule"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRule __basePolicyRule = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.BasePolicyRule();

        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public bool? IsDefault { get => this._isDefault; set => this._isDefault = value; }

        /// <summary>Backing field for <see cref="Lifecycle" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ISourceLifeCycle[] _lifecycle;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ISourceLifeCycle[] Lifecycle { get => this._lifecycle; set => this._lifecycle = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRuleInternal)__basePolicyRule).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRuleInternal)__basePolicyRule).Name = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRuleInternal)__basePolicyRule).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRuleInternal)__basePolicyRule).ObjectType = value; }

        /// <summary>Creates an new <see cref="AzureRetentionRule" /> instance.</summary>
        public AzureRetentionRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__basePolicyRule), __basePolicyRule);
            await eventListener.AssertObjectIsValid(nameof(__basePolicyRule), __basePolicyRule);
        }
    }
    /// Azure retention rule
    public partial interface IAzureRetentionRule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRule
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefault { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lifecycles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ISourceLifeCycle) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ISourceLifeCycle[] Lifecycle { get; set; }

    }
    /// Azure retention rule
    internal partial interface IAzureRetentionRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBasePolicyRuleInternal
    {
        bool? IsDefault { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ISourceLifeCycle[] Lifecycle { get; set; }

    }
}