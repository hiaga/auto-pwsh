namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Delete option with duration</summary>
    public partial class AbsoluteDeleteOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAbsoluteDeleteOption,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAbsoluteDeleteOptionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOption"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOption __deleteOption = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.DeleteOption();

        /// <summary>Duration of deletion after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Duration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOptionInternal)__deleteOption).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOptionInternal)__deleteOption).Duration = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOptionInternal)__deleteOption).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOptionInternal)__deleteOption).ObjectType = value; }

        /// <summary>Creates an new <see cref="AbsoluteDeleteOption" /> instance.</summary>
        public AbsoluteDeleteOption()
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
            await eventListener.AssertNotNull(nameof(__deleteOption), __deleteOption);
            await eventListener.AssertObjectIsValid(nameof(__deleteOption), __deleteOption);
        }
    }
    /// Delete option with duration
    public partial interface IAbsoluteDeleteOption :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOption
    {

    }
    /// Delete option with duration
    internal partial interface IAbsoluteDeleteOptionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDeleteOptionInternal
    {

    }
}