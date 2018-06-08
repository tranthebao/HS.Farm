using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using HS.Farm.Authorization.Users;
using HS.Farm.MultiTenancy;

namespace HS.Farm.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
