namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>Protection status details</summary>
    public partial class ProtectionStatusDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal
    {

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError _errorDetail;

        /// <summary>Specifies the protection status error of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingError()); set => this._errorDetail = value; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Code = value; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).InnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).InnerError = value; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).IsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).IsRetryable = value; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).IsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).IsUserError = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Message = value; }

        /// <summary>RecommendedAction � Localised.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string[] ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).RecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).RecommendedAction = value; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Target = value; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetailsDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingErrorInternal)ErrorDetail).Detail = value; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IProtectionStatusDetailsInternal.ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.UserFacingError()); set { {_errorDetail = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status? _status;

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ProtectionStatusDetails" /> instance.</summary>
        public ProtectionStatusDetails()
        {

        }
    }
    /// Protection status details
    public partial interface IProtectionStatusDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.IJsonSerializable
    {
        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique code for this error",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get; set; }
        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Inner Error",
        SerializedName = @"innerError",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError ErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the operation will be retryable or not",
        SerializedName = @"isRetryable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the operation is due to a user error or service error",
        SerializedName = @"isUserError",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsUserError { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get; set; }
        /// <summary>RecommendedAction � Localised.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RecommendedAction � Localised.",
        SerializedName = @"recommendedAction",
        PossibleTypes = new [] { typeof(string) })]
        string[] ErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailTarget { get; set; }
        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional related Errors",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetailsDetails { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the protection status of the resource",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status? Status { get; set; }

    }
    /// Protection status details
    internal partial interface IProtectionStatusDetailsInternal

    {
        /// <summary>Specifies the protection status error of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError ErrorDetail { get; set; }
        /// <summary>Unique code for this error</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Inner Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IInnerError ErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        bool? ErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        bool? ErrorDetailIsUserError { get; set; }

        string ErrorDetailMessage { get; set; }
        /// <summary>RecommendedAction � Localised.</summary>
        string[] ErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        string ErrorDetailTarget { get; set; }
        /// <summary>Additional related Errors</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IUserFacingError[] ErrorDetailsDetails { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.Status? Status { get; set; }

    }
}