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
    using System.Linq;

    public partial class CreateClientInstrumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateClientInstrumentRequest
        /// class.
        /// </summary>
        public CreateClientInstrumentRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateClientInstrumentRequest
        /// class.
        /// </summary>
        /// <param name="instrument">Expanded instrument definition - in the
        /// case of OTC instruments
        /// this contains the definition of the non-exchange traded instrument.
        /// The format for this can be client-defined, but in order to
        /// transparently use
        /// vendor libraries it must conform to a format that LUSID
        /// understands.</param>
        public CreateClientInstrumentRequest(string clientInstrumentId, string name, ResourceId lookThroughPortfolioId = default(ResourceId), InstrumentDefinition instrument = default(InstrumentDefinition))
        {
            ClientInstrumentId = clientInstrumentId;
            Name = name;
            LookThroughPortfolioId = lookThroughPortfolioId;
            Instrument = instrument;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientInstrumentId")]
        public string ClientInstrumentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lookThroughPortfolioId")]
        public ResourceId LookThroughPortfolioId { get; set; }

        /// <summary>
        /// Gets or sets expanded instrument definition - in the case of OTC
        /// instruments
        /// this contains the definition of the non-exchange traded instrument.
        /// The format for this can be client-defined, but in order to
        /// transparently use
        /// vendor libraries it must conform to a format that LUSID
        /// understands.
        /// </summary>
        [JsonProperty(PropertyName = "instrument")]
        public InstrumentDefinition Instrument { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientInstrumentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientInstrumentId");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
