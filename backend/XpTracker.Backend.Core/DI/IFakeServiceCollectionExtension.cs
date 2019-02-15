using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Fakes;
using XpTracker.Backend.Core.Repo;

namespace XpTracker.Backend.Core.DI
{
    /// <summary>
    /// dotnetcore dependancy injection
    /// </summary>
    public static class IFakeServiceCollectionExtension
    {

        /// <summary>
        /// experience tracker dependancy injection module
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddXpTrackerFakeDbServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IExperienceRepo, FakeExperienceRepo>();
            //services.AddScoped<IFeedbackInquiryRepo, FakeFeedbackInquiryRepo>();
            //services.AddScoped<IFavoriteRepo, FakeFavoriteRepo>();
            //services.AddScoped<IUserRepo, FakeUserRepo>();
            //services.AddScoped<IRecognitionRepo, FakeRecognitionRepo>();
            //services.AddScoped<IDeviceRegistrationRepo, FakeDeviceRegistrationRepo>();

            return services;
        }

        /// <summary>
        /// experience tracker dependancy injection module
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddXpTrackerAnonymousServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IUserContext, FakeUserContext>();

            return services;
        }
    }
}
