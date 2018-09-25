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

    /// <summary>
    /// A reconciliation break
    /// </summary>
    public partial class ReconciliationBreakDto
    {
        /// <summary>
        /// Initializes a new instance of the ReconciliationBreakDto class.
        /// </summary>
        public ReconciliationBreakDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReconciliationBreakDto class.
        /// </summary>
        /// <param name="instrumentUid">Unique instrument identifier</param>
        /// <param name="unitsDifference">Difference in units</param>
        /// <param name="costDifference">Difference in cost</param>
        public ReconciliationBreakDto(string instrumentUid = default(string), IList<PropertyDto> properties = default(IList<PropertyDto>), double? unitsDifference = default(double?), double? costDifference = default(double?))
        {
            InstrumentUid = instrumentUid;
            Properties = properties;
            UnitsDifference = unitsDifference;
            CostDifference = costDifference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique instrument identifier
        /// </summary>
        [JsonProperty(PropertyName = "instrumentUid")]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<PropertyDto> Properties { get; set; }

        /// <summary>
        /// Gets or sets difference in units
        /// </summary>
        [JsonProperty(PropertyName = "unitsDifference")]
        public double? UnitsDifference { get; set; }

        /// <summary>
        /// Gets or sets difference in cost
        /// </summary>
        [JsonProperty(PropertyName = "costDifference")]
        public double? CostDifference { get; set; }

    }
}
