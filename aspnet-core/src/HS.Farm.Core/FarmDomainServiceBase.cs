using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm
{
    public class FarmDomainServiceBase: DomainService
    {
        protected FarmDomainServiceBase()
        {
            LocalizationSourceName = FarmConsts.LocalizationSourceName;
        }
    }
}
