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

    public partial class ResourceListOfReferencePortfolioConstituentDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceListOfReferencePortfolioConstituentDto class.
        /// </summary>
        public ResourceListOfReferencePortfolioConstituentDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceListOfReferencePortfolioConstituentDto class.
        /// </summary>
        /// <param name="href">The Uri that returns the same result as the
        /// original request,
        /// but may include resolved as at time(s).</param>
        /// <param name="count">The total number of records returned in the
        /// set</param>
        public ResourceListOfReferencePortfolioConstituentDto(IList<ReferencePortfolioConstituentDto> values = default(IList<ReferencePortfolioConstituentDto>), string href = default(string), int? count = default(int?), IList<Link> links = default(IList<Link>))
        {
            Values = values;
            Href = href;
            Count = count;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<ReferencePortfolioConstituentDto> Values { get; set; }

        /// <summary>
        /// Gets or sets the Uri that returns the same result as the original
        /// request,
        /// but may include resolved as at time(s).
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the total number of records returned in the set
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

    }
}
