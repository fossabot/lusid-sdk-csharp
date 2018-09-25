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
    using System.Linq;

    /// <summary>
    /// Describes the version metadata of an entity.
    /// </summary>
    public partial class VersionDto
    {
        /// <summary>
        /// Initializes a new instance of the VersionDto class.
        /// </summary>
        public VersionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionDto class.
        /// </summary>
        public VersionDto(System.DateTimeOffset? effectiveFrom = default(System.DateTimeOffset?), System.DateTimeOffset? asAtDate = default(System.DateTimeOffset?), string href = default(string))
        {
            EffectiveFrom = effectiveFrom;
            AsAtDate = asAtDate;
            Href = href;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveFrom")]
        public System.DateTimeOffset? EffectiveFrom { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asAtDate")]
        public System.DateTimeOffset? AsAtDate { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; private set; }

    }
}
