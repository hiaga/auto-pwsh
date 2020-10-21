namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Source LifeCycle</summary>
    public partial class SourceLifeCycle :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ISourceLifeCycle,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ISourceLifeCycleInternal
    {

        /// <summary>Backing field for <see cref="DeleteAfter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOption _deleteAfter;

        /// <summary>Delete Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOption DeleteAfter { get => (this._deleteAfter = this._deleteAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DeleteOption()); set => this._deleteAfter = value; }

        /// <summary>Duration of deletion after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DeleteAfterDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOptionInternal)DeleteAfter).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOptionInternal)DeleteAfter).Duration = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DeleteAfterObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOptionInternal)DeleteAfter).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOptionInternal)DeleteAfter).ObjectType = value; }

        /// <summary>Internal Acessors for DeleteAfter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOption Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ISourceLifeCycleInternal.DeleteAfter { get => (this._deleteAfter = this._deleteAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DeleteOption()); set { {_deleteAfter = value;} } }

        /// <summary>Internal Acessors for SourceDataStore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ISourceLifeCycleInternal.SourceDataStore { get => (this._sourceDataStore = this._sourceDataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set { {_sourceDataStore = value;} } }

        /// <summary>Backing field for <see cref="SourceDataStore" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase _sourceDataStore;

        /// <summary>DataStoreInfo base</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase SourceDataStore { get => (this._sourceDataStore = this._sourceDataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set => this._sourceDataStore = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string SourceDataStoreObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)SourceDataStore).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)SourceDataStore).ObjectType = value; }

        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes SourceDataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)SourceDataStore).DataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)SourceDataStore).DataStoreType = value; }

        /// <summary>Backing field for <see cref="TargetDataStoreCopySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting[] _targetDataStoreCopySetting;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting[] TargetDataStoreCopySetting { get => this._targetDataStoreCopySetting; set => this._targetDataStoreCopySetting = value; }

        /// <summary>Creates an new <see cref="SourceLifeCycle" /> instance.</summary>
        public SourceLifeCycle()
        {

        }
    }
    /// Source LifeCycle
    public partial interface ISourceLifeCycle :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Duration of deletion after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duration of deletion after given timespan",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string DeleteAfterDuration { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DeleteAfterObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string SourceDataStoreObjectType { get; set; }
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"type of datastore; SnapShot/Hot/Archive",
        SerializedName = @"dataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes SourceDataStoreType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"targetDataStoreCopySettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting[] TargetDataStoreCopySetting { get; set; }

    }
    /// Source LifeCycle
    internal partial interface ISourceLifeCycleInternal

    {
        /// <summary>Delete Option</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDeleteOption DeleteAfter { get; set; }
        /// <summary>Duration of deletion after given timespan</summary>
        string DeleteAfterDuration { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DeleteAfterObjectType { get; set; }
        /// <summary>DataStoreInfo base</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase SourceDataStore { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string SourceDataStoreObjectType { get; set; }
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes SourceDataStoreType { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting[] TargetDataStoreCopySetting { get; set; }

    }
}