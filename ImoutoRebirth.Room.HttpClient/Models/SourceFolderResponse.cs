// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ImoutoRebirth.Room.HttpClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SourceFolderResponse
    {
        /// <summary>
        /// Initializes a new instance of the SourceFolderResponse class.
        /// </summary>
        public SourceFolderResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceFolderResponse class.
        /// </summary>
        public SourceFolderResponse(System.Guid? id = default(System.Guid?), System.Guid? collectionId = default(System.Guid?), string path = default(string), bool? shouldCheckFormat = default(bool?), bool? shouldCheckHashFromName = default(bool?), bool? shouldCreateTagsFromSubfolders = default(bool?), bool? shouldAddTagFromFilename = default(bool?), IList<string> supportedExtensions = default(IList<string>))
        {
            Id = id;
            CollectionId = collectionId;
            Path = path;
            ShouldCheckFormat = shouldCheckFormat;
            ShouldCheckHashFromName = shouldCheckHashFromName;
            ShouldCreateTagsFromSubfolders = shouldCreateTagsFromSubfolders;
            ShouldAddTagFromFilename = shouldAddTagFromFilename;
            SupportedExtensions = supportedExtensions;
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
        [JsonProperty(PropertyName = "collectionId")]
        public System.Guid? CollectionId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shouldCheckFormat")]
        public bool? ShouldCheckFormat { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shouldCheckHashFromName")]
        public bool? ShouldCheckHashFromName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shouldCreateTagsFromSubfolders")]
        public bool? ShouldCreateTagsFromSubfolders { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shouldAddTagFromFilename")]
        public bool? ShouldAddTagFromFilename { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedExtensions")]
        public IList<string> SupportedExtensions { get; private set; }

    }
}
