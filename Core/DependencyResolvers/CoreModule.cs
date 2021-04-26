using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollections)
        {
            serviceCollections.AddMemoryCache();
            serviceCollections.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollections.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollections.AddSingleton<Stopwatch>();
        }
    }
}
