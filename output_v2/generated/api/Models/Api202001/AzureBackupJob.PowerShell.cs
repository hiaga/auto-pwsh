namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>AzureBackup Job Class</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureBackupJobTypeConverter))]
    public partial class AzureBackupJob
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureBackupJob(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobExtendedInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ActivityId = (string) content.GetValueForProperty("ActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ActivityId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceFriendlyName = (string) content.GetValueForProperty("BackupInstanceFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceId = (string) content.GetValueForProperty("BackupInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceId = (string) content.GetValueForProperty("DataSourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceLocation = (string) content.GetValueForProperty("DataSourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceName = (string) content.GetValueForProperty("DataSourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceSetName = (string) content.GetValueForProperty("DataSourceSetName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceSetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceType = (string) content.GetValueForProperty("DataSourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Duration = (global::System.TimeSpan?) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Duration, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).IsUserTriggered = (bool) content.GetValueForProperty("IsUserTriggered",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).IsUserTriggered, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Operation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).OperationCategory = (string) content.GetValueForProperty("OperationCategory",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).OperationCategory, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressEnabled = (bool) content.GetValueForProperty("ProgressEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressUrl = (string) content.GetValueForProperty("ProgressUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).RestoreType = (string) content.GetValueForProperty("RestoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).RestoreType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceResourceGroup = (string) content.GetValueForProperty("SourceResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceSubscriptionId = (string) content.GetValueForProperty("SourceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceSubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).StartTime = (global::System.DateTime) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Status, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SupportedAction = (string[]) content.GetValueForProperty("SupportedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SupportedAction, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).VaultName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoRecoveryDestination = (string) content.GetValueForProperty("ExtendedInfoRecoveryDestination",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoRecoveryDestination, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSourceRecoverPoint = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails) content.GetValueForProperty("ExtendedInfoSourceRecoverPoint",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSourceRecoverPoint, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RestoreJobRecoveryPointDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoAdditionalDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails) content.GetValueForProperty("ExtendedInfoAdditionalDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoAdditionalDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobExtendedInfoAdditionalDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoBackupInstanceState = (string) content.GetValueForProperty("ExtendedInfoBackupInstanceState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoBackupInstanceState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoDataTransferedInByte = (double?) content.GetValueForProperty("ExtendedInfoDataTransferedInByte",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoDataTransferedInByte, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoTargetRecoverPoint = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails) content.GetValueForProperty("ExtendedInfoTargetRecoverPoint",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoTargetRecoverPoint, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RestoreJobRecoveryPointDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSubTask = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[]) content.GetValueForProperty("ExtendedInfoSubTask",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSubTask, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobSubTaskTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointId = (string) content.GetValueForProperty("SourceRecoverPointRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("SourceRecoverPointRecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointId = (string) content.GetValueForProperty("TargetRecoverPointRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("TargetRecoverPointRecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureBackupJob(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobExtendedInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ActivityId = (string) content.GetValueForProperty("ActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ActivityId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceFriendlyName = (string) content.GetValueForProperty("BackupInstanceFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceId = (string) content.GetValueForProperty("BackupInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).BackupInstanceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceId = (string) content.GetValueForProperty("DataSourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceLocation = (string) content.GetValueForProperty("DataSourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceName = (string) content.GetValueForProperty("DataSourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceSetName = (string) content.GetValueForProperty("DataSourceSetName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceSetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceType = (string) content.GetValueForProperty("DataSourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).DataSourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Duration = (global::System.TimeSpan?) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Duration, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).IsUserTriggered = (bool) content.GetValueForProperty("IsUserTriggered",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).IsUserTriggered, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Operation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).OperationCategory = (string) content.GetValueForProperty("OperationCategory",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).OperationCategory, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).PolicyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressEnabled = (bool) content.GetValueForProperty("ProgressEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressUrl = (string) content.GetValueForProperty("ProgressUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ProgressUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).RestoreType = (string) content.GetValueForProperty("RestoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).RestoreType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceResourceGroup = (string) content.GetValueForProperty("SourceResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceSubscriptionId = (string) content.GetValueForProperty("SourceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceSubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).StartTime = (global::System.DateTime) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).Status, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SupportedAction = (string[]) content.GetValueForProperty("SupportedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SupportedAction, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).VaultName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoRecoveryDestination = (string) content.GetValueForProperty("ExtendedInfoRecoveryDestination",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoRecoveryDestination, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSourceRecoverPoint = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails) content.GetValueForProperty("ExtendedInfoSourceRecoverPoint",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSourceRecoverPoint, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RestoreJobRecoveryPointDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoAdditionalDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobExtendedInfoAdditionalDetails) content.GetValueForProperty("ExtendedInfoAdditionalDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoAdditionalDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobExtendedInfoAdditionalDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoBackupInstanceState = (string) content.GetValueForProperty("ExtendedInfoBackupInstanceState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoBackupInstanceState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoDataTransferedInByte = (double?) content.GetValueForProperty("ExtendedInfoDataTransferedInByte",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoDataTransferedInByte, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoTargetRecoverPoint = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreJobRecoveryPointDetails) content.GetValueForProperty("ExtendedInfoTargetRecoverPoint",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoTargetRecoverPoint, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RestoreJobRecoveryPointDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSubTask = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask[]) content.GetValueForProperty("ExtendedInfoSubTask",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).ExtendedInfoSubTask, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IJobSubTask>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.JobSubTaskTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointId = (string) content.GetValueForProperty("SourceRecoverPointRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("SourceRecoverPointRecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).SourceRecoverPointRecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointId = (string) content.GetValueForProperty("TargetRecoverPointRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("TargetRecoverPointRecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJobInternal)this).TargetRecoverPointRecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureBackupJob(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AzureBackupJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureBackupJob(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureBackupJob" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupJob FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// AzureBackup Job Class
    [System.ComponentModel.TypeConverter(typeof(AzureBackupJobTypeConverter))]
    public partial interface IAzureBackupJob

    {

    }
}