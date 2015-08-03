// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing.Routes
{
    using sys = System;
    using io = System.IO;
    using col = System.Collections.Generic;
    using t = System.Threading.Tasks;
    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The routes for the <see cref="N:Dropbox.Api.Sharing"/> namespace</para>
    /// </summary>
    public class SharingRoutes
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharingRoutes" /> class.</para>
        /// </summary>
        /// <param name="transport">The transport to use</param>
        internal SharingRoutes(enc.ITransport transport)
        {
            this.Transport = transport;
        }

        /// <summary>
        /// <para>Gets the transport used for these routes</para>
        /// </summary>
        internal enc.ITransport Transport { get; private set; }

        /// <summary>
        /// <para>Returns a list of <see cref="LinkMetadata" /> objects for this user,
        /// including collection links.</para>
        /// <para>If no path is given or the path is empty, returns a list of all shared links
        /// for the current user, including collection links.</para>
        /// <para>If a non-empty path is given, returns a list of all shared links that allow
        /// access to the given path.  Collection links are never returned in this case.</para>
        /// <para>Note that the url field in the response is never the shortened URL.</para>
        /// <para>This API is not supported for App Folder and filetypes apps.</para>
        /// </summary>
        /// <param name="getSharedLinksArg">The request parameters</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public t.Task<GetSharedLinksResult> GetSharedLinksAsync(GetSharedLinksArg getSharedLinksArg)
        {
            return this.Transport.SendRpcRequestAsync<GetSharedLinksArg, GetSharedLinksResult, Files.PathError>(getSharedLinksArg, "api", "/sharing/get_shared_links");
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get shared links route.</para>
        /// </summary>
        /// <param name="getSharedLinksArg">The request parameters.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetSharedLinks(GetSharedLinksArg getSharedLinksArg, sys.AsyncCallback callback, object state = null)
        {
            var task = this.GetSharedLinksAsync(getSharedLinksArg);

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Returns a list of <see cref="LinkMetadata" /> objects for this user,
        /// including collection links.</para>
        /// <para>If no path is given or the path is empty, returns a list of all shared links
        /// for the current user, including collection links.</para>
        /// <para>If a non-empty path is given, returns a list of all shared links that allow
        /// access to the given path.  Collection links are never returned in this case.</para>
        /// <para>Note that the url field in the response is never the shortened URL.</para>
        /// <para>This API is not supported for App Folder and filetypes apps.</para>
        /// </summary>
        /// <param name="path">See <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.GetSharedLinksAsync" />
        /// description.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public t.Task<GetSharedLinksResult> GetSharedLinksAsync(string path = null)
        {
            var getSharedLinksArg = new GetSharedLinksArg(path);

            return this.GetSharedLinksAsync(getSharedLinksArg);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get shared links route.</para>
        /// </summary>
        /// <param name="path">See <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.GetSharedLinksAsync" />
        /// description.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="callbackState">A user provided object that distinguished this send
        /// from other send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetSharedLinks(string path = null,
                                                    sys.AsyncCallback callback = null,
                                                    object callbackState = null)
        {
            var getSharedLinksArg = new GetSharedLinksArg(path);

            return this.BeginGetSharedLinks(getSharedLinksArg, callback, callbackState);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the get shared links route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public GetSharedLinksResult EndGetSharedLinks(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<GetSharedLinksResult>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }

        /// <summary>
        /// <para>Create a shared link.</para>
        /// <para>If a shared link already exists for the given path, that link is
        /// returned.</para>
        /// <para>Note that in the returned <see cref="PathLinkMetadata" />, the url field is
        /// the shortened URL if the short_url argument is set to <c>true</c>.</para>
        /// <para>This API is not supported for App Folder and filetypes apps.</para>
        /// </summary>
        /// <param name="createSharedLinkArg">The request parameters</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public t.Task<PathLinkMetadata> CreateSharedLinkAsync(CreateSharedLinkArg createSharedLinkArg)
        {
            return this.Transport.SendRpcRequestAsync<CreateSharedLinkArg, PathLinkMetadata, Files.PathError>(createSharedLinkArg, "api", "/sharing/create_shared_link");
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the create shared link route.</para>
        /// </summary>
        /// <param name="createSharedLinkArg">The request parameters.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginCreateSharedLink(CreateSharedLinkArg createSharedLinkArg, sys.AsyncCallback callback, object state = null)
        {
            var task = this.CreateSharedLinkAsync(createSharedLinkArg);

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Create a shared link.</para>
        /// <para>If a shared link already exists for the given path, that link is
        /// returned.</para>
        /// <para>Note that in the returned <see cref="PathLinkMetadata" />, the url field is
        /// the shortened URL if the short_url argument is set to <c>true</c>.</para>
        /// <para>This API is not supported for App Folder and filetypes apps.</para>
        /// </summary>
        /// <param name="path">The path to share.</param>
        /// <param name="shortUrl">Whether to return a shortened URL.</param>
        /// <param name="pendingUpload">If it's okay to share a path that does not yet exist,
        /// set this to either 'file' or 'folder' to indicate whether to assume it's a file or
        /// folder.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public t.Task<PathLinkMetadata> CreateSharedLinkAsync(string path,
                                                              bool shortUrl = false,
                                                              PendingUploadMode pendingUpload = null)
        {
            var createSharedLinkArg = new CreateSharedLinkArg(path,
                                                              shortUrl,
                                                              pendingUpload);

            return this.CreateSharedLinkAsync(createSharedLinkArg);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the create shared link route.</para>
        /// </summary>
        /// <param name="path">The path to share.</param>
        /// <param name="shortUrl">Whether to return a shortened URL.</param>
        /// <param name="pendingUpload">If it's okay to share a path that does not yet exist,
        /// set this to either 'file' or 'folder' to indicate whether to assume it's a file or
        /// folder.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="callbackState">A user provided object that distinguished this send
        /// from other send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginCreateSharedLink(string path,
                                                      bool shortUrl = false,
                                                      PendingUploadMode pendingUpload = null,
                                                      sys.AsyncCallback callback = null,
                                                      object callbackState = null)
        {
            var createSharedLinkArg = new CreateSharedLinkArg(path,
                                                              shortUrl,
                                                              pendingUpload);

            return this.BeginCreateSharedLink(createSharedLinkArg, callback, callbackState);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the create shared link route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        /// <exception cref="Dropbox.Api.ApiException{Files.PathError}">Thrown if there is an
        /// error processing the request; This will contain a <see
        /// cref="Files.PathError"/>.</exception>
        public PathLinkMetadata EndCreateSharedLink(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<PathLinkMetadata>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }
    }
}
