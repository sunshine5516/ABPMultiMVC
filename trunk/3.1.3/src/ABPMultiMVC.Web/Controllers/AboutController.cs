using System.Web.Mvc;

namespace ABPMultiMVC.Web.Controllers
{
    public class AboutController : ABPMultiMVCControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}