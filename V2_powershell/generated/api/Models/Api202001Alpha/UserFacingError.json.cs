namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Extensions;

    /// <summary>
    /// Error object used by layers that have access to localized content, and propogate that to user
    /// </summary>
    public partial class UserFacingError
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IUserFacingError.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IUserFacingError.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IUserFacingError FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject json ? new UserFacingError(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UserFacingError" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UserFacingError" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._code)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString(this._code.ToString()) : null, "code" ,container.Add );
            AddIf( null != this._innerError ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode) this._innerError.ToJson(null,serializationMode) : null, "innerError" ,container.Add );
            AddIf( null != this._isRetryable ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonBoolean((bool)this._isRetryable) : null, "isRetryable" ,container.Add );
            AddIf( null != this._isUserError ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonBoolean((bool)this._isUserError) : null, "isUserError" ,container.Add );
            AddIf( null != (((object)this._message)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString(this._message.ToString()) : null, "message" ,container.Add );
            if (null != this._recommendedAction)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.XNodeArray();
                foreach( var __x in this._recommendedAction )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("recommendedAction",__w);
            }
            AddIf( null != (((object)this._target)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString(this._target.ToString()) : null, "target" ,container.Add );
            if (null != this._detail)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.XNodeArray();
                foreach( var __s in this._detail )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("details",__r);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject into a new instance of <see cref="UserFacingError" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UserFacingError(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_code = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString>("code"), out var __jsonCode) ? (string)__jsonCode : (string)Code;}
            {_innerError = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonObject>("innerError"), out var __jsonInnerError) ? Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.InnerError.FromJson(__jsonInnerError) : InnerError;}
            {_isRetryable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonBoolean>("isRetryable"), out var __jsonIsRetryable) ? (bool?)__jsonIsRetryable : IsRetryable;}
            {_isUserError = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonBoolean>("isUserError"), out var __jsonIsUserError) ? (bool?)__jsonIsUserError : IsUserError;}
            {_message = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString>("message"), out var __jsonMessage) ? (string)__jsonMessage : (string)Message;}
            {_recommendedAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonArray>("recommendedAction"), out var __jsonRecommendedAction) ? If( __jsonRecommendedAction as Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : RecommendedAction;}
            {_target = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonString>("target"), out var __jsonTarget) ? (string)__jsonTarget : (string)Target;}
            {_detail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonArray>("details"), out var __jsonDetails) ? If( __jsonDetails as Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IUserFacingError[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IUserFacingError) (Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.UserFacingError.FromJson(__p) )) ))() : null : Detail;}
            AfterFromJson(json);
        }
    }
}