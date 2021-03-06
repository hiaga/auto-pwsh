namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.PowerShell;

    /// <summary>Schedule based backup criteria</summary>
    [System.ComponentModel.TypeConverter(typeof(ScheduleBasedBackupCriteriaTypeConverter))]
    public partial class ScheduleBasedBackupCriteria
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ScheduleBasedBackupCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteria"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteria DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ScheduleBasedBackupCriteria(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ScheduleBasedBackupCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteria"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteria DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ScheduleBasedBackupCriteria(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ScheduleBasedBackupCriteria" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteria FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ScheduleBasedBackupCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ScheduleBasedBackupCriteria(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).AbsoluteCriterion = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker[]) content.GetValueForProperty("AbsoluteCriterion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).AbsoluteCriterion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfMonth = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDay[]) content.GetValueForProperty("DaysOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfMonth, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.DayTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfTheWeek = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek[]) content.GetValueForProperty("DaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfTheWeek, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).MonthsOfYear = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month[]) content.GetValueForProperty("MonthsOfYear",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).MonthsOfYear, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).ScheduleTime = (global::System.DateTime[]) content.GetValueForProperty("ScheduleTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).ScheduleTime, __y => TypeConverterExtensions.SelectToArray<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).WeeksOfTheMonth = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber[]) content.GetValueForProperty("WeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).WeeksOfTheMonth, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupCriteriaInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupCriteriaInternal)this).ObjectType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.ScheduleBasedBackupCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ScheduleBasedBackupCriteria(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).AbsoluteCriterion = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker[]) content.GetValueForProperty("AbsoluteCriterion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).AbsoluteCriterion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.AbsoluteMarker.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfMonth = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDay[]) content.GetValueForProperty("DaysOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfMonth, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.DayTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfTheWeek = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek[]) content.GetValueForProperty("DaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).DaysOfTheWeek, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.DayOfWeek.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).MonthsOfYear = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month[]) content.GetValueForProperty("MonthsOfYear",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).MonthsOfYear, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Month.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).ScheduleTime = (global::System.DateTime[]) content.GetValueForProperty("ScheduleTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).ScheduleTime, __y => TypeConverterExtensions.SelectToArray<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).WeeksOfTheMonth = (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber[]) content.GetValueForProperty("WeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IScheduleBasedBackupCriteriaInternal)this).WeeksOfTheMonth, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.WeekNumber.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupCriteriaInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IBackupCriteriaInternal)this).ObjectType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Schedule based backup criteria
    [System.ComponentModel.TypeConverter(typeof(ScheduleBasedBackupCriteriaTypeConverter))]
    public partial interface IScheduleBasedBackupCriteria

    {

    }
}