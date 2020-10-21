namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Duration based custom options to copy</summary>
    public partial class CustomCopyOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICustomCopyOption,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICustomCopyOptionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption __copyOption = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.CopyOption();

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private string _duration;

        /// <summary>Data copied after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOptionInternal)__copyOption).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOptionInternal)__copyOption).ObjectType = value; }

        /// <summary>Creates an new <see cref="CustomCopyOption" /> instance.</summary>
        public CustomCopyOption()
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
            await eventListener.AssertNotNull(nameof(__copyOption), __copyOption);
            await eventListener.AssertObjectIsValid(nameof(__copyOption), __copyOption);
        }
    }
    /// Duration based custom options to copy
    public partial interface ICustomCopyOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption
    {
        /// <summary>Data copied after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Data copied after given timespan",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string Duration { get; set; }

    }
    /// Duration based custom options to copy
    internal partial interface ICustomCopyOptionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOptionInternal
    {
        /// <summary>Data copied after given timespan</summary>
        string Duration { get; set; }

    }
}