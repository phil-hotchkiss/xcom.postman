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
    public partial class SendgridWebhook : IEquatable<SendgridWebhook>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public WebhookType Type { get; set; }

        /// <summary>
        /// Gets or Sets SgMessageId
        /// </summary>
        [DataMember(Name="sg_message_id", EmitDefaultValue=false)]
        public string SgMessageId { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets SgEventId
        /// </summary>
        [DataMember(Name="sg_event_id", EmitDefaultValue=false)]
        public string SgEventId { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=true)]
        public WebhookEvent Event { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets SmtpId
        /// </summary>
        [DataMember(Name="smtp-id", EmitDefaultValue=false)]
        public string SmtpId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Xcomid
        /// </summary>
        [DataMember(Name="xcomid", EmitDefaultValue=true)]
        public long Xcomid { get; set; }

        /// <summary>
        /// Gets or Sets Sendrequestguid
        /// </summary>
        [DataMember(Name="sendrequestguid", EmitDefaultValue=false)]
        public Guid Sendrequestguid { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public string Environment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendgridWebhook {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SgMessageId: ").Append(SgMessageId).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  SgEventId: ").Append(SgEventId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SmtpId: ").Append(SmtpId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Xcomid: ").Append(Xcomid).Append("\n");
            sb.Append("  Sendrequestguid: ").Append(Sendrequestguid).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SendgridWebhook)obj);
        }

        /// <summary>
        /// Returns true if SendgridWebhook instances are equal
        /// </summary>
        /// <param name="other">Instance of SendgridWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendgridWebhook other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    SgMessageId == other.SgMessageId ||
                    SgMessageId != null &&
                    SgMessageId.Equals(other.SgMessageId)
                ) && 
                (
                    Ip == other.Ip ||
                    Ip != null &&
                    Ip.Equals(other.Ip)
                ) && 
                (
                    SgEventId == other.SgEventId ||
                    SgEventId != null &&
                    SgEventId.Equals(other.SgEventId)
                ) && 
                (
                    Event == other.Event ||
                    
                    Event.Equals(other.Event)
                ) && 
                (
                    Response == other.Response ||
                    Response != null &&
                    Response.Equals(other.Response)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    SmtpId == other.SmtpId ||
                    SmtpId != null &&
                    SmtpId.Equals(other.SmtpId)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Xcomid == other.Xcomid ||
                    
                    Xcomid.Equals(other.Xcomid)
                ) && 
                (
                    Sendrequestguid == other.Sendrequestguid ||
                    Sendrequestguid != null &&
                    Sendrequestguid.Equals(other.Sendrequestguid)
                ) && 
                (
                    Environment == other.Environment ||
                    Environment != null &&
                    Environment.Equals(other.Environment)
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
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (SgMessageId != null)
                    hashCode = hashCode * 59 + SgMessageId.GetHashCode();
                    if (Ip != null)
                    hashCode = hashCode * 59 + Ip.GetHashCode();
                    if (SgEventId != null)
                    hashCode = hashCode * 59 + SgEventId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Event.GetHashCode();
                    if (Response != null)
                    hashCode = hashCode * 59 + Response.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (SmtpId != null)
                    hashCode = hashCode * 59 + SmtpId.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    
                    hashCode = hashCode * 59 + Xcomid.GetHashCode();
                    if (Sendrequestguid != null)
                    hashCode = hashCode * 59 + Sendrequestguid.GetHashCode();
                    if (Environment != null)
                    hashCode = hashCode * 59 + Environment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SendgridWebhook left, SendgridWebhook right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SendgridWebhook left, SendgridWebhook right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
