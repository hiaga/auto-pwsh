namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Class encapsulating restore as files target parameters</summary>
    public partial class RestoreFilesTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreFilesTargetInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreFilesTargetInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase __restoreTargetInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.RestoreTargetInfoBase();

        /// <summary>Internal Acessors for TargetDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreFilesTargetInfoInternal.TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.TargetDetails()); set { {_targetDetail = value;} } }

        /// <summary>Internal Acessors for RecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal.RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType = value; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inherited)]
        public string RestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation = value; }

        /// <summary>Backing field for <see cref="TargetDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetails _targetDetail;

        /// <summary>Destination of RestoreAsFiles operation, when destination is not a datasource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetails TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.TargetDetails()); set => this._targetDetail = value; }

        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string TargetDetailFilePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).FilePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).FilePrefix = value; }

        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RestoreTargetLocationType TargetDetailRestoreTargetLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).RestoreTargetLocationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).RestoreTargetLocationType = value; }

        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string TargetDetailUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetailsInternal)TargetDetail).Url = value; }

        /// <summary>Creates an new <see cref="RestoreFilesTargetInfo" /> instance.</summary>
        public RestoreFilesTargetInfo()
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
    /// Class encapsulating restore as files target parameters
    public partial interface IRestoreFilesTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase
    {
        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Restore operation may create multiple files inside location pointed by Url
        Below will be the common prefix for all of them",
        SerializedName = @"filePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailFilePrefix { get; set; }
        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Denotes the target location where the data will be restored,
        string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}",
        SerializedName = @"restoreTargetLocationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RestoreTargetLocationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RestoreTargetLocationType TargetDetailRestoreTargetLocationType { get; set; }
        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Url denoting the restore destination. It can point to container / file share etc",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailUrl { get; set; }

    }
    /// Class encapsulating restore as files target parameters
    internal partial interface IRestoreFilesTargetInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBaseInternal
    {
        /// <summary>Destination of RestoreAsFiles operation, when destination is not a datasource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ITargetDetails TargetDetail { get; set; }
        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        string TargetDetailFilePrefix { get; set; }
        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RestoreTargetLocationType TargetDetailRestoreTargetLocationType { get; set; }
        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        string TargetDetailUrl { get; set; }

    }
}