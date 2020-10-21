namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Target copy settings</summary>
    public partial class TargetCopySetting :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySetting,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySettingInternal
    {

        /// <summary>Backing field for <see cref="CopyAfter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption _copyAfter;

        /// <summary>It can be CustomCopyOption or ImmediateCopyOption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption CopyAfter { get => (this._copyAfter = this._copyAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.CopyOption()); set => this._copyAfter = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string CopyAfterObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOptionInternal)CopyAfter).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOptionInternal)CopyAfter).ObjectType = value; }

        /// <summary>Backing field for <see cref="DataStore" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase _dataStore;

        /// <summary>Info of target datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase DataStore { get => (this._dataStore = this._dataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set => this._dataStore = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DataStoreObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).ObjectType = value; }

        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).DataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal)DataStore).DataStoreType = value; }

        /// <summary>Internal Acessors for CopyAfter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySettingInternal.CopyAfter { get => (this._copyAfter = this._copyAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.CopyOption()); set { {_copyAfter = value;} } }

        /// <summary>Internal Acessors for DataStore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITargetCopySettingInternal.DataStore { get => (this._dataStore = this._dataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DataStoreInfoBase()); set { {_dataStore = value;} } }

        /// <summary>Creates an new <see cref="TargetCopySetting" /> instance.</summary>
        public TargetCopySetting()
        {

        }
    }
    /// Target copy settings
    public partial interface ITargetCopySetting :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string CopyAfterObjectType { get; set; }
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

    }
    /// Target copy settings
    internal partial interface ITargetCopySettingInternal

    {
        /// <summary>It can be CustomCopyOption or ImmediateCopyOption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ICopyOption CopyAfter { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string CopyAfterObjectType { get; set; }
        /// <summary>Info of target datastore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase DataStore { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DataStoreObjectType { get; set; }
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get; set; }

    }
}