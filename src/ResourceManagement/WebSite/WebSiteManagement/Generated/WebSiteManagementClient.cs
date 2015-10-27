// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Use these APIs to manage Azure Websites resources through the Azure
    /// Resource Manager. All task operations conform to the HTTP/1.1
    /// protocol specification and each operation returns an x-ms-request-id
    /// header that can be used to obtain information about the request. You
    /// must make sure that requests made to these resources are secure. For
    /// more information, see &lt;a
    /// href="https://msdn.microsoft.com/en-us/library/azure/dn790557.aspx"&gt;Authenticating
    /// Azure Resource Manager requests.&lt;/a&gt;
    /// </summary>
    public partial class WebSiteManagementClient : ServiceClient<WebSiteManagementClient>, IWebSiteManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }        

        /// <summary>
        /// The management credentials for Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Subscription Id
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// API Version
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout for Long Running Operations.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        public virtual ICertificateOrdersOperations CertificateOrders { get; private set; }

        public virtual ICertificatesOperations Certificates { get; private set; }

        public virtual IClassicMobileServicesOperations ClassicMobileServices { get; private set; }

        public virtual IDomainsOperations Domains { get; private set; }

        public virtual IGlobalModelOperations GlobalModel { get; private set; }

        public virtual IGlobalCertificateOrderOperations GlobalCertificateOrder { get; private set; }

        public virtual IGlobalDomainRegistrationOperations GlobalDomainRegistration { get; private set; }

        public virtual IGlobalResourceGroupsOperations GlobalResourceGroups { get; private set; }

        public virtual IHostingEnvironmentsOperations HostingEnvironments { get; private set; }

        public virtual IManagedHostingEnvironmentsOperations ManagedHostingEnvironments { get; private set; }

        public virtual IProviderOperations Provider { get; private set; }

        public virtual IServerFarmsOperations ServerFarms { get; private set; }

        public virtual ISitesOperations Sites { get; private set; }

        public virtual ITopLevelDomainsOperations TopLevelDomains { get; private set; }

        public virtual IUsageOperations Usage { get; private set; }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        public WebSiteManagementClient() : base()
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public WebSiteManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public WebSiteManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public WebSiteManagementClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. The management credentials for Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public WebSiteManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the WebSiteManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. The management credentials for Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public WebSiteManagementClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.CertificateOrders = new CertificateOrdersOperations(this);
            this.Certificates = new CertificatesOperations(this);
            this.ClassicMobileServices = new ClassicMobileServicesOperations(this);
            this.Domains = new DomainsOperations(this);
            this.GlobalModel = new GlobalModelOperations(this);
            this.GlobalCertificateOrder = new GlobalCertificateOrderOperations(this);
            this.GlobalDomainRegistration = new GlobalDomainRegistrationOperations(this);
            this.GlobalResourceGroups = new GlobalResourceGroupsOperations(this);
            this.HostingEnvironments = new HostingEnvironmentsOperations(this);
            this.ManagedHostingEnvironments = new ManagedHostingEnvironmentsOperations(this);
            this.Provider = new ProviderOperations(this);
            this.ServerFarms = new ServerFarmsOperations(this);
            this.Sites = new SitesOperations(this);
            this.TopLevelDomains = new TopLevelDomainsOperations(this);
            this.Usage = new UsageOperations(this);
            this.BaseUri = new Uri("https://management.azure.com");
            this.ApiVersion = "2015-08-01";
            this.AcceptLanguage = "en-US";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new ResourceJsonConverter()); 
            DeserializationSettings = new JsonSerializerSettings{
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings.Converters.Add(new ResourceJsonConverter()); 
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter()); 
        }    
    }
}
