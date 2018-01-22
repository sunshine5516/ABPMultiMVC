using System.Threading.Tasks;
using Abp.Application.Services;
using ABPMultiMVC.Authorization.Accounts.Dto;

namespace ABPMultiMVC.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
