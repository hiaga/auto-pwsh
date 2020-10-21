namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Backup instance</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceTypeConverter))]
    public partial class BackupInstance
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupInstance(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceSetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.PolicyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupInstance(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.DatasourceSetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.PolicyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupInstance(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupInstance(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupInstance" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IBackupInstance FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Backup instance
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceTypeConverter))]
    public partial interface IBackupInstance

    {

    }
}