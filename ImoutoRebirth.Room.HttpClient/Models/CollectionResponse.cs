// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ImoutoRebirth.Room.HttpClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CollectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the CollectionResponse class.
        /// </summary>
        public CollectionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CollectionResponse class.
        /// </summary>
        public CollectionResponse(System.Guid? id = default(System.Guid?), string name = default(string))
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
