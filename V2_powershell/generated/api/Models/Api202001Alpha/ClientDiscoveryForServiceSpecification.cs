namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Class to represent shoebox service specification in json client discovery.</summary>
    public partial class ClientDiscoveryForServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="LogSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification[] _logSpecification;

        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification[] LogSpecification { get => this._logSpecification; set => this._logSpecification = value; }

        /// <summary>Creates an new <see cref="ClientDiscoveryForServiceSpecification" /> instance.</summary>
        public ClientDiscoveryForServiceSpecification()
        {

        }
    }
    /// Class to represent shoebox service specification in json client discovery.
    public partial interface IClientDiscoveryForServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of log specifications of this operation.",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification[] LogSpecification { get; set; }

    }
    /// Class to represent shoebox service specification in json client discovery.
    internal partial interface IClientDiscoveryForServiceSpecificationInternal

    {
        /// <summary>List of log specifications of this operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IClientDiscoveryForLogSpecification[] LogSpecification { get; set; }

    }
}