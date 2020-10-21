namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class DppTrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppTrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppTrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="DppTrackedResourceTags" /> instance.</summary>
        public DppTrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IDppTrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IDppTrackedResourceTagsInternal

    {

    }
}