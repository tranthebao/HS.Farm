﻿using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace HS.Farm.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class FarmRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<FarmDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FarmRepositoryBase(IDbContextProvider<FarmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="FarmRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class FarmRepositoryBase<TEntity> : FarmRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FarmRepositoryBase(IDbContextProvider<FarmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
    //public class FarmRepositoryBase<TEntity> : FarmRepositoryBase<TEntity, int>, IRepository<TEntity>
    //   where TEntity : class, IEntity<int>
    //{
    //    public FarmRepositoryBase(IDbContextProvider<FarmDbContext> dbContextProvider)
    //        : base(dbContextProvider)
    //    {
    //    }
    //}

    //public class FarmRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<FarmDbContext, TEntity, TPrimaryKey>, IRepository<TEntity, TPrimaryKey>
    //    where TEntity : class, IEntity<TPrimaryKey>
    //{
    //    public FarmRepositoryBase(IDbContextProvider<FarmDbContext> dbContextProvider)
    //        : base(dbContextProvider)
    //    {
    //    }
    //}
}
