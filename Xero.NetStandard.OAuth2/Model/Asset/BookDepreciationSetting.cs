/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.2.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// BookDepreciationSetting
    /// </summary>
    [DataContract]
    public partial class BookDepreciationSetting :  IEquatable<BookDepreciationSetting>, IValidatableObject
    {
        /// <summary>
        /// The method of depreciation applied to this asset. See Depreciation Methods
        /// </summary>
        /// <value>The method of depreciation applied to this asset. See Depreciation Methods</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DepreciationMethodEnum
        {
            /// <summary>
            /// Enum NoDepreciation for value: NoDepreciation
            /// </summary>
            [EnumMember(Value = "NoDepreciation")]
            NoDepreciation = 1,

            /// <summary>
            /// Enum StraightLine for value: StraightLine
            /// </summary>
            [EnumMember(Value = "StraightLine")]
            StraightLine = 2,

            /// <summary>
            /// Enum DiminishingValue100 for value: DiminishingValue100
            /// </summary>
            [EnumMember(Value = "DiminishingValue100")]
            DiminishingValue100 = 3,

            /// <summary>
            /// Enum DiminishingValue150 for value: DiminishingValue150
            /// </summary>
            [EnumMember(Value = "DiminishingValue150")]
            DiminishingValue150 = 4,

            /// <summary>
            /// Enum DiminishingValue200 for value: DiminishingValue200
            /// </summary>
            [EnumMember(Value = "DiminishingValue200")]
            DiminishingValue200 = 5,

            /// <summary>
            /// Enum FullDepreciation for value: FullDepreciation
            /// </summary>
            [EnumMember(Value = "FullDepreciation")]
            FullDepreciation = 6

        }

        /// <summary>
        /// The method of depreciation applied to this asset. See Depreciation Methods
        /// </summary>
        /// <value>The method of depreciation applied to this asset. See Depreciation Methods</value>
        [DataMember(Name="depreciationMethod", EmitDefaultValue=false)]
        public DepreciationMethodEnum DepreciationMethod { get; set; }
        /// <summary>
        /// The method of averaging applied to this asset. See Averaging Methods
        /// </summary>
        /// <value>The method of averaging applied to this asset. See Averaging Methods</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AveragingMethodEnum
        {
            /// <summary>
            /// Enum FullMonth for value: FullMonth
            /// </summary>
            [EnumMember(Value = "FullMonth")]
            FullMonth = 1,

            /// <summary>
            /// Enum ActualDays for value: ActualDays
            /// </summary>
            [EnumMember(Value = "ActualDays")]
            ActualDays = 2

        }

        /// <summary>
        /// The method of averaging applied to this asset. See Averaging Methods
        /// </summary>
        /// <value>The method of averaging applied to this asset. See Averaging Methods</value>
        [DataMember(Name="averagingMethod", EmitDefaultValue=false)]
        public AveragingMethodEnum AveragingMethod { get; set; }
        /// <summary>
        /// See Depreciation Calculation Methods
        /// </summary>
        /// <value>See Depreciation Calculation Methods</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DepreciationCalculationMethodEnum
        {
            /// <summary>
            /// Enum Rate for value: Rate
            /// </summary>
            [EnumMember(Value = "Rate")]
            Rate = 1,

            /// <summary>
            /// Enum Life for value: Life
            /// </summary>
            [EnumMember(Value = "Life")]
            Life = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// See Depreciation Calculation Methods
        /// </summary>
        /// <value>See Depreciation Calculation Methods</value>
        [DataMember(Name="depreciationCalculationMethod", EmitDefaultValue=false)]
        public DepreciationCalculationMethodEnum DepreciationCalculationMethod { get; set; }
        
        /// <summary>
        /// The rate of depreciation (e.g. 0.05)
        /// </summary>
        /// <value>The rate of depreciation (e.g. 0.05)</value>
        [DataMember(Name="depreciationRate", EmitDefaultValue=false)]
        public decimal? DepreciationRate { get; set; }

        /// <summary>
        /// Effective life of the asset in years (e.g. 5)
        /// </summary>
        /// <value>Effective life of the asset in years (e.g. 5)</value>
        [DataMember(Name="effectiveLifeYears", EmitDefaultValue=false)]
        public int? EffectiveLifeYears { get; set; }

        /// <summary>
        /// Unique Xero identifier for the depreciable object
        /// </summary>
        /// <value>Unique Xero identifier for the depreciable object</value>
        [DataMember(Name="depreciableObjectId", EmitDefaultValue=false)]
        public Guid? DepreciableObjectId { get; set; }

        /// <summary>
        /// The type of asset object
        /// </summary>
        /// <value>The type of asset object</value>
        [DataMember(Name="depreciableObjectType", EmitDefaultValue=false)]
        public string DepreciableObjectType { get; set; }

        /// <summary>
        /// Unique Xero identifier for the effective date change
        /// </summary>
        /// <value>Unique Xero identifier for the effective date change</value>
        [DataMember(Name="bookEffectiveDateOfChangeId", EmitDefaultValue=false)]
        public Guid? BookEffectiveDateOfChangeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookDepreciationSetting {\n");
            sb.Append("  DepreciationMethod: ").Append(DepreciationMethod).Append("\n");
            sb.Append("  AveragingMethod: ").Append(AveragingMethod).Append("\n");
            sb.Append("  DepreciationRate: ").Append(DepreciationRate).Append("\n");
            sb.Append("  EffectiveLifeYears: ").Append(EffectiveLifeYears).Append("\n");
            sb.Append("  DepreciationCalculationMethod: ").Append(DepreciationCalculationMethod).Append("\n");
            sb.Append("  DepreciableObjectId: ").Append(DepreciableObjectId).Append("\n");
            sb.Append("  DepreciableObjectType: ").Append(DepreciableObjectType).Append("\n");
            sb.Append("  BookEffectiveDateOfChangeId: ").Append(BookEffectiveDateOfChangeId).Append("\n");
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
            return this.Equals(input as BookDepreciationSetting);
        }

        /// <summary>
        /// Returns true if BookDepreciationSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of BookDepreciationSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookDepreciationSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepreciationMethod == input.DepreciationMethod ||
                    this.DepreciationMethod.Equals(input.DepreciationMethod)
                ) && 
                (
                    this.AveragingMethod == input.AveragingMethod ||
                    this.AveragingMethod.Equals(input.AveragingMethod)
                ) && 
                (
                    this.DepreciationRate == input.DepreciationRate ||
                    this.DepreciationRate.Equals(input.DepreciationRate)
                ) && 
                (
                    this.EffectiveLifeYears == input.EffectiveLifeYears ||
                    this.EffectiveLifeYears.Equals(input.EffectiveLifeYears)
                ) && 
                (
                    this.DepreciationCalculationMethod == input.DepreciationCalculationMethod ||
                    this.DepreciationCalculationMethod.Equals(input.DepreciationCalculationMethod)
                ) && 
                (
                    this.DepreciableObjectId == input.DepreciableObjectId ||
                    (this.DepreciableObjectId != null &&
                    this.DepreciableObjectId.Equals(input.DepreciableObjectId))
                ) && 
                (
                    this.DepreciableObjectType == input.DepreciableObjectType ||
                    (this.DepreciableObjectType != null &&
                    this.DepreciableObjectType.Equals(input.DepreciableObjectType))
                ) && 
                (
                    this.BookEffectiveDateOfChangeId == input.BookEffectiveDateOfChangeId ||
                    (this.BookEffectiveDateOfChangeId != null &&
                    this.BookEffectiveDateOfChangeId.Equals(input.BookEffectiveDateOfChangeId))
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
                hashCode = hashCode * 59 + this.DepreciationMethod.GetHashCode();
                hashCode = hashCode * 59 + this.AveragingMethod.GetHashCode();
                hashCode = hashCode * 59 + this.DepreciationRate.GetHashCode();
                hashCode = hashCode * 59 + this.EffectiveLifeYears.GetHashCode();
                hashCode = hashCode * 59 + this.DepreciationCalculationMethod.GetHashCode();
                if (this.DepreciableObjectId != null)
                    hashCode = hashCode * 59 + this.DepreciableObjectId.GetHashCode();
                if (this.DepreciableObjectType != null)
                    hashCode = hashCode * 59 + this.DepreciableObjectType.GetHashCode();
                if (this.BookEffectiveDateOfChangeId != null)
                    hashCode = hashCode * 59 + this.BookEffectiveDateOfChangeId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
