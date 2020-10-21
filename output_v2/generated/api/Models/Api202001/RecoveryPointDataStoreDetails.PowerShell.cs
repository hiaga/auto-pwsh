namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>RecoveryPoint datastore details</summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryPointDataStoreDetailsTypeConverter))]
    public partial class RecoveryPointDataStoreDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RecoveryPointDataStoreDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryPointDataStoreDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RecoveryPointDataStoreDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryPointDataStoreDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryPointDataStoreDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RecoveryPointDataStoreDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryPointDataStoreDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).ExpiryTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).ExpiryTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).MetaData = (string) content.GetValueForProperty("MetaData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).MetaData, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationExpiryTime = (global::System.DateTime?) content.GetValueForProperty("RehydrationExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationExpiryTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationStatus?) content.GetValueForProperty("RehydrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).State, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.RecoveryPointDataStoreDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryPointDataStoreDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).ExpiryTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).ExpiryTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).MetaData = (string) content.GetValueForProperty("MetaData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).MetaData, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationExpiryTime = (global::System.DateTime?) content.GetValueForProperty("RehydrationExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationExpiryTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationStatus?) content.GetValueForProperty("RehydrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).RehydrationStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).State, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IRecoveryPointDataStoreDetailsInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// RecoveryPoint datastore details
    [System.ComponentModel.TypeConverter(typeof(RecoveryPointDataStoreDetailsTypeConverter))]
    public partial interface IRecoveryPointDataStoreDetails

    {

    }
}