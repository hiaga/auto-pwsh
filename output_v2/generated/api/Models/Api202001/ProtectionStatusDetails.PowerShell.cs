namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Protection status details</summary>
    [System.ComponentModel.TypeConverter(typeof(ProtectionStatusDetailsTypeConverter))]
    public partial class ProtectionStatusDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProtectionStatusDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProtectionStatusDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProtectionStatusDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProtectionStatusDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.InnerErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailRecommendedAction = (string[]) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailsDetails = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[]) content.GetValueForProperty("ErrorDetailsDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailsDetails, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.ProtectionStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProtectionStatusDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.InnerErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailRecommendedAction = (string[]) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailsDetails = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[]) content.GetValueForProperty("ErrorDetailsDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal)this).ErrorDetailsDetails, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingErrorTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Protection status details
    [System.ComponentModel.TypeConverter(typeof(ProtectionStatusDetailsTypeConverter))]
    public partial interface IProtectionStatusDetails

    {

    }
}