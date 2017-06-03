using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ZmBlog.EntityFramework.Repositories
{
    public abstract class ZmBlogRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ZmBlogDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ZmBlogRepositoryBase(IDbContextProvider<ZmBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ZmBlogRepositoryBase<TEntity> : ZmBlogRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ZmBlogRepositoryBase(IDbContextProvider<ZmBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
