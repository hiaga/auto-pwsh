namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Job's Additional Details</summary>
    public partial class JobExtendedInfoAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobExtendedInfoAdditionalDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobExtendedInfoAdditionalDetailsInternal
    {

        /// <summary>Creates an new <see cref="JobExtendedInfoAdditionalDetails" /> instance.</summary>
        public JobExtendedInfoAdditionalDetails()
        {

        }
    }
    /// Job's Additional Details
    public partial interface IJobExtendedInfoAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Job's Additional Details
    internal partial interface IJobExtendedInfoAdditionalDetailsInternal

    {

    }
}