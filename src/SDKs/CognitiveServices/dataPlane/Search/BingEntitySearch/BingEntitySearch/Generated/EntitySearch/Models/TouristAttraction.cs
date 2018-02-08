// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.EntitySearch.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TouristAttraction : Place
    {
        /// <summary>
        /// Initializes a new instance of the TouristAttraction class.
        /// </summary>
        public TouristAttraction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TouristAttraction class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="contractualRules">A list of rules that you must adhere
        /// to if you display the item.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="entityPresentationInfo">Additional information about
        /// the entity such as hints that you can use to determine the entity's
        /// type. To determine the entity's type, use the entityScenario and
        /// entityTypeHint fields.</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="address">The postal address of where the entity is
        /// located</param>
        /// <param name="telephone">The entity's telephone number</param>
        public TouristAttraction(string id = default(string), IList<ContractualRulesContractualRule> contractualRules = default(IList<ContractualRulesContractualRule>), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), EntitiesEntityPresentationInfo entityPresentationInfo = default(EntitiesEntityPresentationInfo), string bingId = default(string), PostalAddress address = default(PostalAddress), string telephone = default(string))
            : base(id, contractualRules, webSearchUrl, name, url, image, description, entityPresentationInfo, bingId, address, telephone)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
