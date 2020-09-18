using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCoreExample.Models;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExample.Controllers
{
    public sealed class KebabCasedModelsController : JsonApiController<KebabCasedModel>	
    {	
        public KebabCasedModelsController(	
            IJsonApiOptions options,	
            ILoggerFactory loggerFactory,	
            IResourceService<KebabCasedModel> resourceService)	
            : base(options, loggerFactory, resourceService)	
        { }	
    }
}
