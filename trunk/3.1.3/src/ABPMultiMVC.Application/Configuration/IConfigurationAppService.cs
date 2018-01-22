using System.Threading.Tasks;
using Abp.Application.Services;
using ABPMultiMVC.Configuration.Dto;

namespace ABPMultiMVC.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}