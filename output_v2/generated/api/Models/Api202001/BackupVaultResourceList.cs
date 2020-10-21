namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>List of BackupVault resources</summary>
    public partial class BackupVaultResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResourceListInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceList"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceList __dppResourceList = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DppResourceList();

        /// <summary>
        /// The uri to fetch the next page of resources. Call ListNext() fetches next page of resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string NextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceListInternal)__dppResourceList).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceListInternal)__dppResourceList).NextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResource[] _value;

        /// <summary>List of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="BackupVaultResourceList" /> instance.</summary>
        public BackupVaultResourceList()
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
            await eventListener.AssertNotNull(nameof(__dppResourceList), __dppResourceList);
            await eventListener.AssertObjectIsValid(nameof(__dppResourceList), __dppResourceList);
        }
    }
    /// List of BackupVault resources
    public partial interface IBackupVaultResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceList
    {
        /// <summary>List of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResource[] Value { get; set; }

    }
    /// List of BackupVault resources
    internal partial interface IBackupVaultResourceListInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceListInternal
    {
        /// <summary>List of resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupVaultResource[] Value { get; set; }

    }
}