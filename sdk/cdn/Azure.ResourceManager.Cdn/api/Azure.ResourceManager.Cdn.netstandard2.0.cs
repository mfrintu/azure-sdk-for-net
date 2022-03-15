namespace Azure.ResourceManager.Cdn
{
    public partial class AfdCustomDomain : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdCustomDomain() { }
        public virtual Azure.ResourceManager.Cdn.AfdCustomDomainData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string customDomainName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.Models.ValidationToken> RefreshValidationToken(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.Models.ValidationToken>> RefreshValidationTokenAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdCustomDomain> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdCustomDomainData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdCustomDomain>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdCustomDomainData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdCustomDomainCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdCustomDomain>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdCustomDomain>, System.Collections.IEnumerable
    {
        protected AfdCustomDomainCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdCustomDomain> CreateOrUpdate(Azure.WaitUntil waitUntil, string customDomainName, Azure.ResourceManager.Cdn.AfdCustomDomainData customDomain, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdCustomDomain>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string customDomainName, Azure.ResourceManager.Cdn.AfdCustomDomainData customDomain, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain> Get(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdCustomDomain> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdCustomDomain> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain>> GetAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain> GetIfExists(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain>> GetIfExistsAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdCustomDomain> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdCustomDomain>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdCustomDomain> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdCustomDomain>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdCustomDomainData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdCustomDomainData() { }
        public Azure.Core.ResourceIdentifier AzureDnsZoneId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.DomainValidationState? DomainValidationState { get { throw null; } }
        public string HostName { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdCustomDomainHttpsParameters TlsSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.DomainValidationProperties ValidationProperties { get { throw null; } }
    }
    public partial class AfdEndpoint : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdEndpoint() { }
        public virtual Azure.ResourceManager.Cdn.AfdEndpointData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRoute> GetAfdRoute(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRoute>> GetAfdRouteAsync(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdRouteCollection GetAfdRoutes() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsage(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsageAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation PurgeContent(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.AfdPurgeOptions contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> PurgeContentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.AfdPurgeOptions contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdEndpoint> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdEndpointData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdEndpoint>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdEndpointData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateCustomDomainOutput> ValidateCustomDomain(Azure.ResourceManager.Cdn.Models.ValidateCustomDomainInput customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateCustomDomainOutput>> ValidateCustomDomainAsync(Azure.ResourceManager.Cdn.Models.ValidateCustomDomainInput customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdEndpointCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdEndpoint>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdEndpoint>, System.Collections.IEnumerable
    {
        protected AfdEndpointCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdEndpoint> CreateOrUpdate(Azure.WaitUntil waitUntil, string endpointName, Azure.ResourceManager.Cdn.AfdEndpointData endpointInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdEndpoint>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string endpointName, Azure.ResourceManager.Cdn.AfdEndpointData endpointInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> Get(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdEndpoint> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdEndpoint> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> GetAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> GetIfExists(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> GetIfExistsAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdEndpoint> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdEndpoint>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdEndpoint> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdEndpoint>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdEndpointData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public AfdEndpointData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public string HostName { get { throw null; } }
        public int? OriginResponseTimeoutSeconds { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class AfdOrigin : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdOrigin() { }
        public virtual Azure.ResourceManager.Cdn.AfdOriginData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string originGroupName, string originName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOrigin> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdOriginData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOrigin>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdOriginData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdOriginCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdOrigin>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdOrigin>, System.Collections.IEnumerable
    {
        protected AfdOriginCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOrigin> CreateOrUpdate(Azure.WaitUntil waitUntil, string originName, Azure.ResourceManager.Cdn.AfdOriginData origin, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOrigin>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string originName, Azure.ResourceManager.Cdn.AfdOriginData origin, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin> Get(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdOrigin> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdOrigin> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin>> GetAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin> GetIfExists(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin>> GetIfExistsAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdOrigin> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdOrigin>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdOrigin> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdOrigin>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdOriginData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdOriginData() { }
        public Azure.Core.ResourceIdentifier AzureOriginId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public int? HttpPort { get { throw null; } set { } }
        public int? HttpsPort { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
        public object SharedPrivateLinkResource { get { throw null; } set { } }
        public int? Weight { get { throw null; } set { } }
    }
    public partial class AfdOriginGroup : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdOriginGroup() { }
        public virtual Azure.ResourceManager.Cdn.AfdOriginGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string originGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin> GetAfdOrigin(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOrigin>> GetAfdOriginAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdOriginCollection GetAfdOrigins() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsage(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsageAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOriginGroup> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdOriginGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOriginGroup>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdOriginGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdOriginGroupCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdOriginGroup>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdOriginGroup>, System.Collections.IEnumerable
    {
        protected AfdOriginGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOriginGroup> CreateOrUpdate(Azure.WaitUntil waitUntil, string originGroupName, Azure.ResourceManager.Cdn.AfdOriginGroupData originGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdOriginGroup>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string originGroupName, Azure.ResourceManager.Cdn.AfdOriginGroupData originGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup> Get(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdOriginGroup> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdOriginGroup> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup>> GetAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup> GetIfExists(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup>> GetIfExistsAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdOriginGroup> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdOriginGroup>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdOriginGroup> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdOriginGroup>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdOriginGroupData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdOriginGroupData() { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.HealthProbeParameters HealthProbeSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.LoadBalancingSettingsParameters LoadBalancingSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedOriginErrorDetectionParameters ResponseBasedAfdOriginErrorDetectionSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? SessionAffinityState { get { throw null; } set { } }
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get { throw null; } set { } }
    }
    public partial class AfdRoute : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdRoute() { }
        public virtual Azure.ResourceManager.Cdn.AfdRouteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRoute> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRoute>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRoute> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdRouteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRoute>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdRouteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdRouteCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRoute>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRoute>, System.Collections.IEnumerable
    {
        protected AfdRouteCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRoute> CreateOrUpdate(Azure.WaitUntil waitUntil, string routeName, Azure.ResourceManager.Cdn.AfdRouteData route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRoute>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string routeName, Azure.ResourceManager.Cdn.AfdRouteData route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRoute> Get(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdRoute> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdRoute> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRoute>> GetAsync(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRoute> GetIfExists(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRoute>> GetIfExistsAsync(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdRoute> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRoute>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdRoute> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRoute>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdRouteData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdRouteData() { }
        public object CompressionSettings { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> CustomDomains { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ForwardingProtocol? ForwardingProtocol { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HttpsRedirect? HttpsRedirect { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain? LinkToDefaultDomain { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier OriginGroupId { get { throw null; } set { } }
        public string OriginPath { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> PatternsToMatch { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdQueryStringCachingBehavior? QueryStringCachingBehavior { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> RuleSets { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols> SupportedProtocols { get { throw null; } }
    }
    public partial class AfdRule : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdRule() { }
        public virtual Azure.ResourceManager.Cdn.AfdRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRule> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRule>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdRuleCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRule>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRule>, System.Collections.IEnumerable
    {
        protected AfdRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRule> CreateOrUpdate(Azure.WaitUntil waitUntil, string ruleName, Azure.ResourceManager.Cdn.AfdRuleData rule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRule>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string ruleName, Azure.ResourceManager.Cdn.AfdRuleData rule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRule> Get(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdRule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdRule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRule>> GetAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRule> GetIfExists(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRule>> GetIfExistsAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdRule> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRule>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdRule> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRule>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdRuleData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdRuleData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleAction> Actions { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition> Conditions { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior? MatchProcessingBehavior { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class AfdRuleSet : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdRuleSet() { }
        public virtual Azure.ResourceManager.Cdn.AfdRuleSetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRule> GetAfdRule(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRule>> GetAfdRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdRuleCollection GetAfdRules() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsage(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsageAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdRuleSetCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRuleSet>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRuleSet>, System.Collections.IEnumerable
    {
        protected AfdRuleSetCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRuleSet> CreateOrUpdate(Azure.WaitUntil waitUntil, string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdRuleSet>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet> Get(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdRuleSet> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdRuleSet> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet>> GetAsync(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet> GetIfExists(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet>> GetIfExistsAsync(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdRuleSet> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdRuleSet>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdRuleSet> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdRuleSet>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdRuleSetData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdRuleSetData() { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class AfdSecret : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdSecret() { }
        public virtual Azure.ResourceManager.Cdn.AfdSecretData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string secretName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecret> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecret>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdSecretCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdSecret>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdSecret>, System.Collections.IEnumerable
    {
        protected AfdSecretCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecret> CreateOrUpdate(Azure.WaitUntil waitUntil, string secretName, Azure.ResourceManager.Cdn.AfdSecretData secret, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecret>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string secretName, Azure.ResourceManager.Cdn.AfdSecretData secret, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecret> Get(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdSecret> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdSecret> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecret>> GetAsync(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecret> GetIfExists(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecret>> GetIfExistsAsync(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdSecret> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdSecret>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdSecret> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdSecret>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdSecretData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdSecretData() { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class AfdSecurityPolicy : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AfdSecurityPolicy() { }
        public virtual Azure.ResourceManager.Cdn.AfdSecurityPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string securityPolicyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecurityPolicy> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdSecurityPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableAfdSecurityPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AfdSecurityPolicyCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdSecurityPolicy>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdSecurityPolicy>, System.Collections.IEnumerable
    {
        protected AfdSecurityPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecurityPolicy> CreateOrUpdate(Azure.WaitUntil waitUntil, string securityPolicyName, Azure.ResourceManager.Cdn.AfdSecurityPolicyData securityPolicy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string securityPolicyName, Azure.ResourceManager.Cdn.AfdSecurityPolicyData securityPolicy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy> Get(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.AfdSecurityPolicy> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.AfdSecurityPolicy> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> GetAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy> GetIfExists(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> GetIfExistsAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.AfdSecurityPolicy> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.AfdSecurityPolicy>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.AfdSecurityPolicy> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.AfdSecurityPolicy>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AfdSecurityPolicyData : Azure.ResourceManager.Models.ResourceData
    {
        public AfdSecurityPolicyData() { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    public static partial class ArmClientExtensions
    {
        public static Azure.ResourceManager.Cdn.AfdCustomDomain GetAfdCustomDomain(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdEndpoint GetAfdEndpoint(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdOrigin GetAfdOrigin(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdOriginGroup GetAfdOriginGroup(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdRoute GetAfdRoute(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdRule GetAfdRule(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdRuleSet GetAfdRuleSet(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdSecret GetAfdSecret(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.AfdSecurityPolicy GetAfdSecurityPolicy(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.CdnCustomDomain GetCdnCustomDomain(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.CdnEndpoint GetCdnEndpoint(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.CdnOrigin GetCdnOrigin(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.CdnOriginGroup GetCdnOriginGroup(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy GetCdnWebApplicationFirewallPolicy(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cdn.Profile GetProfile(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class CdnCustomDomain : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CdnCustomDomain() { }
        public virtual Azure.ResourceManager.Cdn.CdnCustomDomainData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string customDomainName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation DisableCustomHttps(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DisableCustomHttpsAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation EnableCustomHttps(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.CustomDomainHttpsOptions customDomainHttpsParameters = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> EnableCustomHttpsAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.CustomDomainHttpsOptions customDomainHttpsParameters = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CdnCustomDomainCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnCustomDomain>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnCustomDomain>, System.Collections.IEnumerable
    {
        protected CdnCustomDomainCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnCustomDomain> CreateOrUpdate(Azure.WaitUntil waitUntil, string customDomainName, Azure.ResourceManager.Cdn.Models.CustomDomainOptions customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnCustomDomain>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string customDomainName, Azure.ResourceManager.Cdn.Models.CustomDomainOptions customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain> Get(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.CdnCustomDomain> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.CdnCustomDomain> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain>> GetAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain> GetIfExists(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain>> GetIfExistsAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.CdnCustomDomain> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnCustomDomain>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.CdnCustomDomain> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnCustomDomain>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CdnCustomDomainData : Azure.ResourceManager.Models.ResourceData
    {
        public CdnCustomDomainData() { }
        public Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState? CustomHttpsProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate? CustomHttpsProvisioningSubstate { get { throw null; } }
        public string HostName { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.CustomDomainResourceState? ResourceState { get { throw null; } }
        public string ValidationData { get { throw null; } set { } }
    }
    public partial class CdnEndpoint : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CdnEndpoint() { }
        public virtual Azure.ResourceManager.Cdn.CdnEndpointData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain> GetCdnCustomDomain(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnCustomDomain>> GetCdnCustomDomainAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.CdnCustomDomainCollection GetCdnCustomDomains() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin> GetCdnOrigin(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin>> GetCdnOriginAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup> GetCdnOriginGroup(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup>> GetCdnOriginGroupAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.CdnOriginGroupCollection GetCdnOriginGroups() { throw null; }
        public virtual Azure.ResourceManager.Cdn.CdnOriginCollection GetCdnOrigins() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsage(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsageAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation LoadContent(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.LoadOptions contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> LoadContentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.LoadOptions contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation PurgeContent(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PurgeOptions contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> PurgeContentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PurgeOptions contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint> Start(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint>> StartAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint> Stop(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint>> StopAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnEndpointData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnEndpointData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateCustomDomainOutput> ValidateCustomDomain(Azure.ResourceManager.Cdn.Models.ValidateCustomDomainInput customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateCustomDomainOutput>> ValidateCustomDomainAsync(Azure.ResourceManager.Cdn.Models.ValidateCustomDomainInput customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CdnEndpointCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnEndpoint>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnEndpoint>, System.Collections.IEnumerable
    {
        protected CdnEndpointCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint> CreateOrUpdate(Azure.WaitUntil waitUntil, string endpointName, Azure.ResourceManager.Cdn.CdnEndpointData endpointInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnEndpoint>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string endpointName, Azure.ResourceManager.Cdn.CdnEndpointData endpointInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> Get(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.CdnEndpoint> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.CdnEndpoint> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> GetAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> GetIfExists(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> GetIfExistsAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.CdnEndpoint> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnEndpoint>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.CdnEndpoint> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnEndpoint>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CdnEndpointData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CdnEndpointData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IList<string> ContentTypesToCompress { get { throw null; } }
        public string DefaultOriginGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EndpointPropertiesUpdateParametersDeliveryPolicy DeliveryPolicy { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.GeoFilter> GeoFilters { get { throw null; } }
        public string HostName { get { throw null; } }
        public bool? IsCompressionEnabled { get { throw null; } set { } }
        public bool? IsHttpAllowed { get { throw null; } set { } }
        public bool? IsHttpsAllowed { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.OptimizationType? OptimizationType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeepCreatedOriginGroup> OriginGroups { get { throw null; } }
        public string OriginHostHeader { get { throw null; } set { } }
        public string OriginPath { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeepCreatedOrigin> Origins { get { throw null; } }
        public string ProbePath { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.QueryStringCachingBehavior? QueryStringCachingBehavior { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EndpointResourceState? ResourceState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.UrlSigningKey> UrlSigningKeys { get { throw null; } set { } }
        public string WebApplicationFirewallPolicyLinkId { get { throw null; } set { } }
    }
    public partial class CdnOrigin : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CdnOrigin() { }
        public virtual Azure.ResourceManager.Cdn.CdnOriginData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string originName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOrigin> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnOriginData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOrigin>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnOriginData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CdnOriginCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnOrigin>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnOrigin>, System.Collections.IEnumerable
    {
        protected CdnOriginCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOrigin> CreateOrUpdate(Azure.WaitUntil waitUntil, string originName, Azure.ResourceManager.Cdn.CdnOriginData origin, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOrigin>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string originName, Azure.ResourceManager.Cdn.CdnOriginData origin, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin> Get(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.CdnOrigin> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.CdnOrigin> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin>> GetAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin> GetIfExists(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOrigin>> GetIfExistsAsync(string originName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.CdnOrigin> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnOrigin>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.CdnOrigin> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnOrigin>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CdnOriginData : Azure.ResourceManager.Models.ResourceData
    {
        public CdnOriginData() { }
        public bool? Enabled { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public int? HttpPort { get { throw null; } set { } }
        public int? HttpsPort { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus? PrivateEndpointStatus { get { throw null; } }
        public string PrivateLinkAlias { get { throw null; } set { } }
        public string PrivateLinkApprovalMessage { get { throw null; } set { } }
        public string PrivateLinkLocation { get { throw null; } set { } }
        public string PrivateLinkResourceId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.OriginResourceState? ResourceState { get { throw null; } }
        public int? Weight { get { throw null; } set { } }
    }
    public partial class CdnOriginGroup : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CdnOriginGroup() { }
        public virtual Azure.ResourceManager.Cdn.CdnOriginGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string originGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOriginGroup> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnOriginGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOriginGroup>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cdn.Models.PatchableCdnOriginGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CdnOriginGroupCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnOriginGroup>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnOriginGroup>, System.Collections.IEnumerable
    {
        protected CdnOriginGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOriginGroup> CreateOrUpdate(Azure.WaitUntil waitUntil, string originGroupName, Azure.ResourceManager.Cdn.CdnOriginGroupData originGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnOriginGroup>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string originGroupName, Azure.ResourceManager.Cdn.CdnOriginGroupData originGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup> Get(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.CdnOriginGroup> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.CdnOriginGroup> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup>> GetAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup> GetIfExists(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnOriginGroup>> GetIfExistsAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.CdnOriginGroup> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnOriginGroup>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.CdnOriginGroup> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnOriginGroup>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CdnOriginGroupData : Azure.ResourceManager.Models.ResourceData
    {
        public CdnOriginGroupData() { }
        public Azure.ResourceManager.Cdn.Models.HealthProbeParameters HealthProbeSettings { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> Origins { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.OriginGroupResourceState? ResourceState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get { throw null; } set { } }
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get { throw null; } set { } }
    }
    public partial class CdnWebApplicationFirewallPolicy : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CdnWebApplicationFirewallPolicy() { }
        public virtual Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string policyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CdnWebApplicationFirewallPolicyCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>, System.Collections.IEnumerable
    {
        protected CdnWebApplicationFirewallPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> CreateOrUpdate(Azure.WaitUntil waitUntil, string policyName, Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicyData cdnWebApplicationFirewallPolicy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policyName, Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicyData cdnWebApplicationFirewallPolicy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> Get(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> GetAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> GetIfExists(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> GetIfExistsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CdnWebApplicationFirewallPolicyData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CdnWebApplicationFirewallPolicyData(Azure.Core.AzureLocation location, Azure.ResourceManager.Cdn.Models.CdnSku sku) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.CustomRule> CustomRules { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> EndpointLinks { get { throw null; } }
        public string Etag { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.ManagedRuleSet> ManagedRuleSets { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.PolicySettings PolicySettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.RateLimitRule> RateLimitRules { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.PolicyResourceState? ResourceState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.CdnSkuName? SkuName { get { throw null; } set { } }
    }
    public partial class Profile : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected Profile() { }
        public virtual Azure.ResourceManager.Cdn.ProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.SsoUri> GenerateSsoUri(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.SsoUri>> GenerateSsoUriAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain> GetAfdCustomDomain(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdCustomDomain>> GetAfdCustomDomainAsync(string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdCustomDomainCollection GetAfdCustomDomains() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint> GetAfdEndpoint(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdEndpoint>> GetAfdEndpointAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdEndpointCollection GetAfdEndpoints() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup> GetAfdOriginGroup(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdOriginGroup>> GetAfdOriginGroupAsync(string originGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdOriginGroupCollection GetAfdOriginGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet> GetAfdRuleSet(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdRuleSet>> GetAfdRuleSetAsync(string ruleSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdRuleSetCollection GetAfdRuleSets() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecret> GetAfdSecret(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecret>> GetAfdSecretAsync(string secretName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdSecretCollection GetAfdSecrets() { throw null; }
        public virtual Azure.ResourceManager.Cdn.AfdSecurityPolicyCollection GetAfdSecurityPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy> GetAfdSecurityPolicy(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.AfdSecurityPolicy>> GetAfdSecurityPolicyAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint> GetCdnEndpoint(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnEndpoint>> GetCdnEndpointAsync(string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cdn.CdnEndpointCollection GetCdnEndpoints() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.ContinentsResponse> GetLogAnalyticsLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.ContinentsResponse>> GetLogAnalyticsLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.MetricsResponse> GetLogAnalyticsMetrics(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, Azure.ResourceManager.Cdn.Models.LogMetricsGranularity granularity, System.Collections.Generic.IEnumerable<string> customDomains, System.Collections.Generic.IEnumerable<string> protocols, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy> groupBy = null, System.Collections.Generic.IEnumerable<string> continents = null, System.Collections.Generic.IEnumerable<string> countryOrRegions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.MetricsResponse>> GetLogAnalyticsMetricsAsync(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, Azure.ResourceManager.Cdn.Models.LogMetricsGranularity granularity, System.Collections.Generic.IEnumerable<string> customDomains, System.Collections.Generic.IEnumerable<string> protocols, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy> groupBy = null, System.Collections.Generic.IEnumerable<string> continents = null, System.Collections.Generic.IEnumerable<string> countryOrRegions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.RankingsResponse> GetLogAnalyticsRankings(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogRanking> rankings, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogRankingMetric> metrics, int maxRanking, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, System.Collections.Generic.IEnumerable<string> customDomains = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.RankingsResponse>> GetLogAnalyticsRankingsAsync(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogRanking> rankings, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.LogRankingMetric> metrics, int maxRanking, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, System.Collections.Generic.IEnumerable<string> customDomains = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.ResourcesResponse> GetLogAnalyticsResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.ResourcesResponse>> GetLogAnalyticsResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsage(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsageAfdProfiles(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.CdnUsage> GetResourceUsageAfdProfilesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsageAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.SupportedOptimizationTypesListResult> GetSupportedOptimizationTypes(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.SupportedOptimizationTypesListResult>> GetSupportedOptimizationTypesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.WafMetricsResponse> GetWafLogAnalyticsMetrics(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, Azure.ResourceManager.Cdn.Models.WafGranularity granularity, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafAction> actions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRankingGroupBy> groupBy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRuleType> ruleTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.WafMetricsResponse>> GetWafLogAnalyticsMetricsAsync(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, Azure.ResourceManager.Cdn.Models.WafGranularity granularity, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafAction> actions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRankingGroupBy> groupBy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRuleType> ruleTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Models.WafRankingsResponse> GetWafLogAnalyticsRankings(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, int maxRanking, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRankingType> rankings, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafAction> actions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRuleType> ruleTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.WafRankingsResponse>> GetWafLogAnalyticsRankingsAsync(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafMetric> metrics, System.DateTimeOffset dateTimeBegin, System.DateTimeOffset dateTimeEnd, int maxRanking, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRankingType> rankings, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafAction> actions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.WafRuleType> ruleTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ProfileCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.Profile>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Profile>, System.Collections.IEnumerable
    {
        protected ProfileCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.Profile> CreateOrUpdate(Azure.WaitUntil waitUntil, string profileName, Azure.ResourceManager.Cdn.ProfileData profile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cdn.Profile>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string profileName, Azure.ResourceManager.Cdn.ProfileData profile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> Get(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cdn.Profile> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cdn.Profile> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> GetAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cdn.Profile> GetIfExists(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> GetIfExistsAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cdn.Profile> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cdn.Profile>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cdn.Profile> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Profile>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ProfileData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ProfileData(Azure.Core.AzureLocation location, Azure.ResourceManager.Cdn.Models.CdnSku sku) : base (default(Azure.Core.AzureLocation)) { }
        public string FrontdoorId { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ProfileResourceState? ResourceState { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.CdnSkuName? SkuName { get { throw null; } set { } }
    }
    public static partial class ResourceGroupExtensions
    {
        public static Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicyCollection GetCdnWebApplicationFirewallPolicies(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy> GetCdnWebApplicationFirewallPolicy(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.CdnWebApplicationFirewallPolicy>> GetCdnWebApplicationFirewallPolicyAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Cdn.Profile> GetProfile(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Profile>> GetProfileAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Cdn.ProfileCollection GetProfiles(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
    }
    public static partial class SubscriptionExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityOutput> CheckCdnNameAvailabilityWithSubscription(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityInput checkNameAvailabilityInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityWithSubscriptionAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityInput checkNameAvailabilityInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cdn.Models.ManagedRuleSetDefinition> GetManagedRuleSets(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cdn.Profile> GetProfiles(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cdn.Profile> GetProfilesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsages(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.ResourceUsage> GetResourceUsagesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateProbeOutput> ValidateProbe(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.Cdn.Models.ValidateProbeInput validateProbeInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.ValidateProbeOutput>> ValidateProbeAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.Cdn.Models.ValidateProbeInput validateProbeInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class TenantExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityOutput> CheckCdnNameAvailability(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityInput checkNameAvailabilityInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityAsync(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.Cdn.Models.CheckNameAvailabilityInput checkNameAvailabilityInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cdn.Models.EdgeNode> GetEdgeNodes(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cdn.Models.EdgeNode> GetEdgeNodesAsync(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Cdn.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionType : System.IEquatable<Azure.ResourceManager.Cdn.Models.ActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ActionType Allow { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ActionType Block { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ActionType Log { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ActionType Redirect { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ActionType left, Azure.ResourceManager.Cdn.Models.ActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ActionType left, Azure.ResourceManager.Cdn.Models.ActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AfdCertificateType : System.IEquatable<Azure.ResourceManager.Cdn.Models.AfdCertificateType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AfdCertificateType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.AfdCertificateType CustomerCertificate { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdCertificateType ManagedCertificate { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.AfdCertificateType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.AfdCertificateType left, Azure.ResourceManager.Cdn.Models.AfdCertificateType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.AfdCertificateType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.AfdCertificateType left, Azure.ResourceManager.Cdn.Models.AfdCertificateType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AfdCustomDomainHttpsParameters
    {
        public AfdCustomDomainHttpsParameters(Azure.ResourceManager.Cdn.Models.AfdCertificateType certificateType) { }
        public Azure.ResourceManager.Cdn.Models.AfdCertificateType CertificateType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdMinimumTlsVersion? MinimumTlsVersion { get { throw null; } set { } }
        public string SecretId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AfdEndpointProtocols : System.IEquatable<Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AfdEndpointProtocols(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols Http { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols Https { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols left, Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols left, Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum AfdMinimumTlsVersion
    {
        TLS10 = 0,
        TLS12 = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AfdProvisioningState : System.IEquatable<Azure.ResourceManager.Cdn.Models.AfdProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AfdProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.AfdProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.AfdProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.AfdProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.AfdProvisioningState left, Azure.ResourceManager.Cdn.Models.AfdProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.AfdProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.AfdProvisioningState left, Azure.ResourceManager.Cdn.Models.AfdProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AfdPurgeOptions
    {
        public AfdPurgeOptions(System.Collections.Generic.IEnumerable<string> contentPaths) { }
        public System.Collections.Generic.IList<string> ContentPaths { get { throw null; } }
        public System.Collections.Generic.IList<string> Domains { get { throw null; } }
    }
    public enum AfdQueryStringCachingBehavior
    {
        NotSet = 0,
        IgnoreQueryString = 1,
        UseQueryString = 2,
    }
    public partial class AfdStateProperties
    {
        public AfdStateProperties() { }
        public Azure.ResourceManager.Cdn.Models.DeploymentStatus? DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdProvisioningState? ProvisioningState { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CacheBehavior : System.IEquatable<Azure.ResourceManager.Cdn.Models.CacheBehavior>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CacheBehavior(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CacheBehavior BypassCache { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CacheBehavior Override { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CacheBehavior SetIfMissing { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CacheBehavior other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CacheBehavior left, Azure.ResourceManager.Cdn.Models.CacheBehavior right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CacheBehavior (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CacheBehavior left, Azure.ResourceManager.Cdn.Models.CacheBehavior right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CacheExpirationActionParameters
    {
        public CacheExpirationActionParameters(Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.CacheBehavior cacheBehavior, Azure.ResourceManager.Cdn.Models.CacheType cacheType) { }
        public Azure.ResourceManager.Cdn.Models.CacheBehavior CacheBehavior { get { throw null; } set { } }
        public System.TimeSpan? CacheDuration { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.CacheType CacheType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType OdataType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CacheExpirationActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CacheExpirationActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleCacheExpirationActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CacheExpirationActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CacheKeyQueryStringActionParameters
    {
        public CacheKeyQueryStringActionParameters(Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.QueryStringBehavior queryStringBehavior) { }
        public Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType OdataType { get { throw null; } set { } }
        public string QueryParameters { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.QueryStringBehavior QueryStringBehavior { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CacheKeyQueryStringActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CacheKeyQueryStringActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleCacheKeyQueryStringBehaviorActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CacheType : System.IEquatable<Azure.ResourceManager.Cdn.Models.CacheType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CacheType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CacheType All { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CacheType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CacheType left, Azure.ResourceManager.Cdn.Models.CacheType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CacheType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CacheType left, Azure.ResourceManager.Cdn.Models.CacheType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CdnSku
    {
        public CdnSku() { }
        public Azure.ResourceManager.Cdn.Models.CdnSkuName? Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CdnSkuName : System.IEquatable<Azure.ResourceManager.Cdn.Models.CdnSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CdnSkuName(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName CustomVerizon { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName PremiumAzureFrontDoor { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName PremiumChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName PremiumVerizon { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName Standard955BandWidthChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardAkamai { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardAvgBandWidthChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardAzureFrontDoor { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardMicrosoft { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardPlus955BandWidthChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardPlusAvgBandWidthChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardPlusChinaCdn { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CdnSkuName StandardVerizon { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CdnSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CdnSkuName left, Azure.ResourceManager.Cdn.Models.CdnSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CdnSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CdnSkuName left, Azure.ResourceManager.Cdn.Models.CdnSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CdnUsage
    {
        internal CdnUsage() { }
        public long CurrentValue { get { throw null; } }
        public string Id { get { throw null; } }
        public long Limit { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.UsageName Name { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.UsageUnit Unit { get { throw null; } }
    }
    public partial class CheckNameAvailabilityInput
    {
        public CheckNameAvailabilityInput(string name) { }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
    }
    public partial class CheckNameAvailabilityOutput
    {
        internal CheckNameAvailabilityOutput() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    public partial class CidrIPAddress
    {
        public CidrIPAddress() { }
        public string BaseIPAddress { get { throw null; } set { } }
        public int? PrefixLength { get { throw null; } set { } }
    }
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        internal Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems() { }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public float? Value { get { throw null; } }
    }
    public partial class Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        internal Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems() { }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public float? Value { get { throw null; } }
    }
    public partial class ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems
    {
        internal ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems() { }
        public string Metric { get { throw null; } }
        public double? Percentage { get { throw null; } }
        public long? Value { get { throw null; } }
    }
    public partial class ContinentsResponse
    {
        internal ContinentsResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ContinentsResponseContinentsItem> Continents { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ContinentsResponseCountryOrRegionsItem> CountryOrRegions { get { throw null; } }
    }
    public partial class ContinentsResponseContinentsItem
    {
        internal ContinentsResponseContinentsItem() { }
        public string Id { get { throw null; } }
    }
    public partial class ContinentsResponseCountryOrRegionsItem
    {
        internal ContinentsResponseCountryOrRegionsItem() { }
        public string ContinentId { get { throw null; } }
        public string Id { get { throw null; } }
    }
    public partial class CookiesMatchConditionParameters
    {
        public CookiesMatchConditionParameters(Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.CookiesOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.CookiesOperator Operator { get { throw null; } set { } }
        public string Selector { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CookiesMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CookiesMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleCookiesConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CookiesOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.CookiesOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CookiesOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CookiesOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CookiesOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CookiesOperator left, Azure.ResourceManager.Cdn.Models.CookiesOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CookiesOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CookiesOperator left, Azure.ResourceManager.Cdn.Models.CookiesOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CustomDomainHttpsOptions
    {
        public CustomDomainHttpsOptions(Azure.ResourceManager.Cdn.Models.ProtocolType protocolType) { }
        public Azure.ResourceManager.Cdn.Models.MinimumTlsVersion? MinimumTlsVersion { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ProtocolType ProtocolType { get { throw null; } }
    }
    public partial class CustomDomainOptions
    {
        public CustomDomainOptions() { }
        public string HostName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomDomainResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.CustomDomainResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomDomainResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CustomDomainResourceState Active { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomDomainResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomDomainResourceState Deleting { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CustomDomainResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CustomDomainResourceState left, Azure.ResourceManager.Cdn.Models.CustomDomainResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CustomDomainResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CustomDomainResourceState left, Azure.ResourceManager.Cdn.Models.CustomDomainResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomHttpsProvisioningState : System.IEquatable<Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomHttpsProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState Disabling { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState Enabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState Enabling { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState Failed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState left, Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState left, Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomHttpsProvisioningSubstate : System.IEquatable<Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomHttpsProvisioningSubstate(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate CertificateDeleted { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate CertificateDeployed { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate DeletingCertificate { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate DeployingCertificate { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate DomainControlValidationRequestApproved { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate DomainControlValidationRequestRejected { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate DomainControlValidationRequestTimedOut { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate IssuingCertificate { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate PendingDomainControlValidationREquestApproval { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate SubmittingDomainControlValidationRequest { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate left, Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate left, Azure.ResourceManager.Cdn.Models.CustomHttpsProvisioningSubstate right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CustomRule
    {
        public CustomRule(string name, int priority, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.MatchCondition> matchConditions, Azure.ResourceManager.Cdn.Models.ActionType action) { }
        public Azure.ResourceManager.Cdn.Models.ActionType Action { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState? EnabledState { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.MatchCondition> MatchConditions { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Priority { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomRuleEnabledState : System.IEquatable<Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomRuleEnabledState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState left, Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState left, Azure.ResourceManager.Cdn.Models.CustomRuleEnabledState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeepCreatedOrigin
    {
        public DeepCreatedOrigin(string name) { }
        public bool? Enabled { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public int? HttpPort { get { throw null; } set { } }
        public int? HttpsPort { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public string PrivateLinkAlias { get { throw null; } set { } }
        public string PrivateLinkApprovalMessage { get { throw null; } set { } }
        public string PrivateLinkLocation { get { throw null; } set { } }
        public string PrivateLinkResourceId { get { throw null; } set { } }
        public int? Weight { get { throw null; } set { } }
    }
    public partial class DeepCreatedOriginGroup
    {
        public DeepCreatedOriginGroup(string name) { }
        public Azure.ResourceManager.Cdn.Models.HealthProbeParameters HealthProbeSettings { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> Origins { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get { throw null; } set { } }
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get { throw null; } set { } }
    }
    public partial class DeliveryRule
    {
        public DeliveryRule(int order, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.DeliveryRuleAction> actions) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleAction> Actions { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition> Conditions { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
    }
    public partial class DeliveryRuleAction
    {
        public DeliveryRuleAction() { }
    }
    public partial class DeliveryRuleCacheExpirationAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public DeliveryRuleCacheExpirationAction(Azure.ResourceManager.Cdn.Models.CacheExpirationActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.CacheExpirationActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleCacheKeyQueryStringAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public DeliveryRuleCacheKeyQueryStringAction(Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.CacheKeyQueryStringActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleCondition
    {
        public DeliveryRuleCondition() { }
    }
    public partial class DeliveryRuleCookiesCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleCookiesCondition(Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.CookiesMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleHttpVersionCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleHttpVersionCondition(Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleIsDeviceCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleIsDeviceCondition(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRulePostArgsCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRulePostArgsCondition(Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleQueryStringCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleQueryStringCondition(Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRemoteAddressCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRemoteAddressCondition(Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestBodyCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRequestBodyCondition(Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestHeaderAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public DeliveryRuleRequestHeaderAction(Azure.ResourceManager.Cdn.Models.HeaderActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.HeaderActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestHeaderCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRequestHeaderCondition(Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestMethodCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRequestMethodCondition(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestSchemeCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRequestSchemeCondition(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleRequestUriCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleRequestUriCondition(Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleResponseHeaderAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public DeliveryRuleResponseHeaderAction(Azure.ResourceManager.Cdn.Models.HeaderActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.HeaderActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleUrlFileExtensionCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleUrlFileExtensionCondition(Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleUrlFileNameCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleUrlFileNameCondition(Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    public partial class DeliveryRuleUrlPathCondition : Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition
    {
        public DeliveryRuleUrlPathCondition(Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParameters Parameters { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeploymentStatus : System.IEquatable<Azure.ResourceManager.Cdn.Models.DeploymentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeploymentStatus(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.DeploymentStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DeploymentStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DeploymentStatus NotStarted { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DeploymentStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.DeploymentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.DeploymentStatus left, Azure.ResourceManager.Cdn.Models.DeploymentStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.DeploymentStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.DeploymentStatus left, Azure.ResourceManager.Cdn.Models.DeploymentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DestinationProtocol : System.IEquatable<Azure.ResourceManager.Cdn.Models.DestinationProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DestinationProtocol(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.DestinationProtocol Http { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DestinationProtocol Https { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DestinationProtocol MatchRequest { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.DestinationProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.DestinationProtocol left, Azure.ResourceManager.Cdn.Models.DestinationProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.DestinationProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.DestinationProtocol left, Azure.ResourceManager.Cdn.Models.DestinationProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DomainValidationProperties
    {
        internal DomainValidationProperties() { }
        public string ExpirationDate { get { throw null; } }
        public string ValidationToken { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainValidationState : System.IEquatable<Azure.ResourceManager.Cdn.Models.DomainValidationState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainValidationState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState Approved { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState Pending { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState PendingRevalidation { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState Submitting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState TimedOut { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.DomainValidationState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.DomainValidationState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.DomainValidationState left, Azure.ResourceManager.Cdn.Models.DomainValidationState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.DomainValidationState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.DomainValidationState left, Azure.ResourceManager.Cdn.Models.DomainValidationState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EdgeNode : Azure.ResourceManager.Models.ResourceData
    {
        public EdgeNode() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.IPAddressGroup> IPAddressGroups { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnabledState : System.IEquatable<Azure.ResourceManager.Cdn.Models.EnabledState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnabledState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.EnabledState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EnabledState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.EnabledState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.EnabledState left, Azure.ResourceManager.Cdn.Models.EnabledState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.EnabledState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.EnabledState left, Azure.ResourceManager.Cdn.Models.EnabledState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EndpointPropertiesUpdateParametersDeliveryPolicy
    {
        public EndpointPropertiesUpdateParametersDeliveryPolicy(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.DeliveryRule> rules) { }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRule> Rules { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EndpointResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.EndpointResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EndpointResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Running { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Starting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Stopped { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.EndpointResourceState Stopping { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.EndpointResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.EndpointResourceState left, Azure.ResourceManager.Cdn.Models.EndpointResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.EndpointResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.EndpointResourceState left, Azure.ResourceManager.Cdn.Models.EndpointResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ForwardingProtocol : System.IEquatable<Azure.ResourceManager.Cdn.Models.ForwardingProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ForwardingProtocol(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ForwardingProtocol HttpOnly { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ForwardingProtocol HttpsOnly { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ForwardingProtocol MatchRequest { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ForwardingProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ForwardingProtocol left, Azure.ResourceManager.Cdn.Models.ForwardingProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ForwardingProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ForwardingProtocol left, Azure.ResourceManager.Cdn.Models.ForwardingProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GeoFilter
    {
        public GeoFilter(string relativePath, Azure.ResourceManager.Cdn.Models.GeoFilterActions action, System.Collections.Generic.IEnumerable<string> countryCodes) { }
        public Azure.ResourceManager.Cdn.Models.GeoFilterActions Action { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> CountryCodes { get { throw null; } }
        public string RelativePath { get { throw null; } set { } }
    }
    public enum GeoFilterActions
    {
        Block = 0,
        Allow = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HeaderAction : System.IEquatable<Azure.ResourceManager.Cdn.Models.HeaderAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HeaderAction(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.HeaderAction Append { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.HeaderAction Delete { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.HeaderAction Overwrite { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.HeaderAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.HeaderAction left, Azure.ResourceManager.Cdn.Models.HeaderAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.HeaderAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.HeaderAction left, Azure.ResourceManager.Cdn.Models.HeaderAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HeaderActionParameters
    {
        public HeaderActionParameters(Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.HeaderAction headerAction, string headerName) { }
        public Azure.ResourceManager.Cdn.Models.HeaderAction HeaderAction { get { throw null; } set { } }
        public string HeaderName { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType OdataType { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HeaderActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HeaderActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleHeaderActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.HeaderActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HealthProbeParameters
    {
        public HealthProbeParameters() { }
        public int? ProbeIntervalInSeconds { get { throw null; } set { } }
        public string ProbePath { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ProbeProtocol? ProbeProtocol { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HealthProbeRequestType? ProbeRequestType { get { throw null; } set { } }
    }
    public enum HealthProbeRequestType
    {
        NotSet = 0,
        GET = 1,
        Head = 2,
    }
    public partial class HttpErrorRangeParameters
    {
        public HttpErrorRangeParameters() { }
        public int? Begin { get { throw null; } set { } }
        public int? End { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpsRedirect : System.IEquatable<Azure.ResourceManager.Cdn.Models.HttpsRedirect>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpsRedirect(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.HttpsRedirect Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.HttpsRedirect Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.HttpsRedirect other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.HttpsRedirect left, Azure.ResourceManager.Cdn.Models.HttpsRedirect right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.HttpsRedirect (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.HttpsRedirect left, Azure.ResourceManager.Cdn.Models.HttpsRedirect right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HttpVersionMatchConditionParameters
    {
        public HttpVersionMatchConditionParameters(Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.HttpVersionOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HttpVersionOperator Operator { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpVersionMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpVersionMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleHttpVersionConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.HttpVersionMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpVersionOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.HttpVersionOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpVersionOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.HttpVersionOperator Equal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.HttpVersionOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.HttpVersionOperator left, Azure.ResourceManager.Cdn.Models.HttpVersionOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.HttpVersionOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.HttpVersionOperator left, Azure.ResourceManager.Cdn.Models.HttpVersionOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IPAddressGroup
    {
        public IPAddressGroup() { }
        public string DeliveryRegion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.CidrIPAddress> IPv4Addresses { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.CidrIPAddress> IPv6Addresses { get { throw null; } }
    }
    public partial class IsDeviceMatchConditionParameters
    {
        public IsDeviceMatchConditionParameters(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.IsDeviceOperator @operator) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.IsDeviceOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IsDeviceMatchConditionParametersMatchValuesItem : System.IEquatable<Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IsDeviceMatchConditionParametersMatchValuesItem(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem Desktop { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem Mobile { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersMatchValuesItem right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IsDeviceMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IsDeviceMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleIsDeviceConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.IsDeviceMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IsDeviceOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.IsDeviceOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IsDeviceOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.IsDeviceOperator Equal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.IsDeviceOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.IsDeviceOperator left, Azure.ResourceManager.Cdn.Models.IsDeviceOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.IsDeviceOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.IsDeviceOperator left, Azure.ResourceManager.Cdn.Models.IsDeviceOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyVaultSigningKeyParameters
    {
        public KeyVaultSigningKeyParameters(Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType odataType, string subscriptionId, string resourceGroupName, string vaultName, string secretName, string secretVersion) { }
        public Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType OdataType { get { throw null; } set { } }
        public string ResourceGroupName { get { throw null; } set { } }
        public string SecretName { get { throw null; } set { } }
        public string SecretVersion { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string VaultName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct KeyVaultSigningKeyParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public KeyVaultSigningKeyParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType MicrosoftAzureCdnModelsKeyVaultSigningKeyParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType left, Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType left, Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkToDefaultDomain : System.IEquatable<Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkToDefaultDomain(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain left, Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain left, Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoadBalancingSettingsParameters
    {
        public LoadBalancingSettingsParameters() { }
        public int? AdditionalLatencyInMilliseconds { get { throw null; } set { } }
        public int? SampleSize { get { throw null; } set { } }
        public int? SuccessfulSamplesRequired { get { throw null; } set { } }
    }
    public partial class LoadOptions
    {
        public LoadOptions(System.Collections.Generic.IEnumerable<string> contentPaths) { }
        public System.Collections.Generic.IList<string> ContentPaths { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogMetric : System.IEquatable<Azure.ResourceManager.Cdn.Models.LogMetric>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogMetric(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LogMetric ClientRequestBandwidth { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetric ClientRequestCount { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetric ClientRequestTraffic { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetric OriginRequestBandwidth { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetric OriginRequestTraffic { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetric TotalLatency { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LogMetric other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LogMetric left, Azure.ResourceManager.Cdn.Models.LogMetric right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LogMetric (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LogMetric left, Azure.ResourceManager.Cdn.Models.LogMetric right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogMetricsGranularity : System.IEquatable<Azure.ResourceManager.Cdn.Models.LogMetricsGranularity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogMetricsGranularity(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGranularity P1D { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGranularity PT1H { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGranularity PT5M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LogMetricsGranularity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LogMetricsGranularity left, Azure.ResourceManager.Cdn.Models.LogMetricsGranularity right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LogMetricsGranularity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LogMetricsGranularity left, Azure.ResourceManager.Cdn.Models.LogMetricsGranularity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogMetricsGroupBy : System.IEquatable<Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogMetricsGroupBy(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy CacheStatus { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy Country { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy CustomDomain { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy HttpStatusCode { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy Protocol { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy left, Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy left, Azure.ResourceManager.Cdn.Models.LogMetricsGroupBy right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogRanking : System.IEquatable<Azure.ResourceManager.Cdn.Models.LogRanking>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogRanking(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LogRanking Browser { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRanking CountryOrRegion { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRanking Referrer { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRanking Url { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRanking UserAgent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LogRanking other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LogRanking left, Azure.ResourceManager.Cdn.Models.LogRanking right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LogRanking (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LogRanking left, Azure.ResourceManager.Cdn.Models.LogRanking right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogRankingMetric : System.IEquatable<Azure.ResourceManager.Cdn.Models.LogRankingMetric>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogRankingMetric(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric ClientRequestCount { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric ClientRequestTraffic { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric ErrorCount { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric HitCount { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric MissCount { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.LogRankingMetric UserErrorCount { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.LogRankingMetric other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.LogRankingMetric left, Azure.ResourceManager.Cdn.Models.LogRankingMetric right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.LogRankingMetric (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.LogRankingMetric left, Azure.ResourceManager.Cdn.Models.LogRankingMetric right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedRuleDefinition
    {
        internal ManagedRuleDefinition() { }
        public string Description { get { throw null; } }
        public string RuleId { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedRuleEnabledState : System.IEquatable<Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedRuleEnabledState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState left, Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState left, Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedRuleGroupDefinition
    {
        internal ManagedRuleGroupDefinition() { }
        public string Description { get { throw null; } }
        public string RuleGroupName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ManagedRuleDefinition> Rules { get { throw null; } }
    }
    public partial class ManagedRuleGroupOverride
    {
        public ManagedRuleGroupOverride(string ruleGroupName) { }
        public string RuleGroupName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.ManagedRuleOverride> Rules { get { throw null; } }
    }
    public partial class ManagedRuleOverride
    {
        public ManagedRuleOverride(string ruleId) { }
        public Azure.ResourceManager.Cdn.Models.ActionType? Action { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ManagedRuleEnabledState? EnabledState { get { throw null; } set { } }
        public string RuleId { get { throw null; } set { } }
    }
    public partial class ManagedRuleSet
    {
        public ManagedRuleSet(string ruleSetType, string ruleSetVersion) { }
        public int? AnomalyScore { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.ManagedRuleGroupOverride> RuleGroupOverrides { get { throw null; } }
        public string RuleSetType { get { throw null; } set { } }
        public string RuleSetVersion { get { throw null; } set { } }
    }
    public partial class ManagedRuleSetDefinition : Azure.ResourceManager.Models.ResourceData
    {
        public ManagedRuleSetDefinition() { }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ManagedRuleGroupDefinition> RuleGroups { get { throw null; } }
        public string RuleSetType { get { throw null; } }
        public string RuleSetVersion { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.CdnSkuName? SkuName { get { throw null; } set { } }
    }
    public partial class MatchCondition
    {
        public MatchCondition(Azure.ResourceManager.Cdn.Models.MatchVariable matchVariable, Azure.ResourceManager.Cdn.Models.MatchOperator @operator, System.Collections.Generic.IEnumerable<string> matchValue) { }
        public System.Collections.Generic.IList<string> MatchValue { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.MatchVariable MatchVariable { get { throw null; } set { } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.MatchOperator Operator { get { throw null; } set { } }
        public string Selector { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformType> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MatchOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.MatchOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MatchOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator GeoMatch { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator IPMatch { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.MatchOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.MatchOperator left, Azure.ResourceManager.Cdn.Models.MatchOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.MatchOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.MatchOperator left, Azure.ResourceManager.Cdn.Models.MatchOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MatchProcessingBehavior : System.IEquatable<Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MatchProcessingBehavior(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior Continue { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior Stop { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior left, Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior left, Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MatchVariable : System.IEquatable<Azure.ResourceManager.Cdn.Models.MatchVariable>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MatchVariable(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable Cookies { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable HttpVersion { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable IsDevice { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable PostArgs { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable QueryString { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RemoteAddr { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RemoteAddress { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RequestBody { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RequestHeader { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RequestMethod { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RequestScheme { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable RequestUri { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable SocketAddr { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable UrlFileExtension { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable UrlFileName { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MatchVariable UrlPath { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.MatchVariable other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.MatchVariable left, Azure.ResourceManager.Cdn.Models.MatchVariable right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.MatchVariable (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.MatchVariable left, Azure.ResourceManager.Cdn.Models.MatchVariable right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricsResponse
    {
        internal MetricsResponse() { }
        public System.DateTimeOffset? DateTimeBegin { get { throw null; } }
        public System.DateTimeOffset? DateTimeEnd { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity? Granularity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItem> Series { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MetricsResponseGranularity : System.IEquatable<Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MetricsResponseGranularity(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity P1D { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity PT1H { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity PT5M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity left, Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity left, Azure.ResourceManager.Cdn.Models.MetricsResponseGranularity right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricsResponseSeriesItem
    {
        internal MetricsResponseSeriesItem() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> Data { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesPropertiesItemsItem> Groups { get { throw null; } }
        public string Metric { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit? Unit { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MetricsResponseSeriesItemUnit : System.IEquatable<Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MetricsResponseSeriesItemUnit(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit BitsPerSecond { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit Bytes { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit Count { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit left, Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit left, Azure.ResourceManager.Cdn.Models.MetricsResponseSeriesItemUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricsResponseSeriesPropertiesItemsItem
    {
        internal MetricsResponseSeriesPropertiesItemsItem() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public enum MinimumTlsVersion
    {
        None = 0,
        TLS10 = 1,
        TLS12 = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OptimizationType : System.IEquatable<Azure.ResourceManager.Cdn.Models.OptimizationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OptimizationType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.OptimizationType DynamicSiteAcceleration { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OptimizationType GeneralMediaStreaming { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OptimizationType GeneralWebDelivery { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OptimizationType LargeFileDownload { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OptimizationType VideoOnDemandMediaStreaming { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.OptimizationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.OptimizationType left, Azure.ResourceManager.Cdn.Models.OptimizationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.OptimizationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.OptimizationType left, Azure.ResourceManager.Cdn.Models.OptimizationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OriginGroupOverrideAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public OriginGroupOverrideAction(Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class OriginGroupOverrideActionParameters
    {
        public OriginGroupOverrideActionParameters(Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType odataType, Azure.ResourceManager.Resources.Models.WritableSubResource originGroup) { }
        public Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier OriginGroupId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OriginGroupOverrideActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OriginGroupOverrideActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleOriginGroupOverrideActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.OriginGroupOverrideActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OriginGroupResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.OriginGroupResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OriginGroupResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.OriginGroupResourceState Active { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OriginGroupResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OriginGroupResourceState Deleting { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.OriginGroupResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.OriginGroupResourceState left, Azure.ResourceManager.Cdn.Models.OriginGroupResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.OriginGroupResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.OriginGroupResourceState left, Azure.ResourceManager.Cdn.Models.OriginGroupResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OriginResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.OriginResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OriginResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.OriginResourceState Active { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OriginResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.OriginResourceState Deleting { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.OriginResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.OriginResourceState left, Azure.ResourceManager.Cdn.Models.OriginResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.OriginResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.OriginResourceState left, Azure.ResourceManager.Cdn.Models.OriginResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ParamIndicator : System.IEquatable<Azure.ResourceManager.Cdn.Models.ParamIndicator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ParamIndicator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ParamIndicator Expires { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ParamIndicator KeyId { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ParamIndicator Signature { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ParamIndicator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ParamIndicator left, Azure.ResourceManager.Cdn.Models.ParamIndicator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ParamIndicator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ParamIndicator left, Azure.ResourceManager.Cdn.Models.ParamIndicator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PatchableAfdCustomDomainData
    {
        public PatchableAfdCustomDomainData() { }
        public Azure.Core.ResourceIdentifier AzureDnsZoneId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.AfdCustomDomainHttpsParameters TlsSettings { get { throw null; } set { } }
    }
    public partial class PatchableAfdEndpointData
    {
        public PatchableAfdEndpointData() { }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public int? OriginResponseTimeoutSeconds { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class PatchableAfdOriginData
    {
        public PatchableAfdOriginData() { }
        public Azure.Core.ResourceIdentifier AzureOriginId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public int? HttpPort { get { throw null; } set { } }
        public int? HttpsPort { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public object SharedPrivateLinkResource { get { throw null; } set { } }
        public int? Weight { get { throw null; } set { } }
    }
    public partial class PatchableAfdOriginGroupData
    {
        public PatchableAfdOriginGroupData() { }
        public Azure.ResourceManager.Cdn.Models.HealthProbeParameters HealthProbeSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.LoadBalancingSettingsParameters LoadBalancingSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedOriginErrorDetectionParameters ResponseBasedAfdOriginErrorDetectionSettings { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? SessionAffinityState { get { throw null; } set { } }
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get { throw null; } set { } }
    }
    public partial class PatchableAfdRouteData
    {
        public PatchableAfdRouteData() { }
        public object CompressionSettings { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> CustomDomains { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.EnabledState? EnabledState { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.ForwardingProtocol? ForwardingProtocol { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.HttpsRedirect? HttpsRedirect { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.LinkToDefaultDomain? LinkToDefaultDomain { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier OriginGroupId { get { throw null; } set { } }
        public string OriginPath { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> PatternsToMatch { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.AfdQueryStringCachingBehavior? QueryStringCachingBehavior { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> RuleSets { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.AfdEndpointProtocols> SupportedProtocols { get { throw null; } }
    }
    public partial class PatchableAfdRuleData
    {
        public PatchableAfdRuleData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleAction> Actions { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.DeliveryRuleCondition> Conditions { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.MatchProcessingBehavior? MatchProcessingBehavior { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
    }
    public partial class PatchableAfdSecurityPolicyData : Azure.ResourceManager.Cdn.Models.AfdStateProperties
    {
        public PatchableAfdSecurityPolicyData() { }
        public Azure.ResourceManager.Cdn.Models.SecurityPolicyParameters Parameters { get { throw null; } set { } }
    }
    public partial class PatchableCdnEndpointData
    {
        public PatchableCdnEndpointData() { }
        public System.Collections.Generic.IList<string> ContentTypesToCompress { get { throw null; } }
        public string DefaultOriginGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.EndpointPropertiesUpdateParametersDeliveryPolicy DeliveryPolicy { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.GeoFilter> GeoFilters { get { throw null; } }
        public bool? IsCompressionEnabled { get { throw null; } set { } }
        public bool? IsHttpAllowed { get { throw null; } set { } }
        public bool? IsHttpsAllowed { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.OptimizationType? OptimizationType { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public string OriginPath { get { throw null; } set { } }
        public string ProbePath { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.QueryStringCachingBehavior? QueryStringCachingBehavior { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.UrlSigningKey> UrlSigningKeys { get { throw null; } set { } }
        public string WebApplicationFirewallPolicyLinkId { get { throw null; } set { } }
    }
    public partial class PatchableCdnOriginData
    {
        public PatchableCdnOriginData() { }
        public bool? Enabled { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public int? HttpPort { get { throw null; } set { } }
        public int? HttpsPort { get { throw null; } set { } }
        public string OriginHostHeader { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public string PrivateLinkAlias { get { throw null; } set { } }
        public string PrivateLinkApprovalMessage { get { throw null; } set { } }
        public string PrivateLinkLocation { get { throw null; } set { } }
        public string PrivateLinkResourceId { get { throw null; } set { } }
        public int? Weight { get { throw null; } set { } }
    }
    public partial class PatchableCdnOriginGroupData
    {
        public PatchableCdnOriginGroupData() { }
        public Azure.ResourceManager.Cdn.Models.HealthProbeParameters HealthProbeSettings { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> Origins { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get { throw null; } set { } }
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyEnabledState : System.IEquatable<Azure.ResourceManager.Cdn.Models.PolicyEnabledState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyEnabledState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PolicyEnabledState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyEnabledState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PolicyEnabledState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PolicyEnabledState left, Azure.ResourceManager.Cdn.Models.PolicyEnabledState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PolicyEnabledState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PolicyEnabledState left, Azure.ResourceManager.Cdn.Models.PolicyEnabledState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyMode : System.IEquatable<Azure.ResourceManager.Cdn.Models.PolicyMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyMode(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PolicyMode Detection { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyMode Prevention { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PolicyMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PolicyMode left, Azure.ResourceManager.Cdn.Models.PolicyMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PolicyMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PolicyMode left, Azure.ResourceManager.Cdn.Models.PolicyMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.PolicyResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Disabling { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Enabled { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicyResourceState Enabling { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PolicyResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PolicyResourceState left, Azure.ResourceManager.Cdn.Models.PolicyResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PolicyResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PolicyResourceState left, Azure.ResourceManager.Cdn.Models.PolicyResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PolicySettings
    {
        public PolicySettings() { }
        public string DefaultCustomBlockResponseBody { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode? DefaultCustomBlockResponseStatusCode { get { throw null; } set { } }
        public string DefaultRedirectUrl { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PolicyEnabledState? EnabledState { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PolicyMode? Mode { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicySettingsDefaultCustomBlockResponseStatusCode : System.IEquatable<Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode>
    {
        private readonly int _dummyPrimitive;
        public PolicySettingsDefaultCustomBlockResponseStatusCode(int value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode FourHundredFive { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode FourHundredSix { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode FourHundredThree { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode FourHundredTwentyNine { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode TwoHundred { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode left, Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode (int value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode left, Azure.ResourceManager.Cdn.Models.PolicySettingsDefaultCustomBlockResponseStatusCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PostArgsMatchConditionParameters
    {
        public PostArgsMatchConditionParameters(Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.PostArgsOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.PostArgsOperator Operator { get { throw null; } set { } }
        public string Selector { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PostArgsMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PostArgsMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRulePostArgsConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.PostArgsMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PostArgsOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.PostArgsOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PostArgsOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PostArgsOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PostArgsOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PostArgsOperator left, Azure.ResourceManager.Cdn.Models.PostArgsOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PostArgsOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PostArgsOperator left, Azure.ResourceManager.Cdn.Models.PostArgsOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateEndpointStatus : System.IEquatable<Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateEndpointStatus(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus Rejected { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus Timeout { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus left, Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus left, Azure.ResourceManager.Cdn.Models.PrivateEndpointStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ProbeProtocol
    {
        NotSet = 0,
        Http = 1,
        Https = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProfileResourceState : System.IEquatable<Azure.ResourceManager.Cdn.Models.ProfileResourceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProfileResourceState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ProfileResourceState Active { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProfileResourceState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProfileResourceState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProfileResourceState Disabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ProfileResourceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ProfileResourceState left, Azure.ResourceManager.Cdn.Models.ProfileResourceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ProfileResourceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ProfileResourceState left, Azure.ResourceManager.Cdn.Models.ProfileResourceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProtocolType : System.IEquatable<Azure.ResourceManager.Cdn.Models.ProtocolType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProtocolType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ProtocolType IPBased { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProtocolType ServerNameIndication { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ProtocolType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ProtocolType left, Azure.ResourceManager.Cdn.Models.ProtocolType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ProtocolType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ProtocolType left, Azure.ResourceManager.Cdn.Models.ProtocolType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Cdn.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.ProvisioningState left, Azure.ResourceManager.Cdn.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.ProvisioningState left, Azure.ResourceManager.Cdn.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PurgeOptions
    {
        public PurgeOptions(System.Collections.Generic.IEnumerable<string> contentPaths) { }
        public System.Collections.Generic.IList<string> ContentPaths { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QueryStringBehavior : System.IEquatable<Azure.ResourceManager.Cdn.Models.QueryStringBehavior>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QueryStringBehavior(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.QueryStringBehavior Exclude { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringBehavior ExcludeAll { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringBehavior Include { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringBehavior IncludeAll { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.QueryStringBehavior other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.QueryStringBehavior left, Azure.ResourceManager.Cdn.Models.QueryStringBehavior right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.QueryStringBehavior (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.QueryStringBehavior left, Azure.ResourceManager.Cdn.Models.QueryStringBehavior right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum QueryStringCachingBehavior
    {
        NotSet = 0,
        IgnoreQueryString = 1,
        BypassCaching = 2,
        UseQueryString = 3,
    }
    public partial class QueryStringMatchConditionParameters
    {
        public QueryStringMatchConditionParameters(Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.QueryStringOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.QueryStringOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QueryStringMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QueryStringMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleQueryStringConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.QueryStringMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QueryStringOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.QueryStringOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QueryStringOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.QueryStringOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.QueryStringOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.QueryStringOperator left, Azure.ResourceManager.Cdn.Models.QueryStringOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.QueryStringOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.QueryStringOperator left, Azure.ResourceManager.Cdn.Models.QueryStringOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RankingsResponse
    {
        internal RankingsResponse() { }
        public System.DateTimeOffset? DateTimeBegin { get { throw null; } }
        public System.DateTimeOffset? DateTimeEnd { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.RankingsResponseTablesItem> Tables { get { throw null; } }
    }
    public partial class RankingsResponseTablesItem
    {
        internal RankingsResponseTablesItem() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.RankingsResponseTablesPropertiesItemsItem> Data { get { throw null; } }
        public string Ranking { get { throw null; } }
    }
    public partial class RankingsResponseTablesPropertiesItemsItem
    {
        internal RankingsResponseTablesPropertiesItemsItem() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.RankingsResponseTablesPropertiesItemsMetricsItem> Metrics { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class RankingsResponseTablesPropertiesItemsMetricsItem
    {
        internal RankingsResponseTablesPropertiesItemsMetricsItem() { }
        public string Metric { get { throw null; } }
        public float? Percentage { get { throw null; } }
        public long? Value { get { throw null; } }
    }
    public partial class RateLimitRule : Azure.ResourceManager.Cdn.Models.CustomRule
    {
        public RateLimitRule(string name, int priority, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.MatchCondition> matchConditions, Azure.ResourceManager.Cdn.Models.ActionType action, int rateLimitThreshold, int rateLimitDurationInMinutes) : base (default(string), default(int), default(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cdn.Models.MatchCondition>), default(Azure.ResourceManager.Cdn.Models.ActionType)) { }
        public int RateLimitDurationInMinutes { get { throw null; } set { } }
        public int RateLimitThreshold { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RedirectType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RedirectType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RedirectType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RedirectType Found { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RedirectType Moved { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RedirectType PermanentRedirect { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RedirectType TemporaryRedirect { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RedirectType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RedirectType left, Azure.ResourceManager.Cdn.Models.RedirectType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RedirectType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RedirectType left, Azure.ResourceManager.Cdn.Models.RedirectType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RemoteAddressMatchConditionParameters
    {
        public RemoteAddressMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RemoteAddressOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RemoteAddressOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RemoteAddressMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RemoteAddressMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRemoteAddressConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RemoteAddressMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RemoteAddressOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RemoteAddressOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RemoteAddressOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RemoteAddressOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RemoteAddressOperator GeoMatch { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RemoteAddressOperator IPMatch { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RemoteAddressOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RemoteAddressOperator left, Azure.ResourceManager.Cdn.Models.RemoteAddressOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RemoteAddressOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RemoteAddressOperator left, Azure.ResourceManager.Cdn.Models.RemoteAddressOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestBodyMatchConditionParameters
    {
        public RequestBodyMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RequestBodyOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestBodyOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestBodyMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestBodyMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestBodyConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestBodyMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestBodyOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestBodyOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestBodyOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestBodyOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestBodyOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestBodyOperator left, Azure.ResourceManager.Cdn.Models.RequestBodyOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestBodyOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestBodyOperator left, Azure.ResourceManager.Cdn.Models.RequestBodyOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestHeaderMatchConditionParameters
    {
        public RequestHeaderMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RequestHeaderOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestHeaderOperator Operator { get { throw null; } set { } }
        public string Selector { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestHeaderMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestHeaderMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestHeaderConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestHeaderMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestHeaderOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestHeaderOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestHeaderOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestHeaderOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestHeaderOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestHeaderOperator left, Azure.ResourceManager.Cdn.Models.RequestHeaderOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestHeaderOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestHeaderOperator left, Azure.ResourceManager.Cdn.Models.RequestHeaderOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestMethodMatchConditionParameters
    {
        public RequestMethodMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RequestMethodOperator @operator) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestMethodOperator Operator { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestMethodMatchConditionParametersMatchValuesItem : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestMethodMatchConditionParametersMatchValuesItem(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem Delete { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem GET { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem Head { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem Options { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem Post { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem PUT { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem Trace { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersMatchValuesItem right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestMethodMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestMethodMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestMethodConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestMethodMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestMethodOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestMethodOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestMethodOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestMethodOperator Equal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestMethodOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestMethodOperator left, Azure.ResourceManager.Cdn.Models.RequestMethodOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestMethodOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestMethodOperator left, Azure.ResourceManager.Cdn.Models.RequestMethodOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestSchemeMatchConditionParameters
    {
        public RequestSchemeMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator @operator) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator Operator { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestSchemeMatchConditionParametersMatchValuesItem : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestSchemeMatchConditionParametersMatchValuesItem(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem Http { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem Https { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersMatchValuesItem right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestSchemeMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestSchemeMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestSchemeConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestSchemeMatchConditionParametersOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestSchemeMatchConditionParametersOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator Equal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator left, Azure.ResourceManager.Cdn.Models.RequestSchemeMatchConditionParametersOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestUriMatchConditionParameters
    {
        public RequestUriMatchConditionParameters(Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RequestUriOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RequestUriOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestUriMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestUriMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestUriConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.RequestUriMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RequestUriOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.RequestUriOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RequestUriOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.RequestUriOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.RequestUriOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.RequestUriOperator left, Azure.ResourceManager.Cdn.Models.RequestUriOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.RequestUriOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.RequestUriOperator left, Azure.ResourceManager.Cdn.Models.RequestUriOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourcesResponse
    {
        internal ResourcesResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ResourcesResponseCustomDomainsItem> CustomDomains { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ResourcesResponseEndpointsItem> Endpoints { get { throw null; } }
    }
    public partial class ResourcesResponseCustomDomainsItem
    {
        internal ResourcesResponseCustomDomainsItem() { }
        public string EndpointId { get { throw null; } }
        public bool? History { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class ResourcesResponseEndpointsItem
    {
        internal ResourcesResponseEndpointsItem() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ResourcesResponseEndpointsPropertiesItemsItem> CustomDomains { get { throw null; } }
        public bool? History { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class ResourcesResponseEndpointsPropertiesItemsItem
    {
        internal ResourcesResponseEndpointsPropertiesItemsItem() { }
        public string EndpointId { get { throw null; } }
        public bool? History { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class ResourceUsage
    {
        internal ResourceUsage() { }
        public int? CurrentValue { get { throw null; } }
        public int? Limit { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string Unit { get { throw null; } }
    }
    public enum ResponseBasedDetectedErrorTypes
    {
        None = 0,
        TcpErrorsOnly = 1,
        TcpAndHttpErrors = 2,
    }
    public partial class ResponseBasedOriginErrorDetectionParameters
    {
        public ResponseBasedOriginErrorDetectionParameters() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.HttpErrorRangeParameters> HttpErrorRanges { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.ResponseBasedDetectedErrorTypes? ResponseBasedDetectedErrorTypes { get { throw null; } set { } }
        public int? ResponseBasedFailoverThresholdPercentage { get { throw null; } set { } }
    }
    public partial class SecurityPolicyParameters
    {
        public SecurityPolicyParameters() { }
    }
    public partial class SecurityPolicyWebApplicationFirewallAssociation
    {
        public SecurityPolicyWebApplicationFirewallAssociation() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> Domains { get { throw null; } }
        public System.Collections.Generic.IList<string> PatternsToMatch { get { throw null; } }
    }
    public partial class SecurityPolicyWebApplicationFirewallParameters : Azure.ResourceManager.Cdn.Models.SecurityPolicyParameters
    {
        public SecurityPolicyWebApplicationFirewallParameters() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.SecurityPolicyWebApplicationFirewallAssociation> Associations { get { throw null; } }
        public Azure.Core.ResourceIdentifier WafPolicyId { get { throw null; } set { } }
    }
    public partial class SsoUri
    {
        internal SsoUri() { }
        public string SsoUriValue { get { throw null; } }
    }
    public partial class SupportedOptimizationTypesListResult
    {
        internal SupportedOptimizationTypesListResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.OptimizationType> SupportedOptimizationTypes { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TransformCategory : System.IEquatable<Azure.ResourceManager.Cdn.Models.TransformCategory>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TransformCategory(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.TransformCategory Lowercase { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformCategory Uppercase { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.TransformCategory other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.TransformCategory left, Azure.ResourceManager.Cdn.Models.TransformCategory right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.TransformCategory (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.TransformCategory left, Azure.ResourceManager.Cdn.Models.TransformCategory right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TransformType : System.IEquatable<Azure.ResourceManager.Cdn.Models.TransformType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TransformType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.TransformType Lowercase { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformType RemoveNulls { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformType Trim { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformType Uppercase { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformType UrlDecode { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.TransformType UrlEncode { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.TransformType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.TransformType left, Azure.ResourceManager.Cdn.Models.TransformType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.TransformType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.TransformType left, Azure.ResourceManager.Cdn.Models.TransformType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlFileExtensionMatchConditionParameters
    {
        public UrlFileExtensionMatchConditionParameters(Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlFileExtensionMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlFileExtensionMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlFileExtensionMatchConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlFileExtensionMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlFileExtensionOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlFileExtensionOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator left, Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator left, Azure.ResourceManager.Cdn.Models.UrlFileExtensionOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlFileNameMatchConditionParameters
    {
        public UrlFileNameMatchConditionParameters(Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.UrlFileNameOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlFileNameOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlFileNameMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlFileNameMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlFilenameConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlFileNameMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlFileNameOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlFileNameOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlFileNameOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlFileNameOperator RegEx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlFileNameOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlFileNameOperator left, Azure.ResourceManager.Cdn.Models.UrlFileNameOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlFileNameOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlFileNameOperator left, Azure.ResourceManager.Cdn.Models.UrlFileNameOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlPathMatchConditionParameters
    {
        public UrlPathMatchConditionParameters(Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.UrlPathOperator @operator) { }
        public System.Collections.Generic.IList<string> MatchValues { get { throw null; } }
        public bool? NegateCondition { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlPathOperator Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.TransformCategory> Transforms { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlPathMatchConditionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlPathMatchConditionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlPathMatchConditionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlPathMatchConditionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlPathOperator : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlPathOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlPathOperator(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator Any { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator BeginsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator Contains { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator EndsWith { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator Equal { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator LessThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator RegEx { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.UrlPathOperator Wildcard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlPathOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlPathOperator left, Azure.ResourceManager.Cdn.Models.UrlPathOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlPathOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlPathOperator left, Azure.ResourceManager.Cdn.Models.UrlPathOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlRedirectAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public UrlRedirectAction(Azure.ResourceManager.Cdn.Models.UrlRedirectActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlRedirectActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class UrlRedirectActionParameters
    {
        public UrlRedirectActionParameters(Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType odataType, Azure.ResourceManager.Cdn.Models.RedirectType redirectType) { }
        public string CustomFragment { get { throw null; } set { } }
        public string CustomHostname { get { throw null; } set { } }
        public string CustomPath { get { throw null; } set { } }
        public string CustomQueryString { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.DestinationProtocol? DestinationProtocol { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType OdataType { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.RedirectType RedirectType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlRedirectActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlRedirectActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlRedirectActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlRedirectActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlRewriteAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public UrlRewriteAction(Azure.ResourceManager.Cdn.Models.UrlRewriteActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlRewriteActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class UrlRewriteActionParameters
    {
        public UrlRewriteActionParameters(Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType odataType, string sourcePattern, string destination) { }
        public string Destination { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType OdataType { get { throw null; } set { } }
        public bool? PreserveUnmatchedPath { get { throw null; } set { } }
        public string SourcePattern { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlRewriteActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlRewriteActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlRewriteActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlRewriteActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlSigningAction : Azure.ResourceManager.Cdn.Models.DeliveryRuleAction
    {
        public UrlSigningAction(Azure.ResourceManager.Cdn.Models.UrlSigningActionParameters parameters) { }
        public Azure.ResourceManager.Cdn.Models.UrlSigningActionParameters Parameters { get { throw null; } set { } }
    }
    public partial class UrlSigningActionParameters
    {
        public UrlSigningActionParameters(Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType odataType) { }
        public Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm? Algorithm { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType OdataType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cdn.Models.UrlSigningParamIdentifier> ParameterNameOverride { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlSigningActionParametersOdataType : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlSigningActionParametersOdataType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleUrlSigningActionParameters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType left, Azure.ResourceManager.Cdn.Models.UrlSigningActionParametersOdataType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UrlSigningAlgorithm : System.IEquatable<Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UrlSigningAlgorithm(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm SHA256 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm left, Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm left, Azure.ResourceManager.Cdn.Models.UrlSigningAlgorithm right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UrlSigningKey
    {
        public UrlSigningKey(string keyId, Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParameters keySourceParameters) { }
        public string KeyId { get { throw null; } set { } }
        public Azure.ResourceManager.Cdn.Models.KeyVaultSigningKeyParameters KeySourceParameters { get { throw null; } set { } }
    }
    public partial class UrlSigningParamIdentifier
    {
        public UrlSigningParamIdentifier(Azure.ResourceManager.Cdn.Models.ParamIndicator paramIndicator, string paramName) { }
        public Azure.ResourceManager.Cdn.Models.ParamIndicator ParamIndicator { get { throw null; } set { } }
        public string ParamName { get { throw null; } set { } }
    }
    public partial class UsageName
    {
        internal UsageName() { }
        public string LocalizedValue { get { throw null; } }
        public string Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UsageUnit : System.IEquatable<Azure.ResourceManager.Cdn.Models.UsageUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UsageUnit(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.UsageUnit Count { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.UsageUnit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.UsageUnit left, Azure.ResourceManager.Cdn.Models.UsageUnit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.UsageUnit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.UsageUnit left, Azure.ResourceManager.Cdn.Models.UsageUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ValidateCustomDomainInput
    {
        public ValidateCustomDomainInput(string hostName) { }
        public string HostName { get { throw null; } }
    }
    public partial class ValidateCustomDomainOutput
    {
        internal ValidateCustomDomainOutput() { }
        public bool? CustomDomainValidated { get { throw null; } }
        public string Message { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    public partial class ValidateProbeInput
    {
        public ValidateProbeInput(string probeURL) { }
        public string ProbeURL { get { throw null; } }
    }
    public partial class ValidateProbeOutput
    {
        internal ValidateProbeOutput() { }
        public string ErrorCode { get { throw null; } }
        public bool? IsValid { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class ValidationToken
    {
        internal ValidationToken() { }
        public string Token { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafAction : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafAction(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafAction Allow { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafAction Block { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafAction Log { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafAction Redirect { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafAction left, Azure.ResourceManager.Cdn.Models.WafAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafAction left, Azure.ResourceManager.Cdn.Models.WafAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafGranularity : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafGranularity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafGranularity(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafGranularity P1D { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafGranularity PT1H { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafGranularity PT5M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafGranularity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafGranularity left, Azure.ResourceManager.Cdn.Models.WafGranularity right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafGranularity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafGranularity left, Azure.ResourceManager.Cdn.Models.WafGranularity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafMetric : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafMetric>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafMetric(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafMetric ClientRequestCount { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafMetric other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafMetric left, Azure.ResourceManager.Cdn.Models.WafMetric right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafMetric (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafMetric left, Azure.ResourceManager.Cdn.Models.WafMetric right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WafMetricsResponse
    {
        internal WafMetricsResponse() { }
        public System.DateTimeOffset? DateTimeBegin { get { throw null; } }
        public System.DateTimeOffset? DateTimeEnd { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity? Granularity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItem> Series { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafMetricsResponseGranularity : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafMetricsResponseGranularity(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity P1D { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity PT1H { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity PT5M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity left, Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity left, Azure.ResourceManager.Cdn.Models.WafMetricsResponseGranularity right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WafMetricsResponseSeriesItem
    {
        internal WafMetricsResponseSeriesItem() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> Data { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesPropertiesItemsItem> Groups { get { throw null; } }
        public string Metric { get { throw null; } }
        public Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit? Unit { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafMetricsResponseSeriesItemUnit : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafMetricsResponseSeriesItemUnit(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit Count { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit left, Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit left, Azure.ResourceManager.Cdn.Models.WafMetricsResponseSeriesItemUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WafMetricsResponseSeriesPropertiesItemsItem
    {
        internal WafMetricsResponseSeriesPropertiesItemsItem() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafRankingGroupBy : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafRankingGroupBy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafRankingGroupBy(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafRankingGroupBy CustomDomain { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingGroupBy HttpStatusCode { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafRankingGroupBy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafRankingGroupBy left, Azure.ResourceManager.Cdn.Models.WafRankingGroupBy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafRankingGroupBy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafRankingGroupBy left, Azure.ResourceManager.Cdn.Models.WafRankingGroupBy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WafRankingsResponse
    {
        internal WafRankingsResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.WafRankingsResponseDataItem> Data { get { throw null; } }
        public System.DateTimeOffset? DateTimeBegin { get { throw null; } }
        public System.DateTimeOffset? DateTimeEnd { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Groups { get { throw null; } }
    }
    public partial class WafRankingsResponseDataItem
    {
        internal WafRankingsResponseDataItem() { }
        public System.Collections.Generic.IReadOnlyList<string> GroupValues { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cdn.Models.ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems> Metrics { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafRankingType : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafRankingType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafRankingType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType Action { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType ClientIP { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType Country { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType RuleGroup { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType RuleId { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType RuleType { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType Url { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRankingType UserAgent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafRankingType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafRankingType left, Azure.ResourceManager.Cdn.Models.WafRankingType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafRankingType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafRankingType left, Azure.ResourceManager.Cdn.Models.WafRankingType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WafRuleType : System.IEquatable<Azure.ResourceManager.Cdn.Models.WafRuleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WafRuleType(string value) { throw null; }
        public static Azure.ResourceManager.Cdn.Models.WafRuleType Bot { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRuleType Custom { get { throw null; } }
        public static Azure.ResourceManager.Cdn.Models.WafRuleType Managed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cdn.Models.WafRuleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cdn.Models.WafRuleType left, Azure.ResourceManager.Cdn.Models.WafRuleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cdn.Models.WafRuleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cdn.Models.WafRuleType left, Azure.ResourceManager.Cdn.Models.WafRuleType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
