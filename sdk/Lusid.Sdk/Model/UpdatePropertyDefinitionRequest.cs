/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1380
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// UpdatePropertyDefinitionRequest
    /// </summary>
    [DataContract]
    public partial class UpdatePropertyDefinitionRequest :  IEquatable<UpdatePropertyDefinitionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePropertyDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePropertyDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePropertyDefinitionRequest" /> class.
        /// </summary>
        /// <param name="displayName">The display name of the property. (required).</param>
        public UpdatePropertyDefinitionRequest(string displayName = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for UpdatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
        }
        
        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePropertyDefinitionRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePropertyDefinitionRequest);
        }

        /// <summary>
        /// Returns true if UpdatePropertyDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePropertyDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePropertyDefinitionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                int hashCode = 41;
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }

}
