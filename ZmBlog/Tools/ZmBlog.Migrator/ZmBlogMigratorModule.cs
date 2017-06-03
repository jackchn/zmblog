using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ZmBlog.EntityFramework;

namespace ZmBlog.Migrator
{
    [DependsOn(typeof(ZmBlogDataModule))]
    public class ZmBlogMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ZmBlogDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}