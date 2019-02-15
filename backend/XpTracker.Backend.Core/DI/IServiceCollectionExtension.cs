using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Config;
using XpTracker.Backend.Core.DataMapper;
using XpTracker.Backend.Core.Helper;
using XpTracker.Backend.Core.Repo;
using XpTracker.Backend.Core.Repo.Common;
using XpTracker.Backend.Core.Service.BusinessServices;
using XpTracker.Backend.Core.Service.Facades;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.DI
{
    /// <summary>
    /// dotnetcore dependancy injection
    /// </summary>
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// experience tracker dependancy injection module
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddXpTrackerCoreServices(this IServiceCollection services, IConfiguration configuration)
        {

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            });

            //services.Configure<KeyVault>(options => configuration.GetSection("KeyVault").Bind(options));
            services.Configure<EmailConfig>(options => configuration.GetSection("EmailConfig").Bind(options));
            services.Configure<FeatureFlags>(options => configuration.GetSection("FeatureFlags").Bind(options));


            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<XpTrackerDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("XpTrackerDbConnection"))
            );

            //REST SERVICES
            services.AddTransient<IFacadeExperienceService, FacadeExperienceService>();
            //services.AddTransient<IFacadeFeedbackService, FacadeFeedbackService>();
            //services.AddTransient<IFacadeRecognitionService, FacadeRecognitionService>();
            //services.AddTransient<IDebugService, DebugService>();
            //services.AddTransient<IFacadeDashboardService, FacadeDashboardService>();
            //services.AddTransient<IFacadeNotificationService, FacadeNotificationService>();
            //services.AddTransient<IFacadeSendMailService, FacadeSendMailService>();
            //services.AddTransient<IFacadeWebHookClientService, FacadeWebHookClientService>();
            //ENDOF REST SERVICES



            //BUSINESS SERVICES
            services.AddTransient<IExperienceService, ExperienceService>();
            //services.AddTransient<IRecognitionService, RecognitionService>();
            //services.AddTransient<IFeedbackService, FeedbackService>();
            //services.AddTransient<ISendMailService, SendMailService>();
            //services.AddTransient<IDashboardService, DashboardService>();
            //services.AddScoped<IAdminConfigService, AdminConfigService>();
            //services.AddScoped<INotificationService, NotificationService>();
            //services.AddScoped<IApplicationUserService, ApplicationUserService>();


            //services.AddSingleton<KeyVaultEncryptionHelper, KeyVaultEncryptionHelper>();
            //services.AddSingleton<IEncryptionHelper, KeyVaultEncryptionHelper>();


            //ENDOF BUSINESS SERVICES

            services.AddScoped<IXpTrackerDbContext, XpTrackerDbContext>();
            services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepo<>));
            services.AddScoped<IExperienceRepo, ExperienceRepo>();
            //services.AddScoped<IFeedbackInquiryRepo, FeedbackInquiryRepo>();
            //services.AddScoped<IFeedbackRepo, FeedbackRepo>();
            //services.AddScoped<IUserRepo, UserRepo>();
            //services.AddScoped<IRecognitionRepo, RecognitionRepo>();
            //services.AddScoped<ICmsRepo, SharepointCmsRepo>();
            //services.AddScoped<IGraphRepo, GraphRepo>();
            //services.AddScoped<IDeviceRegistrationRepo, DeviceRegistrationRepo>();
            //services.AddScoped<INotifierRepo, AzureNotifierRepo>();


            //var features = configuration.GetSection("FeatureFlags").Get<FeatureFlags>();
            //if (features.IsMailDisabled)
            //{
            //    services.AddScoped<IEmailService, FakeEmailService>();
            //}
            //else
            //{
            //    services.AddScoped<IEmailService, GraphRepo>();//yes, graph can send mail
            //}

            services.AddScoped<IXpTrackerLogger, XpTrackerLogger>();

            services.AddTransient<XpTrackerSeeder>();

            //services.AddSingleton<XpTrackerMemoryCache>();


            return services;
        }

    }
}
