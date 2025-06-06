using Acumatica.RESTClient.Auxiliary;

using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        #region State & ctor

		private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path.
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config)
        {
            Configuration = config;

            var options = new RestClientOptions(Configuration.BasePath)
            {
                MaxTimeout = Configuration.Timeout,
            };

            RestClient = new RestClient(options);
        }

        public ApiClient(Configuration config, IList<JsonConverter> converters): this(config)
        {
            foreach (var thisConverter in converters)
            {
                serializerSettings.Converters.Add(thisConverter);
            }
        }

        /// <summary>
        /// Gets or sets an instance of the <see cref="Configuration"/>.
        /// </summary>
        /// <value>An instance of the IReadableConfiguration.</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }
        #endregion

        #region Public Methods

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The Task instance.</returns>
        public async Task<RestResponse> CallApiAsync(
            String path, Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType, CancellationToken cancellationToken = default)
        {
            if (Configuration.Token != null)
            {
                if (headerParams == null)
                {
                    headerParams = new Dictionary<String, String>();
                }
                headerParams.Add("Authorization", Configuration.Token.Token_type + " " + Configuration.Token.Access_token);
            }

            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType, Configuration.Timeout);

            if (Configuration.RequestInterceptor != null)
                Configuration.RequestInterceptor(request, this.RestClient);
            var response = await RestClient.ExecuteAsync(request, cancellationToken: cancellationToken);
            if (Configuration.ResponseInterceptor != null)
                Configuration.ResponseInterceptor(request, response, this.RestClient);

            return response;
        }
        
                /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The Task instance.</returns>
        public async Task<Stream> DownloadStreamAsync(
            String path, Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType, CancellationToken cancellationToken = default)
        {
            if (Configuration.Token != null)
            {
                if (headerParams == null)
                {
                    headerParams = new Dictionary<String, String>();
                }
                headerParams.Add("Authorization", Configuration.Token.Token_type + " " + Configuration.Token.Access_token);
            }

            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType, Configuration.Timeout);

            if (Configuration.RequestInterceptor != null)
                Configuration.RequestInterceptor(request, this.RestClient);
            var response = await RestClient.DownloadStreamAsync(request, cancellationToken: cancellationToken);
            if (Configuration.ResponseInterceptor != null)
                Configuration.ResponseInterceptor(request, new RestResponse(), this.RestClient);

            return response;
        }


        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString(Configuration.DateTimeFormat);
            else if (obj is DateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTimeOffset)obj).ToString(Configuration.DateTimeFormat);
            if (obj is string str)
                return str;
            else if (obj is IEnumerable enumerable)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in enumerable)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append("/");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
                return Convert.ToString(obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize<T>(RestResponse response)
        {
            IReadOnlyCollection<Parameter> headers = response.Headers;
            if (typeof(T) == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            if (typeof(T).Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (typeof(T) == typeof(String)) // return primitive type
            {
                return (String)response.Content;
            }

            if (typeof(T).Name.StartsWith("System.Nullable"))
            {
                return Convert.ChangeType(response.Content, typeof(T));
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, typeof(T), serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public String Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public String SelectHeaderContentType(String[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return "application/json";

            foreach (var contentType in contentTypes)
            {
                if (ApiClientHelpers.IsJsonMime(contentType.ToLower()))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public String SelectHeaderAccept(String[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return String.Join(",", accepts);
        }

        /// <summary>
        /// Convert params to key/value pairs. 
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A list of KeyValuePairs</returns>
        public IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name, object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection select new KeyValuePair<string, string>(name, ParameterToString(item)));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name, ParameterToString(value)));
            }

            return parameters;
        }
        #endregion

        #region Implementation
      
        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            String path, RestSharp.Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType, int timeout)
        {
            var request = new RestRequest(path, method);

            if (pathParams != null)
            {
                // add path parameter, if any
                foreach (var param in pathParams)
                {
                    request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);
                }
            }

            if (headerParams != null)
            {
                // add header parameter, if any
                foreach (var param in headerParams)
                {
                    request.AddHeader(param.Key, param.Value);
                }
            }

            if (queryParams != null)
            {
                // add query parameter, if any
                foreach (var param in queryParams)
                {
                    request.AddQueryParameter(param.Key, param.Value);
                }
            }

            if (formParams != null)
            {
                // add form parameter, if any
                foreach (var param in formParams)
                    request.AddParameter(param.Key, param.Value);
            }

            if (fileParams != null)
            {
                // add file parameter, if any
                foreach (var param in fileParams)
                {
                    request.AddFile(param.Value.Name, param.Value.GetFile, param.Value.FileName, param.Value.ContentType);
                }
            }

            if (postBody != null) // http body (model or byte[]) parameter
            {
                request.AddBody(postBody, contentType);
            }

            request.Timeout = timeout;

            return request;
        }

        /// <summary>
        /// Check if generic object is a collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if object is a collection type</returns>
        private static bool IsCollection(object value)
        {
            return value is IList || value is ICollection;
        }
        #endregion
    }
}
