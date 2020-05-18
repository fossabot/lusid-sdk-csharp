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
    /// TransactionConfigurationMovementData
    /// </summary>
    [DataContract]
    public partial class TransactionConfigurationMovementData :  IEquatable<TransactionConfigurationMovementData>
    {
        /// <summary>
        /// The Movement Types
        /// </summary>
        /// <value>The Movement Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MovementTypesEnum
        {
            /// <summary>
            /// Enum Settlement for value: Settlement
            /// </summary>
            [EnumMember(Value = "Settlement")]
            Settlement = 1,

            /// <summary>
            /// Enum Traded for value: Traded
            /// </summary>
            [EnumMember(Value = "Traded")]
            Traded = 2,

            /// <summary>
            /// Enum FutureCash for value: FutureCash
            /// </summary>
            [EnumMember(Value = "FutureCash")]
            FutureCash = 3,

            /// <summary>
            /// Enum Commitment for value: Commitment
            /// </summary>
            [EnumMember(Value = "Commitment")]
            Commitment = 4,

            /// <summary>
            /// Enum Receivable for value: Receivable
            /// </summary>
            [EnumMember(Value = "Receivable")]
            Receivable = 5,

            /// <summary>
            /// Enum CashSettlement for value: CashSettlement
            /// </summary>
            [EnumMember(Value = "CashSettlement")]
            CashSettlement = 6,

            /// <summary>
            /// Enum Accrual for value: Accrual
            /// </summary>
            [EnumMember(Value = "Accrual")]
            Accrual = 7,

            /// <summary>
            /// Enum ForwardFx for value: ForwardFx
            /// </summary>
            [EnumMember(Value = "ForwardFx")]
            ForwardFx = 8,

            /// <summary>
            /// Enum UnsettledCashTypes for value: UnsettledCashTypes
            /// </summary>
            [EnumMember(Value = "UnsettledCashTypes")]
            UnsettledCashTypes = 9,

            /// <summary>
            /// Enum StockMovement for value: StockMovement
            /// </summary>
            [EnumMember(Value = "StockMovement")]
            StockMovement = 10,

            /// <summary>
            /// Enum CashCommitment for value: CashCommitment
            /// </summary>
            [EnumMember(Value = "CashCommitment")]
            CashCommitment = 11,

            /// <summary>
            /// Enum CashReceivable for value: CashReceivable
            /// </summary>
            [EnumMember(Value = "CashReceivable")]
            CashReceivable = 12,

            /// <summary>
            /// Enum CashForward for value: CashForward
            /// </summary>
            [EnumMember(Value = "CashForward")]
            CashForward = 13,

            /// <summary>
            /// Enum CashFxForward for value: CashFxForward
            /// </summary>
            [EnumMember(Value = "CashFxForward")]
            CashFxForward = 14,

            /// <summary>
            /// Enum CashAccrual for value: CashAccrual
            /// </summary>
            [EnumMember(Value = "CashAccrual")]
            CashAccrual = 15

        }

        /// <summary>
        /// The Movement Types
        /// </summary>
        /// <value>The Movement Types</value>
        [DataMember(Name="movementTypes", EmitDefaultValue=false)]
        public MovementTypesEnum MovementTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationMovementData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionConfigurationMovementData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationMovementData" /> class.
        /// </summary>
        /// <param name="movementTypes">The Movement Types (required).</param>
        /// <param name="side">The Movement Side (required).</param>
        /// <param name="direction">The Movement direction (required).</param>
        /// <param name="properties">properties.</param>
        /// <param name="mappings">mappings.</param>
        public TransactionConfigurationMovementData(MovementTypesEnum movementTypes = default(MovementTypesEnum), string side = default(string), int? direction = default(int?), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), List<TransactionPropertyMapping> mappings = default(List<TransactionPropertyMapping>))
        {
            // to ensure "movementTypes" is required (not null)
            if (movementTypes == null)
            {
                throw new InvalidDataException("movementTypes is a required property for TransactionConfigurationMovementData and cannot be null");
            }
            else
            {
                this.MovementTypes = movementTypes;
            }
            
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new InvalidDataException("side is a required property for TransactionConfigurationMovementData and cannot be null");
            }
            else
            {
                this.Side = side;
            }
            
            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for TransactionConfigurationMovementData and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }
            
            this.Properties = properties;
            this.Mappings = mappings;
        }
        

        /// <summary>
        /// The Movement Side
        /// </summary>
        /// <value>The Movement Side</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public string Side { get; set; }

        /// <summary>
        /// The Movement direction
        /// </summary>
        /// <value>The Movement direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Mappings
        /// </summary>
        [DataMember(Name="mappings", EmitDefaultValue=false)]
        public List<TransactionPropertyMapping> Mappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigurationMovementData {\n");
            sb.Append("  MovementTypes: ").Append(MovementTypes).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Mappings: ").Append(Mappings).Append("\n");
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
            return this.Equals(input as TransactionConfigurationMovementData);
        }

        /// <summary>
        /// Returns true if TransactionConfigurationMovementData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConfigurationMovementData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConfigurationMovementData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MovementTypes == input.MovementTypes ||
                    (this.MovementTypes != null &&
                    this.MovementTypes.Equals(input.MovementTypes))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
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
                if (this.MovementTypes != null)
                    hashCode = hashCode * 59 + this.MovementTypes.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                return hashCode;
            }
        }
    }

}
