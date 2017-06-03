using System.Web.Mvc;

namespace ZmBlog.Web.Controllers
{
    public class AboutController : ZmBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}