﻿using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPMultiMVC.EntityFramework.Repositories
{
    public abstract class ABPMultiMVCRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPMultiMVCDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPMultiMVCRepositoryBase(IDbContextProvider<ABPMultiMVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPMultiMVCRepositoryBase<TEntity> : ABPMultiMVCRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPMultiMVCRepositoryBase(IDbContextProvider<ABPMultiMVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
