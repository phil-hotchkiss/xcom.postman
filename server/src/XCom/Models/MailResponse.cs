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
    /// 
    /// </summary>
    [DataContract]
    public partial class MailResponse : IEquatable<MailResponse>
    {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        /// <example>&quot;Email has been sent&quot;</example>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets XcomRequestId
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name="xcomRequestId", EmitDefaultValue=true)]
        public int XcomRequestId { get; set; }

        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        /// <example>false</example>
        [DataMember(Name="successful", EmitDefaultValue=true)]
        public bool Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  XcomRequestId: ").Append(XcomRequestId).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((MailResponse)obj);
        }

        /// <summary>
        /// Returns true if MailResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    XcomRequestId == other.XcomRequestId ||
                    
                    XcomRequestId.Equals(other.XcomRequestId)
                ) && 
                (
                    Successful == other.Successful ||
                    
                    Successful.Equals(other.Successful)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    
                    hashCode = hashCode * 59 + XcomRequestId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Successful.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MailResponse left, MailResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MailResponse left, MailResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
