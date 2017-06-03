using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ZmBlog.Authorization;
using ZmBlog.MultiTenancy;

namespace ZmBlog.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ZmBlogControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}