using Abp.Web.Mvc.Views;

namespace ZmBlog.Web.Views
{
    public abstract class ZmBlogWebViewPageBase : ZmBlogWebViewPageBase<dynamic>
    {

    }

    public abstract class ZmBlogWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ZmBlogWebViewPageBase()
        {
            LocalizationSourceName = ZmBlogConsts.LocalizationSourceName;
        }
    }
}