using System.Threading.Tasks;
using Abp.Application.Services;
using ABPMultiMVC.Sessions.Dto;

namespace ABPMultiMVC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
