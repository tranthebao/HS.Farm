using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using HS.Farm.Authorization;
using HS.Farm.Authorization.Roles;
using HS.Farm.Authorization.Users;
using HS.Farm.Editions;
using HS.Farm.MultiTenancy;
using HS.Farm.Authentication.TwoFactor.Google;

namespace HS.Farm.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
            {
                options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
            })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddAbpSignInManager<SignInManager>()
                .AddDefaultTokenProviders();
        }
    }
}
