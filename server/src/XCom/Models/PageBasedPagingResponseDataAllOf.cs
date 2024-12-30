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
    public partial class PageBasedPagingResponseDataAllOf : IEquatable<PageBasedPagingResponseDataAllOf>
    {
        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name="pageIndex", EmitDefaultValue=true)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=true)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets TotalItems
        /// </summary>
        [DataMember(Name="totalItems", EmitDefaultValue=true)]
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or Sets CurrentItemCount
        /// </summary>
        [DataMember(Name="currentItemCount", EmitDefaultValue=true)]
        public int CurrentItemCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageBasedPagingResponseDataAllOf {\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  CurrentItemCount: ").Append(CurrentItemCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PageBasedPagingResponseDataAllOf)obj);
        }

        /// <summary>
        /// Returns true if PageBasedPagingResponseDataAllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of PageBasedPagingResponseDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageBasedPagingResponseDataAllOf other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PageIndex == other.PageIndex ||
                    
                    PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    TotalPages == other.TotalPages ||
                    
                    TotalPages.Equals(other.TotalPages)
                ) && 
                (
                    TotalItems == other.TotalItems ||
                    
                    TotalItems.Equals(other.TotalItems)
                ) && 
                (
                    CurrentItemCount == other.CurrentItemCount ||
                    
                    CurrentItemCount.Equals(other.CurrentItemCount)
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
                    
                    hashCode = hashCode * 59 + PageIndex.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalPages.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalItems.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrentItemCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PageBasedPagingResponseDataAllOf left, PageBasedPagingResponseDataAllOf right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PageBasedPagingResponseDataAllOf left, PageBasedPagingResponseDataAllOf right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
