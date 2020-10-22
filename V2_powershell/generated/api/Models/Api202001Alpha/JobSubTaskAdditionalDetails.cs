namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Sub Tasks's additional details</summary>
    public partial class JobSubTaskAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetailsInternal
    {

        /// <summary>Creates an new <see cref="JobSubTaskAdditionalDetails" /> instance.</summary>
        public JobSubTaskAdditionalDetails()
        {

        }
    }
    /// Sub Tasks's additional details
    public partial interface IJobSubTaskAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Sub Tasks's additional details
    internal partial interface IJobSubTaskAdditionalDetailsInternal

    {

    }
}