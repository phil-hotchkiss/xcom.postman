/*
 * XCom.API
 *
 * This API is responsible for enabling communication with SendGrid. It implements additional features such as data retention and A/B Testing for specific templates
 *
 * The version of the OpenAPI document: 4.0
 * Contact: phil.hotchkiss@veteransunited.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using XCom.Converters;

namespace XCom.Models
{ 
        /// <summary>
        /// Gets or Sets WebhookType
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<WebhookType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WebhookType
        {
            
            /// <summary>
            /// Enum BlockedEnum for blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            BlockedEnum = 1,
            
            /// <summary>
            /// Enum BounceEnum for bounce
            /// </summary>
            [EnumMember(Value = "bounce")]
            BounceEnum = 2
        }
}
