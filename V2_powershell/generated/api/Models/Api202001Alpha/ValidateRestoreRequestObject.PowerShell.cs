namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Validate restore request object</summary>
    [System.ComponentModel.TypeConverter(typeof(ValidateRestoreRequestObjectTypeConverter))]
    public partial class ValidateRestoreRequestObject
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ValidateRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ValidateRestoreRequestObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ValidateRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ValidateRestoreRequestObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ValidateRestoreRequestObject" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObject FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ValidateRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ValidateRestoreRequestObject(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObject = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest) content.GetValueForProperty("RestoreRequestObject",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObject, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AzureBackupRestoreRequestTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase) content.GetValueForProperty("RestoreRequestObjectRestoreTargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.RestoreTargetInfoBaseTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectType = (string) content.GetValueForProperty("RestoreRequestObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType) content.GetValueForProperty("RestoreRequestObjectSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption = (string) content.GetValueForProperty("RestoreTargetInfoRecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType = (string) content.GetValueForProperty("RestoreTargetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation = (string) content.GetValueForProperty("RestoreTargetInfoRestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ValidateRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ValidateRestoreRequestObject(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObject = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRestoreRequest) content.GetValueForProperty("RestoreRequestObject",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObject, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.AzureBackupRestoreRequestTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRestoreTargetInfoBase) content.GetValueForProperty("RestoreRequestObjectRestoreTargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.RestoreTargetInfoBaseTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectType = (string) content.GetValueForProperty("RestoreRequestObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType) content.GetValueForProperty("RestoreRequestObjectSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.SourceDataStoreType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption = (string) content.GetValueForProperty("RestoreTargetInfoRecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType = (string) content.GetValueForProperty("RestoreTargetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation = (string) content.GetValueForProperty("RestoreTargetInfoRestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IValidateRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Validate restore request object
    [System.ComponentModel.TypeConverter(typeof(ValidateRestoreRequestObjectTypeConverter))]
    public partial interface IValidateRestoreRequestObject

    {

    }
}