using Abp.AutoMapper;
using ABPMultiMVC.Sessions.Dto;

namespace ABPMultiMVC.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}