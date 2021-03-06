// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Relay
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WCFRelaysOperations.
    /// </summary>
    public static partial class WCFRelaysOperationsExtensions
    {
            /// <summary>
            /// Lists the WCF relays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            public static IPage<WcfRelay> ListByNamespace(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the WCF relays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WcfRelay>> ListByNamespaceAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a WCF relay. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a WCF relay.
            /// </param>
            public static WcfRelay CreateOrUpdate(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, WcfRelay parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, relayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a WCF relay. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a WCF relay.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WcfRelay> CreateOrUpdateAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, WcfRelay parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            public static void Delete(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, relayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the description for the specified WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            public static WcfRelay Get(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, relayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WcfRelay> GetAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRules(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, relayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an authorization rule for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The authorization rule parameters.
            /// </param>
            public static AuthorizationRule CreateOrUpdateAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, AuthorizationRule parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an authorization rule for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The authorization rule parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> CreateOrUpdateAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, AuthorizationRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a WCF relay authorization rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a WCF relay authorization rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get authorizationRule for a WCF relay by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AuthorizationRule GetAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get authorizationRule for a WCF relay by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> GetAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and secondary connection strings to the WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AccessKeys ListKeys(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and secondary connection strings to the WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate authorization rule.
            /// </param>
            public static AccessKeys RegenerateKeys(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, RegenerateAccessKeyParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The relay name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeysAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, RegenerateAccessKeyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the WCF relays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WcfRelay> ListByNamespaceNext(this IWCFRelaysOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the WCF relays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WcfRelay>> ListByNamespaceNextAsync(this IWCFRelaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRulesNext(this IWCFRelaysOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a WCF relay.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesNextAsync(this IWCFRelaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
