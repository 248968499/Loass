﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Loass.Framework.Data
{
    public class RepositoryBase<TEntity>
           : IRepositoryBase<TEntity> where TEntity : class
    {
        internal LoassContext context;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(LoassContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// 获取全部对象
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        public TEntity Insert(TEntity entity)
        {
            return dbSet.Add(entity);
        }

        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <param name="id"></param>
        public TEntity Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            return Delete(entityToDelete);
        }
        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual TEntity Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            return dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entityToUpdate">待更新的实体</param>
        public TEntity Update(TEntity entityToUpdate)
        {
            TEntity entity = dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            return entity;
        }
    }
}