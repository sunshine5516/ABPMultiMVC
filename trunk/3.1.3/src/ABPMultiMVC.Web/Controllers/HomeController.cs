using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPMultiMVC.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPMultiMVCControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}