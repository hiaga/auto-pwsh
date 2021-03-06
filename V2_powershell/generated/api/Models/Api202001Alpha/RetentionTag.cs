namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Retention tag</summary>
    public partial class RetentionTag :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRetentionTag,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRetentionTagInternal
    {

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>Retention Tag version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Retention Tag version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRetentionTagInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IRetentionTagInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Backing field for <see cref="TagName" /> property.</summary>
        private string _tagName;

        /// <summary>Retention Tag Name to relate it to retention rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public string TagName { get => this._tagName; set => this._tagName = value; }

        /// <summary>Creates an new <see cref="RetentionTag" /> instance.</summary>
        public RetentionTag()
        {

        }
    }
    /// Retention tag
    public partial interface IRetentionTag :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Retention Tag version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Retention Tag version.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get;  }
        /// <summary>Retention Tag version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Retention Tag version.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Retention Tag Name to relate it to retention rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Retention Tag Name to relate it to retention rule.",
        SerializedName = @"tagName",
        PossibleTypes = new [] { typeof(string) })]
        string TagName { get; set; }

    }
    /// Retention tag
    internal partial interface IRetentionTagInternal

    {
        /// <summary>Retention Tag version.</summary>
        string ETag { get; set; }
        /// <summary>Retention Tag version.</summary>
        string Id { get; set; }
        /// <summary>Retention Tag Name to relate it to retention rule.</summary>
        string TagName { get; set; }

    }
}