﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace HttpServerLite
{
    /// <summary>
    /// Route type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RouteTypeEnum
    {
        /// <summary>
        /// Default route.
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,
        /// <summary>
        /// Content route.
        /// </summary>
        [EnumMember(Value = "Content")]
        Content,
        /// <summary>
        /// Static route.
        /// </summary>
        [EnumMember(Value = "Static")]
        Static,
        /// <summary>
        /// Parameter route.
        /// </summary>
        [EnumMember(Value = "Parameter")]
        Parameter,
        /// <summary>
        /// Dynamic route.
        /// </summary>
        [EnumMember(Value = "Dynamic")]
        Dynamic
    }
}
