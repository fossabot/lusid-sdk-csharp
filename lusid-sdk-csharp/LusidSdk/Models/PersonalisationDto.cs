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

    public partial class PersonalisationDto
    {
        /// <summary>
        /// Initializes a new instance of the PersonalisationDto class.
        /// </summary>
        public PersonalisationDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PersonalisationDto class.
        /// </summary>
        /// <param name="scope">Possible values include: 'User', 'Group',
        /// 'Default', 'All'</param>
        public PersonalisationDto(string scope = default(string), string scopeValue = default(string), string settingKey = default(string), string settingValue = default(string), string dataType = default(string), string href = default(string))
        {
            Scope = scope;
            ScopeValue = scopeValue;
            SettingKey = settingKey;
            SettingValue = settingValue;
            DataType = dataType;
            Href = href;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'User', 'Group', 'Default',
        /// 'All'
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scopeValue")]
        public string ScopeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settingKey")]
        public string SettingKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settingValue")]
        public string SettingValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

    }
}
