using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Company.Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CompanyContext CompanyContext;
        public RepositoryBase(CompanyContext companyContext)
        => CompanyContext = companyContext;

        public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ?
        CompanyContext.Set<T>()
        .AsNoTracking() :
        CompanyContext.Set<T>();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
        !trackChanges ?
        CompanyContext.Set<T>()
        .Where(expression)
        .AsNoTracking() :
        CompanyContext.Set<T>()
        .Where(expression);
        public void Create(T entity) => CompanyContext.Set<T>().Add(entity);
        public void Update(T entity) => CompanyContext.Set<T>().Update(entity);
        public void Delete(T entity) => CompanyContext.Set<T>().Remove(entity);
    }

}
