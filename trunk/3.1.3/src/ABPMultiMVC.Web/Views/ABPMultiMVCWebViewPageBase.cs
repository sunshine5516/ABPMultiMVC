using Abp.Web.Mvc.Views;

namespace ABPMultiMVC.Web.Views
{
    public abstract class ABPMultiMVCWebViewPageBase : ABPMultiMVCWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPMultiMVCWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPMultiMVCWebViewPageBase()
        {
            LocalizationSourceName = ABPMultiMVCConsts.LocalizationSourceName;
        }
    }
}