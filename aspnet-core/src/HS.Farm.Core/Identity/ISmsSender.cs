using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
