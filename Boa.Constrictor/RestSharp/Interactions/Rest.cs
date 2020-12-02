﻿using RestSharp;

namespace Boa.Constrictor.RestSharp
{
    /// <summary>
    /// Provides more fluent calls for RestSharp Questions.
    /// For example, `Actor.Calls(Rest.Request(request))` reads much better than `Actor.AsksFor(RestApiResponse.From(request))`.
    /// </summary>
    public static class Rest
    {
        /// <summary>
        /// More fluent builder for RestFileDownload.
        /// Recommended usage: `Actor.Calls(Rest.Download(request, "..."))`
        /// </summary>
        /// <param name="request">The REST request to call.</param>
        /// <param name="fileExtension">The extension for the file to download.</param>
        /// <returns></returns>
        public static RestApiDownload Download(IRestRequest request, string fileExtension = null) =>
            RestApiDownload.From(request, fileExtension);

        /// <summary>
        /// More fluent builder for RestApiResponse.
        /// Recommended usage: `Actor.Calls(Rest.Request(request))`.
        /// </summary>
        /// <param name="request">The REST request to call.</param>
        /// <returns></returns>
        public static RestApiResponse Request(IRestRequest request) =>
            RestApiResponse.From(request);

        /// <summary>
        /// More fluent builder for RestApiResponse<typeparamref name="TData"/>.
        /// Recommended usage: `Actor.Calls(Rest.Request<typeparamref name="TData"/>(request))`.
        /// </summary>
        /// <typeparam name="TData">The deserialization object type.</typeparam>
        /// <param name="request">The REST request to call.</param>
        /// <returns></returns>
        public static RestApiResponse<TData> Request<TData>(IRestRequest request) =>
            RestApiResponse<TData>.From(request);
    }
}
