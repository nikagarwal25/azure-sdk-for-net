// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC
{
    using Microsoft.Azure;
    using Microsoft.Azure.Graph;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ObjectsOperations.
    /// </summary>
    public static partial class ObjectsOperationsExtensions
    {
            /// <summary>
            /// Gets the details for the currently logged-in user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AADObject GetCurrentUser(this IObjectsOperations operations)
            {
                return operations.GetCurrentUserAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details for the currently logged-in user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AADObject> GetCurrentUserAsync(this IObjectsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCurrentUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets AD group membership for the specified AD object IDs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Objects filtering parameters.
            /// </param>
            public static IPage<AADObject> GetObjectsByObjectIds(this IObjectsOperations operations, GetObjectsParameters parameters)
            {
                return operations.GetObjectsByObjectIdsAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets AD group membership for the specified AD object IDs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Objects filtering parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObject>> GetObjectsByObjectIdsAsync(this IObjectsOperations operations, GetObjectsParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetObjectsByObjectIdsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets AD group membership for the specified AD object IDs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            public static IPage<AADObject> GetObjectsByObjectIdsNext(this IObjectsOperations operations, string nextLink)
            {
                return operations.GetObjectsByObjectIdsNextAsync(nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets AD group membership for the specified AD object IDs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObject>> GetObjectsByObjectIdsNextAsync(this IObjectsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetObjectsByObjectIdsNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
