// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// TopLevelDomainsOperations operations.
    /// </summary>
    public partial interface ITopLevelDomainsOperations
    {
        /// <summary>
        /// Lists all top level domains supported for registration
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<TopLevelDomainCollection>> GetGetTopLevelDomainsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets details of a top level domain
        /// </summary>
        /// <param name='name'>
        /// Name of the top level domain
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<TopLevelDomain>> GetTopLevelDomainWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists legal agreements that user needs to accept before purchasing
        /// domain
        /// </summary>
        /// <param name='name'>
        /// Name of the top level domain
        /// </param>
        /// <param name='agreementOption'>
        /// Domain agreement options
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<TldLegalAgreementCollection>> ListTopLevelDomainAgreementsWithHttpMessagesAsync(string name, TopLevelDomainAgreementOption agreementOption, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
