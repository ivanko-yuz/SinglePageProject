﻿using System.Linq;

namespace SinglePageProject.DAL.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> Query();

        TEntity GetById(params object[] id);

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void Delete(params object[] id);

        void Update(TEntity entity);
    }
}
