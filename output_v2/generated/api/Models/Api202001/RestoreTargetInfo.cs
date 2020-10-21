namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Class encapsulating restore target parameters</summary>
    public partial class RestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBase __restoreTargetInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RestoreTargetInfoBase();

        /// <summary>Backing field for <see cref="DatasourceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource _datasourceInfo;

        /// <summary>Information of target DS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource DatasourceInfo { get => (this._datasourceInfo = this._datasourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.Datasource()); set => this._datasourceInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).Type = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ObjectType = value; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceId = value; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceLocation = value; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceName = value; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceType = value; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceInternal)DatasourceInfo).ResourceUri = value; }

        /// <summary>Backing field for <see cref="DatasourceSetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet _datasourceSetInfo;

        /// <summary>Information of target DS Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet DatasourceSetInfo { get => (this._datasourceSetInfo = this._datasourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceSet()); set => this._datasourceSetInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).DatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).DatasourceType = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ObjectType = value; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceId = value; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceLocation = value; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceName = value; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceType = value; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSetInternal)DatasourceSetInfo).ResourceUri = value; }

        /// <summary>Internal Acessors for RecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal.RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption = value; }

        /// <summary>Internal Acessors for DatasourceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoInternal.DatasourceInfo { get => (this._datasourceInfo = this._datasourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.Datasource()); set { {_datasourceInfo = value;} } }

        /// <summary>Internal Acessors for DatasourceSetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoInternal.DatasourceSetInfo { get => (this._datasourceSetInfo = this._datasourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceSet()); set { {_datasourceSetInfo = value;} } }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType = value; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string RestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation = value; }

        /// <summary>Creates an new <see cref="RestoreTargetInfo" /> instance.</summary>
        public RestoreTargetInfo()
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
            await eventListener.AssertNotNull(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
        }
    }
    /// Class encapsulating restore target parameters
    public partial interface IRestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBase
    {
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceName { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceUri { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceName { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceUri { get; set; }

    }
    /// Class encapsulating restore target parameters
    internal partial interface IRestoreTargetInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRestoreTargetInfoBaseInternal
    {
        /// <summary>Information of target DS</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource DatasourceInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DatasourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DatasourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DatasourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DatasourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DatasourceInfoResourceName { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DatasourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DatasourceInfoResourceUri { get; set; }
        /// <summary>Information of target DS Set</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet DatasourceSetInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DatasourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DatasourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DatasourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DatasourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DatasourceSetInfoResourceName { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DatasourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DatasourceSetInfoResourceUri { get; set; }

    }
}