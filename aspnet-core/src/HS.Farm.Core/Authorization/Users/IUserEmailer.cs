using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authorization.Users
{
    public class IUserEmailer
    {
        Task SendEmailActivationLinkAsync(User user, string link, string plainPassword = null);
        Task SendPasswordResetLinkAsync(User user, string link = null);
        void TryToSendChatMessageMail(User user, string senderUsername, string senderTenancyName, ChatMessage chatMessage);
    }
}
