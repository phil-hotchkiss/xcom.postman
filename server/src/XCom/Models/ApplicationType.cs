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
        /// Gets or Sets ApplicationType
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<ApplicationType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ApplicationType
        {
            
            /// <summary>
            /// Enum NotSetEnum for NotSet
            /// </summary>
            [EnumMember(Value = "NotSet")]
            NotSetEnum = 1,
            
            /// <summary>
            /// Enum VuhlEnum for Vuhl
            /// </summary>
            [EnumMember(Value = "Vuhl")]
            VuhlEnum = 2,
            
            /// <summary>
            /// Enum BankEnum for Bank
            /// </summary>
            [EnumMember(Value = "Bank")]
            BankEnum = 3,
            
            /// <summary>
            /// Enum PaddioEnum for Paddio
            /// </summary>
            [EnumMember(Value = "Paddio")]
            PaddioEnum = 4,
            
            /// <summary>
            /// Enum SsOpsEnum for SsOps
            /// </summary>
            [EnumMember(Value = "SsOps")]
            SsOpsEnum = 5,
            
            /// <summary>
            /// Enum MRCEnum for MRC
            /// </summary>
            [EnumMember(Value = "MRC")]
            MRCEnum = 6,
            
            /// <summary>
            /// Enum SelectStarEnum for SelectStar
            /// </summary>
            [EnumMember(Value = "SelectStar")]
            SelectStarEnum = 7
        }
}
