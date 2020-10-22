namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Schedule for backup</summary>
    public partial class BackupSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupScheduleInternal
    {

        /// <summary>Backing field for <see cref="RepeatingTimeInterval" /> property.</summary>
        private string[] _repeatingTimeInterval;

        /// <summary>ISO 8601 repeating time interval format</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string[] RepeatingTimeInterval { get => this._repeatingTimeInterval; set => this._repeatingTimeInterval = value; }

        /// <summary>Creates an new <see cref="BackupSchedule" /> instance.</summary>
        public BackupSchedule()
        {

        }
    }
    /// Schedule for backup
    public partial interface IBackupSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>ISO 8601 repeating time interval format</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ISO 8601 repeating time interval format",
        SerializedName = @"repeatingTimeIntervals",
        PossibleTypes = new [] { typeof(string) })]
        string[] RepeatingTimeInterval { get; set; }

    }
    /// Schedule for backup
    internal partial interface IBackupScheduleInternal

    {
        /// <summary>ISO 8601 repeating time interval format</summary>
        string[] RepeatingTimeInterval { get; set; }

    }
}