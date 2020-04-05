// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ImoutoRebirth.Room.WebApi.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DestinationFolder.
    /// </summary>
    public static partial class DestinationFolderExtensions
    {
            /// <summary>
            /// Get the destination folder for collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id.
            /// </param>
            public static DestinationFolderResponse Get(this IDestinationFolder operations, System.Guid collectionId)
            {
                return operations.GetAsync(collectionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the destination folder for collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DestinationFolderResponse> GetAsync(this IDestinationFolder operations, System.Guid collectionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(collectionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// CreateOrUpdate or update a destination folder for collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id.
            /// </param>
            /// <param name='body'>
            /// Destination folder parameters.
            /// </param>
            public static DestinationFolderResponse CreateOrUpdate(this IDestinationFolder operations, System.Guid collectionId, DestinationFolderCreateRequest body = default(DestinationFolderCreateRequest))
            {
                return operations.CreateOrUpdateAsync(collectionId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// CreateOrUpdate or update a destination folder for collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id.
            /// </param>
            /// <param name='body'>
            /// Destination folder parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DestinationFolderResponse> CreateOrUpdateAsync(this IDestinationFolder operations, System.Guid collectionId, DestinationFolderCreateRequest body = default(DestinationFolderCreateRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(collectionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the destination folder.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id. Aren't needed and added only for routes consistency.
            /// </param>
            /// <param name='destinationFolderId'>
            /// Id of the folder that will be deleted.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void Delete(this IDestinationFolder operations, System.Guid collectionId, System.Guid destinationFolderId, string id)
            {
                operations.DeleteAsync(collectionId, destinationFolderId, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the destination folder.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionId'>
            /// The collection id. Aren't needed and added only for routes consistency.
            /// </param>
            /// <param name='destinationFolderId'>
            /// Id of the folder that will be deleted.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDestinationFolder operations, System.Guid collectionId, System.Guid destinationFolderId, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(collectionId, destinationFolderId, id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
