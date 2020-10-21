namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Azure backup rule</summary>
    public partial class AzureBackupRule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRule,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRule"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRule __basePolicyRule = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BasePolicyRule();

        /// <summary>Backing field for <see cref="BackupParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParameters _backupParameter;

        /// <summary>BackupParameters base</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParameters BackupParameter { get => (this._backupParameter = this._backupParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupParameters()); set => this._backupParameter = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string BackupParameterObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParametersInternal)BackupParameter).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParametersInternal)BackupParameter).ObjectType = value; }

        /// <summary>Backing field for <see cref="DataStore" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase _dataStore;

        /// <summary>DataStoreInfo base</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase DataStore { get => (this._dataStore = this._dataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set => this._dataStore = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataStoreObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).ObjectType = value; }

        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).DataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).DataStoreType = value; }

        /// <summary>Internal Acessors for BackupParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParameters Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRuleInternal.BackupParameter { get => (this._backupParameter = this._backupParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupParameters()); set { {_backupParameter = value;} } }

        /// <summary>Internal Acessors for DataStore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRuleInternal.DataStore { get => (this._dataStore = this._dataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set { {_dataStore = value;} } }

        /// <summary>Internal Acessors for Trigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContext Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAzureBackupRuleInternal.Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerContext()); set { {_trigger = value;} } }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRuleInternal)__basePolicyRule).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRuleInternal)__basePolicyRule).Name = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRuleInternal)__basePolicyRule).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRuleInternal)__basePolicyRule).ObjectType = value; }

        /// <summary>Backing field for <see cref="Trigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContext _trigger;

        /// <summary>Trigger context</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContext Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerContext()); set => this._trigger = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string TriggerObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContextInternal)Trigger).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContextInternal)Trigger).ObjectType = value; }

        /// <summary>Creates an new <see cref="AzureBackupRule" /> instance.</summary>
        public AzureBackupRule()
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
            await eventListener.AssertNotNull(nameof(__basePolicyRule), __basePolicyRule);
            await eventListener.AssertObjectIsValid(nameof(__basePolicyRule), __basePolicyRule);
        }
    }
    /// Azure backup rule
    public partial interface IAzureBackupRule :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRule
    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string BackupParameterObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DataStoreObjectType { get; set; }
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"type of datastore; SnapShot/Hot/Archive",
        SerializedName = @"dataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerObjectType { get; set; }

    }
    /// Azure backup rule
    internal partial interface IAzureBackupRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBasePolicyRuleInternal
    {
        /// <summary>BackupParameters base</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupParameters BackupParameter { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string BackupParameterObjectType { get; set; }
        /// <summary>DataStoreInfo base</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase DataStore { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DataStoreObjectType { get; set; }
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get; set; }
        /// <summary>Trigger context</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerContext Trigger { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string TriggerObjectType { get; set; }

    }
}