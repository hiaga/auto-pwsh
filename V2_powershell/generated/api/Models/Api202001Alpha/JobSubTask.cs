namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Details of Job's Sub Task</summary>
    public partial class JobSubTask :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTask,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskInternal
    {

        /// <summary>Backing field for <see cref="AdditionalDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails _additionalDetail;

        /// <summary>Sub Tasks's additional details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails AdditionalDetail { get => (this._additionalDetail = this._additionalDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.JobSubTaskAdditionalDetails()); set => this._additionalDetail = value; }

        /// <summary>Internal Acessors for TaskProgress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskInternal.TaskProgress { get => this._taskProgress; set { {_taskProgress = value;} } }

        /// <summary>Backing field for <see cref="TaskId" /> property.</summary>
        private int _taskId;

        /// <summary>Task Id of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public int TaskId { get => this._taskId; set => this._taskId = value; }

        /// <summary>Backing field for <see cref="TaskName" /> property.</summary>
        private string _taskName;

        /// <summary>Name of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string TaskName { get => this._taskName; set => this._taskName = value; }

        /// <summary>Backing field for <see cref="TaskProgress" /> property.</summary>
        private string _taskProgress;

        /// <summary>Progress of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string TaskProgress { get => this._taskProgress; }

        /// <summary>Backing field for <see cref="TaskStatus" /> property.</summary>
        private string _taskStatus;

        /// <summary>Status of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string TaskStatus { get => this._taskStatus; set => this._taskStatus = value; }

        /// <summary>Creates an new <see cref="JobSubTask" /> instance.</summary>
        public JobSubTask()
        {

        }
    }
    /// Details of Job's Sub Task
    public partial interface IJobSubTask :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Sub Tasks's additional details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sub Tasks's additional details",
        SerializedName = @"additionalDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails AdditionalDetail { get; set; }
        /// <summary>Task Id of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Task Id of the Sub Task",
        SerializedName = @"taskId",
        PossibleTypes = new [] { typeof(int) })]
        int TaskId { get; set; }
        /// <summary>Name of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the Sub Task",
        SerializedName = @"taskName",
        PossibleTypes = new [] { typeof(string) })]
        string TaskName { get; set; }
        /// <summary>Progress of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress of the Sub Task",
        SerializedName = @"taskProgress",
        PossibleTypes = new [] { typeof(string) })]
        string TaskProgress { get;  }
        /// <summary>Status of the Sub Task</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Status of the Sub Task",
        SerializedName = @"taskStatus",
        PossibleTypes = new [] { typeof(string) })]
        string TaskStatus { get; set; }

    }
    /// Details of Job's Sub Task
    internal partial interface IJobSubTaskInternal

    {
        /// <summary>Sub Tasks's additional details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IJobSubTaskAdditionalDetails AdditionalDetail { get; set; }
        /// <summary>Task Id of the Sub Task</summary>
        int TaskId { get; set; }
        /// <summary>Name of the Sub Task</summary>
        string TaskName { get; set; }
        /// <summary>Progress of the Sub Task</summary>
        string TaskProgress { get; set; }
        /// <summary>Status of the Sub Task</summary>
        string TaskStatus { get; set; }

    }
}