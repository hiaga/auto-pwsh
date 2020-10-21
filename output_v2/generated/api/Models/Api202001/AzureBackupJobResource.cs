namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>AzureBackup Job Resource Class</summary>
    public partial class AzureBackupJobResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResource __dppResource = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DppResource();

        /// <summary>Job Activity Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ActivityId = value; }

        /// <summary>Name of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string BackupInstanceFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).BackupInstanceFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).BackupInstanceFriendlyName = value; }

        /// <summary>ARM ID of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string BackupInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).BackupInstanceId; }

        /// <summary>ARM ID of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataSourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceId = value; }

        /// <summary>Location of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataSourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceLocation = value; }

        /// <summary>User Friendly Name of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataSourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceName = value; }

        /// <summary>Data Source Set Name of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataSourceSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceSetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceSetName = value; }

        /// <summary>Type of DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataSourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).DataSourceType = value; }

        /// <summary>Total run time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? Duration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Duration; }

        /// <summary>EndTime of the job(in UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).EndTime; }

        /// <summary>A List, detatiling the errors related to the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ErrorDetail; }

        /// <summary>Job's Additional Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails ExtendedInfoAdditionalDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoAdditionalDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoAdditionalDetail = value; }

        /// <summary>State of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoBackupInstanceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoBackupInstanceState; }

        /// <summary>Number of bytes transfered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public double? ExtendedInfoDataTransferedInByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoDataTransferedInByte; }

        /// <summary>Destination where restore is done</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoRecoveryDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoRecoveryDestination; }

        /// <summary>List of Sub Tasks of the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[] ExtendedInfoSubTask { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoSubTask; }

        /// <summary>Resource Id represents the complete path to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Id; }

        /// <summary>Indicated that whether the job is adhoc(true) or scheduled(false)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public bool IsUserTriggered { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).IsUserTriggered; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).IsUserTriggered = value; }

        /// <summary>Internal Acessors for BackupInstanceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.BackupInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).BackupInstanceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).BackupInstanceId = value; }

        /// <summary>Internal Acessors for Duration</summary>
        global::System.TimeSpan? Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.Duration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Duration = value; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).EndTime = value; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ErrorDetail = value; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfo = value; }

        /// <summary>Internal Acessors for ExtendedInfoBackupInstanceState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoBackupInstanceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoBackupInstanceState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoBackupInstanceState = value; }

        /// <summary>Internal Acessors for ExtendedInfoDataTransferedInByte</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoDataTransferedInByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoDataTransferedInByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoDataTransferedInByte = value; }

        /// <summary>Internal Acessors for ExtendedInfoRecoveryDestination</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoRecoveryDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoRecoveryDestination; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoRecoveryDestination = value; }

        /// <summary>Internal Acessors for ExtendedInfoSourceRecoverPoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoSourceRecoverPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoSourceRecoverPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoSourceRecoverPoint = value; }

        /// <summary>Internal Acessors for ExtendedInfoSubTask</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[] Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoSubTask { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoSubTask; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoSubTask = value; }

        /// <summary>Internal Acessors for ExtendedInfoTargetRecoverPoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ExtendedInfoTargetRecoverPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoTargetRecoverPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ExtendedInfoTargetRecoverPoint = value; }

        /// <summary>Internal Acessors for PolicyId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyId = value; }

        /// <summary>Internal Acessors for PolicyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.PolicyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyName = value; }

        /// <summary>Internal Acessors for ProgressUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.ProgressUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ProgressUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ProgressUrl = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RestoreType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobResourceInternal.RestoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).RestoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).RestoreType = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Type = value; }

        /// <summary>Resource name associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Name; }

        /// <summary>
        /// It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Retention:Backup/Archive ; Management:ConfigureProtection/UnConfigure
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string Operation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Operation = value; }

        /// <summary>It indicates the type of Job i.e. Backup/Restore/Retention/Management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string OperationCategory { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).OperationCategory; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).OperationCategory = value; }

        /// <summary>ARM ID of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyId; }

        /// <summary>Name of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string PolicyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).PolicyName; }

        /// <summary>Indicated whether progress is enabled for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public bool ProgressEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ProgressEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ProgressEnabled = value; }

        /// <summary>Url which contains job's progress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ProgressUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).ProgressUrl; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob _property;

        /// <summary>AzureBackupJobResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob()); set => this._property = value; }

        /// <summary>
        /// It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string RestoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).RestoreType; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string SourceRecoverPointRecoveryPointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceRecoverPointRecoveryPointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceRecoverPointRecoveryPointId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? SourceRecoverPointRecoveryPointTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceRecoverPointRecoveryPointTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceRecoverPointRecoveryPointTime = value; }

        /// <summary>Name of the Datasource's Resource Group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string SourceResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceResourceGroup = value; }

        /// <summary>SubscriptionId corresponding to the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string SourceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SourceSubscriptionId = value; }

        /// <summary>StartTime of the job(in UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).StartTime = value; }

        /// <summary>Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).Status = value; }

        /// <summary>Subscription Id of the corresponding backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SubscriptionId = value; }

        /// <summary>List of supported actions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string[] SupportedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SupportedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).SupportedAction = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string TargetRecoverPointRecoveryPointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).TargetRecoverPointRecoveryPointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).TargetRecoverPointRecoveryPointId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? TargetRecoverPointRecoveryPointTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).TargetRecoverPointRecoveryPointTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).TargetRecoverPointRecoveryPointTime = value; }

        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal)__dppResource).Type; }

        /// <summary>Name of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string VaultName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).VaultName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)Property).VaultName = value; }

        /// <summary>Creates an new <see cref="AzureBackupJobResource" /> instance.</summary>
        public AzureBackupJobResource()
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
            await eventListener.AssertNotNull(nameof(__dppResource), __dppResource);
            await eventListener.AssertObjectIsValid(nameof(__dppResource), __dppResource);
        }
    }
    /// AzureBackup Job Resource Class
    public partial interface IAzureBackupJobResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResource
    {
        /// <summary>Job Activity Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Job Activity Id",
        SerializedName = @"activityID",
        PossibleTypes = new [] { typeof(string) })]
        string ActivityId { get; set; }
        /// <summary>Name of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the Backup Instance",
        SerializedName = @"backupInstanceFriendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInstanceFriendlyName { get; set; }
        /// <summary>ARM ID of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ARM ID of the Backup Instance",
        SerializedName = @"backupInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInstanceId { get;  }
        /// <summary>ARM ID of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ARM ID of the DataSource",
        SerializedName = @"dataSourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceId { get; set; }
        /// <summary>Location of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Location of the DataSource",
        SerializedName = @"dataSourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceLocation { get; set; }
        /// <summary>User Friendly Name of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"User Friendly Name of the DataSource",
        SerializedName = @"dataSourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceName { get; set; }
        /// <summary>Data Source Set Name of the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Data Source Set Name of the DataSource",
        SerializedName = @"dataSourceSetName",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetName { get; set; }
        /// <summary>Type of DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of DataSource",
        SerializedName = @"dataSourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceType { get; set; }
        /// <summary>Total run time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total run time of the job.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? Duration { get;  }
        /// <summary>EndTime of the job(in UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"EndTime of the job(in UTC)",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>A List, detatiling the errors related to the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A List, detatiling the errors related to the job",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetail { get;  }
        /// <summary>Job's Additional Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Job's Additional Details",
        SerializedName = @"additionalDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails ExtendedInfoAdditionalDetail { get; set; }
        /// <summary>State of the Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the Backup Instance",
        SerializedName = @"backupInstanceState",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoBackupInstanceState { get;  }
        /// <summary>Number of bytes transfered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of bytes transfered",
        SerializedName = @"dataTransferedInBytes",
        PossibleTypes = new [] { typeof(double) })]
        double? ExtendedInfoDataTransferedInByte { get;  }
        /// <summary>Destination where restore is done</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Destination where restore is done",
        SerializedName = @"recoveryDestination",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoRecoveryDestination { get;  }
        /// <summary>List of Sub Tasks of the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of Sub Tasks of the job",
        SerializedName = @"subTasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[] ExtendedInfoSubTask { get;  }
        /// <summary>Indicated that whether the job is adhoc(true) or scheduled(false)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Indicated that whether the job is adhoc(true) or scheduled(false)",
        SerializedName = @"isUserTriggered",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsUserTriggered { get; set; }
        /// <summary>
        /// It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Retention:Backup/Archive ; Management:ConfigureProtection/UnConfigure
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Retention:Backup/Archive ; Management:ConfigureProtection/UnConfigure",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string Operation { get; set; }
        /// <summary>It indicates the type of Job i.e. Backup/Restore/Retention/Management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"It indicates the type of Job i.e. Backup/Restore/Retention/Management",
        SerializedName = @"operationCategory",
        PossibleTypes = new [] { typeof(string) })]
        string OperationCategory { get; set; }
        /// <summary>ARM ID of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ARM ID of the policy",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get;  }
        /// <summary>Name of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the policy",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get;  }
        /// <summary>Indicated whether progress is enabled for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Indicated whether progress is enabled for the job",
        SerializedName = @"progressEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool ProgressEnabled { get; set; }
        /// <summary>Url which contains job's progress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Url which contains job's progress",
        SerializedName = @"progressUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressUrl { get;  }
        /// <summary>
        /// It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR",
        SerializedName = @"restoreType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreType { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPointID",
        PossibleTypes = new [] { typeof(string) })]
        string SourceRecoverPointRecoveryPointId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPointTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SourceRecoverPointRecoveryPointTime { get; set; }
        /// <summary>Name of the Datasource's Resource Group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the Datasource's Resource Group",
        SerializedName = @"sourceResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceGroup { get; set; }
        /// <summary>SubscriptionId corresponding to the DataSource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"SubscriptionId corresponding to the DataSource",
        SerializedName = @"sourceSubscriptionID",
        PossibleTypes = new [] { typeof(string) })]
        string SourceSubscriptionId { get; set; }
        /// <summary>StartTime of the job(in UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"StartTime of the job(in UTC)",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTime { get; set; }
        /// <summary>Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>Subscription Id of the corresponding backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Subscription Id of the corresponding backup vault",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>List of supported actions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"List of supported actions",
        SerializedName = @"supportedActions",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedAction { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPointID",
        PossibleTypes = new [] { typeof(string) })]
        string TargetRecoverPointRecoveryPointId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPointTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TargetRecoverPointRecoveryPointTime { get; set; }
        /// <summary>Name of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the vault",
        SerializedName = @"vaultName",
        PossibleTypes = new [] { typeof(string) })]
        string VaultName { get; set; }

    }
    /// AzureBackup Job Resource Class
    internal partial interface IAzureBackupJobResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppResourceInternal
    {
        /// <summary>Job Activity Id</summary>
        string ActivityId { get; set; }
        /// <summary>Name of the Backup Instance</summary>
        string BackupInstanceFriendlyName { get; set; }
        /// <summary>ARM ID of the Backup Instance</summary>
        string BackupInstanceId { get; set; }
        /// <summary>ARM ID of the DataSource</summary>
        string DataSourceId { get; set; }
        /// <summary>Location of the DataSource</summary>
        string DataSourceLocation { get; set; }
        /// <summary>User Friendly Name of the DataSource</summary>
        string DataSourceName { get; set; }
        /// <summary>Data Source Set Name of the DataSource</summary>
        string DataSourceSetName { get; set; }
        /// <summary>Type of DataSource</summary>
        string DataSourceType { get; set; }
        /// <summary>Total run time of the job.</summary>
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>EndTime of the job(in UTC)</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>A List, detatiling the errors related to the job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetail { get; set; }
        /// <summary>Extended Information about the job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfo ExtendedInfo { get; set; }
        /// <summary>Job's Additional Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails ExtendedInfoAdditionalDetail { get; set; }
        /// <summary>State of the Backup Instance</summary>
        string ExtendedInfoBackupInstanceState { get; set; }
        /// <summary>Number of bytes transfered</summary>
        double? ExtendedInfoDataTransferedInByte { get; set; }
        /// <summary>Destination where restore is done</summary>
        string ExtendedInfoRecoveryDestination { get; set; }
        /// <summary>Details of the Source Recovery Point</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails ExtendedInfoSourceRecoverPoint { get; set; }
        /// <summary>List of Sub Tasks of the job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[] ExtendedInfoSubTask { get; set; }
        /// <summary>Details of the Target Recovery Point</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails ExtendedInfoTargetRecoverPoint { get; set; }
        /// <summary>Indicated that whether the job is adhoc(true) or scheduled(false)</summary>
        bool IsUserTriggered { get; set; }
        /// <summary>
        /// It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Retention:Backup/Archive ; Management:ConfigureProtection/UnConfigure
        /// </summary>
        string Operation { get; set; }
        /// <summary>It indicates the type of Job i.e. Backup/Restore/Retention/Management</summary>
        string OperationCategory { get; set; }
        /// <summary>ARM ID of the policy</summary>
        string PolicyId { get; set; }
        /// <summary>Name of the policy</summary>
        string PolicyName { get; set; }
        /// <summary>Indicated whether progress is enabled for the job</summary>
        bool ProgressEnabled { get; set; }
        /// <summary>Url which contains job's progress</summary>
        string ProgressUrl { get; set; }
        /// <summary>AzureBackupJobResource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob Property { get; set; }
        /// <summary>
        /// It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR
        /// </summary>
        string RestoreType { get; set; }

        string SourceRecoverPointRecoveryPointId { get; set; }

        global::System.DateTime? SourceRecoverPointRecoveryPointTime { get; set; }
        /// <summary>Name of the Datasource's Resource Group</summary>
        string SourceResourceGroup { get; set; }
        /// <summary>SubscriptionId corresponding to the DataSource</summary>
        string SourceSubscriptionId { get; set; }
        /// <summary>StartTime of the job(in UTC)</summary>
        global::System.DateTime StartTime { get; set; }
        /// <summary>Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning</summary>
        string Status { get; set; }
        /// <summary>Subscription Id of the corresponding backup vault</summary>
        string SubscriptionId { get; set; }
        /// <summary>List of supported actions</summary>
        string[] SupportedAction { get; set; }

        string TargetRecoverPointRecoveryPointId { get; set; }

        global::System.DateTime? TargetRecoverPointRecoveryPointTime { get; set; }
        /// <summary>Name of the vault</summary>
        string VaultName { get; set; }

    }
}