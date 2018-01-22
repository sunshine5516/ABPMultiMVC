using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPMultiMVC.MultiTenancy.Dto;

namespace ABPMultiMVC.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
