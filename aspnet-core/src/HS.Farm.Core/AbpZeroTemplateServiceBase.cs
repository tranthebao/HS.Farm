using Abp;

namespace HS.Farm
{
    public class AbpZeroTemplateServiceBase: AbpServiceBase
    {
        protected AbpZeroTemplateServiceBase()
        {
            LocalizationSourceName = FarmConsts.LocalizationSourceName;
        }
    }
}
