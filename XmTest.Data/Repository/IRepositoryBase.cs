﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using XmTest.Basic.Web;

namespace XmTest.Data.Repository
{
    public interface IRepositoryBase : IDisposable
    {

        IRepositoryBase BeginTrans();
        int Commit();
        int Insert<TEntity>(TEntity entity) where TEntity : class;
        int Insert<TEntity>(List<TEntity> entitys) where TEntity : class;
        int Update<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        TEntity FindEntity<TEntity>(object keyValue) where TEntity : class;
        TEntity FindEntity<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        IQueryable<TEntity> IQueryable<TEntity>() where TEntity : class;
        IQueryable<TEntity> IQueryable<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        List<TEntity> FindList<TEntity>(string strSql) where TEntity : class;
        List<TEntity> FindList<TEntity>(string strSql, DbParameter[] dbParameter) where TEntity : class;
        List<TEntity> FindList<TEntity>(Page page) where TEntity : class,new();
        List<TEntity> FindList<TEntity>(Expression<Func<TEntity, bool>> predicate, Page page) where TEntity : class,new();
    }
}
