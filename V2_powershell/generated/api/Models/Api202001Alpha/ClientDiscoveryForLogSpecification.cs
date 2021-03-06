namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Class to represent shoebox log specification in json client discovery.</summary>
    public partial class ClientDiscoveryForLogSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecificationInternal
    {

        /// <summary>Backing field for <see cref="BlobDuration" /> property.</summary>
        private string _blobDuration;

        /// <summary>blob duration of shoebox log specification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string BlobDuration { get => this._blobDuration; set => this._blobDuration = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Localized display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name for shoebox log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ClientDiscoveryForLogSpecification" /> instance.</summary>
        public ClientDiscoveryForLogSpecification()
        {

        }
    }
    /// Class to represent shoebox log specification in json client discovery.
    public partial interface IClientDiscoveryForLogSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>blob duration of shoebox log specification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"blob duration of shoebox log specification",
        SerializedName = @"blobDuration",
        PossibleTypes = new [] { typeof(string) })]
        string BlobDuration { get; set; }
        /// <summary>Localized display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Localized display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Name for shoebox log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name for shoebox log specification.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Class to represent shoebox log specification in json client discovery.
    internal partial interface IClientDiscoveryForLogSpecificationInternal

    {
        /// <summary>blob duration of shoebox log specification</summary>
        string BlobDuration { get; set; }
        /// <summary>Localized display name</summary>
        string DisplayName { get; set; }
        /// <summary>Name for shoebox log specification.</summary>
        string Name { get; set; }

    }
}