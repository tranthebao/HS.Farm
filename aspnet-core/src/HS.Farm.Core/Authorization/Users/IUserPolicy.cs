using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authorization.Users
{
    public class IUserPolicy: IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
