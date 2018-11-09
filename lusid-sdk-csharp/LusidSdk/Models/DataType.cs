// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DataType
    {
        /// <summary>
        /// Initializes a new instance of the DataType class.
        /// </summary>
        public DataType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataType class.
        /// </summary>
        /// <param name="typeValueRange">Possible values include: 'Open',
        /// 'Closed'</param>
        /// <param name="valueType">Possible values include: 'String', 'Int',
        /// 'Decimal', 'DateTime', 'Boolean', 'Map', 'List', 'PropertyArray',
        /// 'Percentage', 'BenchmarkType', 'Code', 'Id', 'Uri', 'ArrayOfIds',
        /// 'ArrayOfTransactionAliases', 'ArrayofTransactionMovements',
        /// 'ArrayofUnits', 'StringArray', 'CurrencyAndAmount', 'TradePrice',
        /// 'UnitCreation', 'Currency', 'UserId', 'MetricValue',
        /// 'ArrayOfQuotes'</param>
        /// <param name="unitSchema">Possible values include: 'NoUnits',
        /// 'Basic', 'Iso4217Currency'</param>
        public DataType(string href = default(string), string typeValueRange = default(string), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), string valueType = default(string), IList<object> acceptableValues = default(IList<object>), string unitSchema = default(string), IList<IUnitDefinitionDto> acceptableUnits = default(IList<IUnitDefinitionDto>), IList<Link> links = default(IList<Link>))
        {
            Href = href;
            TypeValueRange = typeValueRange;
            Id = id;
            DisplayName = displayName;
            Description = description;
            ValueType = valueType;
            AcceptableValues = acceptableValues;
            UnitSchema = unitSchema;
            AcceptableUnits = acceptableUnits;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Open', 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "typeValueRange")]
        public string TypeValueRange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public ResourceId Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'String', 'Int', 'Decimal',
        /// 'DateTime', 'Boolean', 'Map', 'List', 'PropertyArray',
        /// 'Percentage', 'BenchmarkType', 'Code', 'Id', 'Uri', 'ArrayOfIds',
        /// 'ArrayOfTransactionAliases', 'ArrayofTransactionMovements',
        /// 'ArrayofUnits', 'StringArray', 'CurrencyAndAmount', 'TradePrice',
        /// 'UnitCreation', 'Currency', 'UserId', 'MetricValue',
        /// 'ArrayOfQuotes'
        /// </summary>
        [JsonProperty(PropertyName = "valueType")]
        public string ValueType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acceptableValues")]
        public IList<object> AcceptableValues { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoUnits', 'Basic',
        /// 'Iso4217Currency'
        /// </summary>
        [JsonProperty(PropertyName = "unitSchema")]
        public string UnitSchema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acceptableUnits")]
        public IList<IUnitDefinitionDto> AcceptableUnits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

    }
}
