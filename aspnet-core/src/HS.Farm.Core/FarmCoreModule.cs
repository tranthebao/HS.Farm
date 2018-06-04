using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using HS.Farm.Authorization.Roles;
using HS.Farm.Authorization.Users;
using HS.Farm.Configuration;
using HS.Farm.Localization;
using HS.Farm.MultiTenancy;
using HS.Farm.Timing;
using System.Reflection;

namespace HS.Farm
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class FarmCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            FarmLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = false;// FarmConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();

            //Configuration.Authorization.IsEnabled = true;
            //Configuration.EntityHistory.IsEnabled = true;

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention((typeof(FarmCoreModule).GetAssembly()));

        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
