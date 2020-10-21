// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support
{

    public partial struct Status :
        System.IEquatable<Status>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status ConfiguringProtection = @"ConfiguringProtection";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status ConfiguringProtectionFailed = @"ConfiguringProtectionFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status ProtectionConfigured = @"ProtectionConfigured";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status ProtectionStopped = @"ProtectionStopped";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status SoftDeleted = @"SoftDeleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status SoftDeleting = @"SoftDeleting";

        /// <summary>the value for an instance of the <see cref="Status" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Status</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Status" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Status(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Status</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Status (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Status && Equals((Status)obj);
        }

        /// <summary>Returns hashCode for enum Status</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="Status" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Status(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for Status</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Status</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Status" />.</param>

        public static implicit operator Status(string value)
        {
            return new Status(value);
        }

        /// <summary>Implicit operator to convert Status to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Status" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Status</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Status</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status e2)
        {
            return e2.Equals(e1);
        }
    }
}