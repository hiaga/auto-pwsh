namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Trigger backup request</summary>
    [System.ComponentModel.TypeConverter(typeof(TriggerBackupRequestTypeConverter))]
    public partial class TriggerBackupRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerBackupRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TriggerBackupRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerBackupRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TriggerBackupRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TriggerBackupRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerBackupRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TriggerBackupRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOption = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdHocBackupRuleOptions) content.GetValueForProperty("BackupRuleOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOption, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AdHocBackupRuleOptionsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionTriggerOption = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdhocBackupTriggerOption) content.GetValueForProperty("BackupRuleOptionTriggerOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionTriggerOption, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AdhocBackupTriggerOptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionRuleName = (string) content.GetValueForProperty("BackupRuleOptionRuleName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).TriggerOptionRetentionTagOverride = (string) content.GetValueForProperty("TriggerOptionRetentionTagOverride",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).TriggerOptionRetentionTagOverride, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.TriggerBackupRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TriggerBackupRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOption = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdHocBackupRuleOptions) content.GetValueForProperty("BackupRuleOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOption, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AdHocBackupRuleOptionsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionTriggerOption = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IAdhocBackupTriggerOption) content.GetValueForProperty("BackupRuleOptionTriggerOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionTriggerOption, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.AdhocBackupTriggerOptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionRuleName = (string) content.GetValueForProperty("BackupRuleOptionRuleName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).BackupRuleOptionRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).TriggerOptionRetentionTagOverride = (string) content.GetValueForProperty("TriggerOptionRetentionTagOverride",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ITriggerBackupRequestInternal)this).TriggerOptionRetentionTagOverride, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Trigger backup request
    [System.ComponentModel.TypeConverter(typeof(TriggerBackupRequestTypeConverter))]
    public partial interface ITriggerBackupRequest

    {

    }
}