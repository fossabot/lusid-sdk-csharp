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
    /// Configuration needed to define a side. Sides are referenced by Label. Beyond that, other properties  can be used to reference either transaction fields, or transaction properties.
    /// </summary>
    [DataContract]
    public partial class SideConfigurationData :  IEquatable<SideConfigurationData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SideConfigurationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SideConfigurationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SideConfigurationData" /> class.
        /// </summary>
        /// <param name="side">The side&#39;s label. (required).</param>
        /// <param name="security">The security, or instrument. (required).</param>
        /// <param name="currency">The currency. (required).</param>
        /// <param name="rate">The rate. (required).</param>
        /// <param name="units">The units. (required).</param>
        /// <param name="amount">The amount. (required).</param>
        /// <param name="links">links.</param>
        public SideConfigurationData(string side = default(string), string security = default(string), string currency = default(string), string rate = default(string), string units = default(string), string amount = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new InvalidDataException("side is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Side = side;
            }
            
            // to ensure "security" is required (not null)
            if (security == null)
            {
                throw new InvalidDataException("security is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Security = security;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new InvalidDataException("rate is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Rate = rate;
            }
            
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new InvalidDataException("units is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Units = units;
            }
            
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SideConfigurationData and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            this.Links = links;
        }
        
        /// <summary>
        /// The side&#39;s label.
        /// </summary>
        /// <value>The side&#39;s label.</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public string Side { get; set; }

        /// <summary>
        /// The security, or instrument.
        /// </summary>
        /// <value>The security, or instrument.</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public string Security { get; set; }

        /// <summary>
        /// The currency.
        /// </summary>
        /// <value>The currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The rate.
        /// </summary>
        /// <value>The rate.</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// The units.
        /// </summary>
        /// <value>The units.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }

        /// <summary>
        /// The amount.
        /// </summary>
        /// <value>The amount.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SideConfigurationData {\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SideConfigurationData);
        }

        /// <summary>
        /// Returns true if SideConfigurationData instances are equal
        /// </summary>
        /// <param name="input">Instance of SideConfigurationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SideConfigurationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
