using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using HS.Farm.Authorization.Users;
using HS.Farm.MultiTenancy;

namespace HS.Farm.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
