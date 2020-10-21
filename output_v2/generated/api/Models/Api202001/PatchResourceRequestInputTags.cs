namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class PatchResourceRequestInputTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPatchResourceRequestInputTags,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPatchResourceRequestInputTagsInternal
    {

        /// <summary>Creates an new <see cref="PatchResourceRequestInputTags" /> instance.</summary>
        public PatchResourceRequestInputTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IPatchResourceRequestInputTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IPatchResourceRequestInputTagsInternal

    {

    }
}