using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ProyetoSmarterAudit.EntityFramework.Repositories
{
    public abstract class ProyetoSmarterAuditRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProyetoSmarterAuditDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProyetoSmarterAuditRepositoryBase(IDbContextProvider<ProyetoSmarterAuditDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProyetoSmarterAuditRepositoryBase<TEntity> : ProyetoSmarterAuditRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProyetoSmarterAuditRepositoryBase(IDbContextProvider<ProyetoSmarterAuditDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
