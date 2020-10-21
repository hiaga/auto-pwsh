namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Available operation details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClientDiscoveryValueForSingleApiTypeConverter))]
    public partial class ClientDiscoveryValueForSingleApi
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryValueForSingleApi"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClientDiscoveryValueForSingleApi(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryDisplayTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Origin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayOperation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayProvider, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayResource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForServiceSpecification) content.GetValueForProperty("ServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForServiceSpecificationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecificationLogSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForLogSpecification[]) content.GetValueForProperty("ServiceSpecificationLogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecificationLogSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForLogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForLogSpecificationTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryValueForSingleApi"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClientDiscoveryValueForSingleApi(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryDisplayTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).Origin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayOperation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayProvider, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).DisplayResource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForServiceSpecification) content.GetValueForProperty("ServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForServiceSpecificationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecificationLogSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForLogSpecification[]) content.GetValueForProperty("ServiceSpecificationLogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApiInternal)this).ServiceSpecificationLogSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryForLogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryForLogSpecificationTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryValueForSingleApi"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApi"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApi DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClientDiscoveryValueForSingleApi(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ClientDiscoveryValueForSingleApi"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApi"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApi DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClientDiscoveryValueForSingleApi(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClientDiscoveryValueForSingleApi" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IClientDiscoveryValueForSingleApi FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Available operation details.
    [System.ComponentModel.TypeConverter(typeof(ClientDiscoveryValueForSingleApiTypeConverter))]
    public partial interface IClientDiscoveryValueForSingleApi

    {

    }
}