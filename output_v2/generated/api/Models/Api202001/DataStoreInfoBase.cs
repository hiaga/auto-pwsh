namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>DataStoreInfo base</summary>
    public partial class DataStoreInfoBase :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBase,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDataStoreInfoBaseInternal
    {

        /// <summary>Backing field for <see cref="DataStoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes _dataStoreType;

        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get => this._dataStoreType; set => this._dataStoreType = value; }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Creates an new <see cref="DataStoreInfoBase" /> instance.</summary>
        public DataStoreInfoBase()
        {

        }
    }
    /// DataStoreInfo base
    public partial interface IDataStoreInfoBase :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"type of datastore; SnapShot/Hot/Archive",
        SerializedName = @"dataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }

    }
    /// DataStoreInfo base
    internal partial interface IDataStoreInfoBaseInternal

    {
        /// <summary>type of datastore; SnapShot/Hot/Archive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DataStoreTypes DataStoreType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string ObjectType { get; set; }

    }
}