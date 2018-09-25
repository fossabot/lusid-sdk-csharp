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

    public partial class CompletePortfolioDto
    {
        /// <summary>
        /// Initializes a new instance of the CompletePortfolioDto class.
        /// </summary>
        public CompletePortfolioDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompletePortfolioDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'Transaction',
        /// 'Reference', 'DerivedTransaction'</param>
        public CompletePortfolioDto(ResourceId id = default(ResourceId), string href = default(string), string description = default(string), string displayName = default(string), System.DateTimeOffset? created = default(System.DateTimeOffset?), ResourceId parentPortfolioId = default(ResourceId), bool? isDerived = default(bool?), string type = default(string), VersionDto version = default(VersionDto), IList<PropertyDto> properties = default(IList<PropertyDto>), string baseCurrency = default(string), IList<Link> links = default(IList<Link>))
        {
            Id = id;
            Href = href;
            Description = description;
            DisplayName = displayName;
            Created = created;
            ParentPortfolioId = parentPortfolioId;
            IsDerived = isDerived;
            Type = type;
            Version = version;
            Properties = properties;
            BaseCurrency = baseCurrency;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public ResourceId Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTimeOffset? Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentPortfolioId")]
        public ResourceId ParentPortfolioId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDerived")]
        public bool? IsDerived { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Transaction', 'Reference',
        /// 'DerivedTransaction'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public VersionDto Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<PropertyDto> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseCurrency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

    }
}
