using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ZmBlog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ZmBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}