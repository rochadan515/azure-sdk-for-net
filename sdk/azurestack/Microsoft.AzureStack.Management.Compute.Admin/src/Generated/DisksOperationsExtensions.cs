// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DisksOperations.
    /// </summary>
    public static partial class DisksOperationsExtensions
    {
            /// <summary>
            /// Returns a list of disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='userSubscriptionId'>
            /// User Subscription Id which the resource belongs to.
            /// </param>
            /// <param name='status'>
            /// The parameters of disk state.
            /// </param>
            /// <param name='sharePath'>
            /// The source share which the resource belongs to.
            /// </param>
            /// <param name='count'>
            /// The maximum number of disks to return.
            /// </param>
            /// <param name='start'>
            /// The start index of disks in query.
            /// </param>
            public static IEnumerable<Disk> List(this IDisksOperations operations, string location, string userSubscriptionId = default(string), string status = default(string), string sharePath = default(string), int? count = default(int?), int? start = default(int?))
            {
                return operations.ListAsync(location, userSubscriptionId, status, sharePath, count, start).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='userSubscriptionId'>
            /// User Subscription Id which the resource belongs to.
            /// </param>
            /// <param name='status'>
            /// The parameters of disk state.
            /// </param>
            /// <param name='sharePath'>
            /// The source share which the resource belongs to.
            /// </param>
            /// <param name='count'>
            /// The maximum number of disks to return.
            /// </param>
            /// <param name='start'>
            /// The start index of disks in query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Disk>> ListAsync(this IDisksOperations operations, string location, string userSubscriptionId = default(string), string status = default(string), string sharePath = default(string), int? count = default(int?), int? start = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, userSubscriptionId, status, sharePath, count, start, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='diskId'>
            /// The disk guid as identity.
            /// </param>
            public static Disk Get(this IDisksOperations operations, string location, string diskId)
            {
                return operations.GetAsync(location, diskId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='diskId'>
            /// The disk guid as identity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Disk> GetAsync(this IDisksOperations operations, string location, string diskId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, diskId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
