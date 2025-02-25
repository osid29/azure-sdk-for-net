// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.FrontDoor. </summary>
    public static partial class FrontDoorExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new TenantResourceExtensionClient(client, resource.Id);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new TenantResourceExtensionClient(client, scope);
            });
        }
        #region FrontDoorWebApplicationFirewallPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorWebApplicationFirewallPolicyResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> object. </returns>
        public static FrontDoorWebApplicationFirewallPolicyResource GetFrontDoorWebApplicationFirewallPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorWebApplicationFirewallPolicyResource.ValidateResourceId(id);
                return new FrontDoorWebApplicationFirewallPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorResource" /> object. </returns>
        public static FrontDoorResource GetFrontDoorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorResource.ValidateResourceId(id);
                return new FrontDoorResource(client, id);
            }
            );
        }
        #endregion

        #region FrontendEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontendEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontendEndpointResource.CreateResourceIdentifier" /> to create a <see cref="FrontendEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontendEndpointResource" /> object. </returns>
        public static FrontendEndpointResource GetFrontendEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontendEndpointResource.ValidateResourceId(id);
                return new FrontendEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorRulesEngineResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorRulesEngineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorRulesEngineResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorRulesEngineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorRulesEngineResource" /> object. </returns>
        public static FrontDoorRulesEngineResource GetFrontDoorRulesEngineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorRulesEngineResource.ValidateResourceId(id);
                return new FrontDoorRulesEngineResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorNetworkExperimentProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorNetworkExperimentProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorNetworkExperimentProfileResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorNetworkExperimentProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorNetworkExperimentProfileResource" /> object. </returns>
        public static FrontDoorNetworkExperimentProfileResource GetFrontDoorNetworkExperimentProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorNetworkExperimentProfileResource.ValidateResourceId(id);
                return new FrontDoorNetworkExperimentProfileResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorExperimentResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorExperimentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorExperimentResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorExperimentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorExperimentResource" /> object. </returns>
        public static FrontDoorExperimentResource GetFrontDoorExperimentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorExperimentResource.ValidateResourceId(id);
                return new FrontDoorExperimentResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of FrontDoorWebApplicationFirewallPolicyResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorWebApplicationFirewallPolicyResources and their operations over a FrontDoorWebApplicationFirewallPolicyResource. </returns>
        public static FrontDoorWebApplicationFirewallPolicyCollection GetFrontDoorWebApplicationFirewallPolicies(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetFrontDoorWebApplicationFirewallPolicies();
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorWebApplicationFirewallPolicyResource>> GetFrontDoorWebApplicationFirewallPolicyAsync(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies().GetAsync(policyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorWebApplicationFirewallPolicyResource> GetFrontDoorWebApplicationFirewallPolicy(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies().Get(policyName, cancellationToken);
        }

        /// <summary> Gets a collection of FrontDoorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorResources and their operations over a FrontDoorResource. </returns>
        public static FrontDoorCollection GetFrontDoors(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetFrontDoors();
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorResource>> GetFrontDoorAsync(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoors().GetAsync(frontDoorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorResource> GetFrontDoor(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoors().Get(frontDoorName, cancellationToken);
        }

        /// <summary> Gets a collection of FrontDoorNetworkExperimentProfileResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorNetworkExperimentProfileResources and their operations over a FrontDoorNetworkExperimentProfileResource. </returns>
        public static FrontDoorNetworkExperimentProfileCollection GetFrontDoorNetworkExperimentProfiles(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetFrontDoorNetworkExperimentProfiles();
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorNetworkExperimentProfileResource>> GetFrontDoorNetworkExperimentProfileAsync(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoorNetworkExperimentProfiles().GetAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfile(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoorNetworkExperimentProfiles().Get(profileName, cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRuleSets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetManagedRuleSetsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRuleSets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetManagedRuleSets(cancellationToken);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailabilityWithSubscription_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(this SubscriptionResource subscriptionResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CheckFrontDoorNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailabilityWithSubscription_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(this SubscriptionResource subscriptionResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).CheckFrontDoorNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FrontDoorResource> GetFrontDoorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFrontDoorsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FrontDoorResource> GetFrontDoors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFrontDoors(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfilesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFrontDoorNetworkExperimentProfilesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfiles(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFrontDoorNetworkExperimentProfiles(cancellationToken);
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailability_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(this TenantResource tenantResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetTenantResourceExtensionClient(tenantResource).CheckFrontDoorNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailability_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(this TenantResource tenantResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetTenantResourceExtensionClient(tenantResource).CheckFrontDoorNameAvailability(content, cancellationToken);
        }
    }
}
