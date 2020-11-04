// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The interface IItemRequestBuilder.
    /// </summary>
    public partial interface IItemRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IItemRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IItemRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IItemPermissionsCollectionRequestBuilder"/>.</returns>
        IItemPermissionsCollectionRequestBuilder Permissions { get; }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IItemVersionsCollectionRequestBuilder"/>.</returns>
        IItemVersionsCollectionRequestBuilder Versions { get; }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IItemChildrenCollectionRequestBuilder"/>.</returns>
        IItemChildrenCollectionRequestBuilder Children { get; }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IItemThumbnailsCollectionRequestBuilder"/>.</returns>
        IItemThumbnailsCollectionRequestBuilder Thumbnails { get; }

        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IItemContentRequestBuilder"/>.</returns>
        IItemContentRequestBuilder Content { get; }

        /// <summary>
        /// Gets the request builder for ItemCreateSession.
        /// </summary>
        /// <returns>The <see cref="IItemCreateSessionRequestBuilder"/>.</returns>
        IItemCreateSessionRequestBuilder CreateSession(
            ChunkedUploadSessionDescriptor item = null);

        /// <summary>
        /// Gets the request builder for ItemCopy.
        /// </summary>
        /// <returns>The <see cref="IItemCopyRequestBuilder"/>.</returns>
        IItemCopyRequestBuilder Copy(
            string name = null,
            ItemReference parentReference = null);

        /// <summary>
        /// Gets the request builder for ItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IItemCreateLinkRequestBuilder"/>.</returns>
        IItemCreateLinkRequestBuilder CreateLink(
            string type);

        /// <summary>
        /// Gets the request builder for ItemDelta.
        /// </summary>
        /// <returns>The <see cref="IItemDeltaRequestBuilder"/>.</returns>
        IItemDeltaRequestBuilder Delta(
            string token = null);

        /// <summary>
        /// Gets the request builder for ItemSearch.
        /// </summary>
        /// <returns>The <see cref="IItemSearchRequestBuilder"/>.</returns>
        IItemSearchRequestBuilder Search(
            string q = null);

        /// <summary>
        /// Gets the request builder for ItemInvite.
        /// </summary>
        /// <returns>The <see cref="IItemInviteRequestBuilder"/>.</returns>
        IItemInviteRequestBuilder Invite(string[] roles,
            Recipient[] recipients,
            bool requiresSignIn = false,
            bool sendInvitation = false,
            string message = null);

    }
}