using System.Threading.Tasks;
using Abp.Dependency;

namespace HS.Farm.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}