using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPMultiMVC.Configuration.Dto;

namespace ABPMultiMVC.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPMultiMVCAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
