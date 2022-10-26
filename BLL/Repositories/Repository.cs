using CORE;
using CORE.DAL;
using CORE.Data;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repository : IRepository
    {
        List<Parent> query = ParentData.Parents;
        public Repository()
        {
        }

        public IEnumerable<Parent> Get(Func<Parent, bool> filter = null, Func<IEnumerable<Parent>, IOrderedQueryable<Parent>> orderBy = null)
        {
            IEnumerable<Parent> Result = query;

            if (filter != null)
                Result = query.Where(filter);

            if (orderBy != null)
                Result = orderBy(query);

            return Result;
        }

        public virtual IEnumerable<Parent> Query(Func<Parent, bool> filter = null, Func<IEnumerable<Parent>, IOrderedQueryable<Parent>> orderBy = null)
        {
            IEnumerable<Parent> Result=query;
            if (filter != null)
                Result = query.Where(filter);

            if (orderBy != null)
                Result = orderBy(query);

            return Result;
        }

        public virtual Parent GetById(int id)
        {
            var entity = query.FirstOrDefault(emp => emp.Id == id); ;
            
            return entity;
        }

        public virtual IEnumerable<Parent> GetAllById(int id)
        {
            var entity = query.Where(emp => emp.Id == id); ;

            return entity;
        }

        public virtual Parent GetFirstOrDefault(Func<Parent, bool> filter = null)
        {
            return query.FirstOrDefault(filter);
        }

        Parent IRepository.GetLastOrDefault(Func<Parent, bool> filter)
        {
            return query.LastOrDefault(filter);
        }

        public virtual void Insert(Parent entity)
        {
            query.Add(entity);
        }
        public virtual void Insert(ICollection<Parent> entities)
        {
            query.AddRange(entities);
        }

        public virtual void Update(Parent entity)
        {
           int index= query.IndexOf(query.FirstOrDefault(X => X.Id == entity.Id));
            query[index] = new Parent(entity);   
        }

        public virtual void Delete(int id)
        {
            query.Remove(query.FirstOrDefault(X=>X.Id==id));
        }

        public virtual void Delete(Parent entityToDelete)
        {
            query.Remove(query.FirstOrDefault(X => X.Id == entityToDelete.Id));
        }
    }
}
