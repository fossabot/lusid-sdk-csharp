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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specification object for the parameters of an aggregation
    /// </summary>
    public partial class AggregationRequest
    {
        /// <summary>
        /// Initializes a new instance of the AggregationRequest class.
        /// </summary>
        public AggregationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AggregationRequest class.
        /// </summary>
        /// <param name="asAt">The asAt date to use</param>
        public AggregationRequest(ResourceId recipeId, IList<AggregateSpec> metrics, bool? loadReferencePortfolio = default(bool?), System.DateTimeOffset? asAt = default(System.DateTimeOffset?), System.DateTimeOffset? effectiveAt = default(System.DateTimeOffset?), IList<string> groupBy = default(IList<string>), IList<PropertyFilter> filters = default(IList<PropertyFilter>), int? limit = default(int?), string sort = default(string))
        {
            RecipeId = recipeId;
            LoadReferencePortfolio = loadReferencePortfolio;
            AsAt = asAt;
            EffectiveAt = effectiveAt;
            Metrics = metrics;
            GroupBy = groupBy;
            Filters = filters;
            Limit = limit;
            Sort = sort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recipeId")]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "loadReferencePortfolio")]
        public bool? LoadReferencePortfolio { get; set; }

        /// <summary>
        /// Gets or sets the asAt date to use
        /// </summary>
        [JsonProperty(PropertyName = "asAt")]
        public System.DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveAt")]
        public System.DateTimeOffset? EffectiveAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metrics")]
        public IList<AggregateSpec> Metrics { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupBy")]
        public IList<string> GroupBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<PropertyFilter> Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sort")]
        public string Sort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecipeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecipeId");
            }
            if (Metrics == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metrics");
            }
            if (Metrics != null)
            {
                foreach (var element in Metrics)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
