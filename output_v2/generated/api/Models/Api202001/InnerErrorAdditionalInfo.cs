namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>
    /// Any Key value pairs that can be provided to the cleint for additional verbose information.
    /// </summary>
    public partial class InnerErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerErrorAdditionalInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerErrorAdditionalInfoInternal
    {

        /// <summary>Creates an new <see cref="InnerErrorAdditionalInfo" /> instance.</summary>
        public InnerErrorAdditionalInfo()
        {

        }
    }
    /// Any Key value pairs that can be provided to the cleint for additional verbose information.
    public partial interface IInnerErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Any Key value pairs that can be provided to the cleint for additional verbose information.
    internal partial interface IInnerErrorAdditionalInfoInternal

    {

    }
}