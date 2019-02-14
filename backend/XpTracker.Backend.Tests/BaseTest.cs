using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using XpTracker.Backend.Core.Service.Log;
using Xunit;

namespace XpTracker.Backend.Tests
{
    public class BaseTest
    {
        protected ServiceProvider _serviceProvider;
        protected readonly IXpTrackerLogger _logger;
        //protected readonly IFakeUserService _testUserService;

        public BaseTest()
        {
            var serviceCollection = new ServiceCollection();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.development.json")
                .Build();

            _serviceProvider = serviceCollection
                //.AddMarsLoopCoreServices(config)
                //.AddMarsLoopAnonymousServices(config)
                //.AddMarsLoopFakeDbServices(config)
                .BuildServiceProvider();

            this._logger = _serviceProvider.GetService<IXpTrackerLogger>() as IXpTrackerLogger;

            //this._testUserService = _serviceProvider.GetService<IFakeUserService>() as IFakeUserService;

        }
    }
}
