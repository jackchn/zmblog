using System.Linq;
using ZmBlog.EntityFramework;
using ZmBlog.MultiTenancy;

namespace ZmBlog.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ZmBlogDbContext _context;

        public DefaultTenantCreator(ZmBlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
