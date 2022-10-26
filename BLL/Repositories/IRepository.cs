using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL
{
    public interface IRepository
    {
        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<Parent> Get(Func<Parent, bool> filter = null, Func<IEnumerable<Parent>, IOrderedQueryable<Parent>> orderBy = null);

        /// <summary>
        /// Get query for entity
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IEnumerable<Parent> Query(Func<Parent, bool> filter = null, Func<IEnumerable<Parent>, IOrderedQueryable<Parent>> orderBy = null);




        /// <summary>
        /// Get single entity by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Parent GetById(int id);
        /// <summary>
        /// Get all entities by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Parent> GetAllById(int id);

        /// <summary>
        /// Get first or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Parent GetFirstOrDefault(Func<Parent, bool> filter = null);


        /// <summary>
        /// Get Last or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Parent GetLastOrDefault(Func<Parent, bool> filter = null);

        /// <summary>
        /// Insert entity to db
        /// </summary>
        /// <param name="entity"></param>
        void Insert(Parent entity);
        /// <summary>
        /// Insert entities to db
        /// </summary>
        /// <param name="entities"></param>
        void Insert(ICollection<Parent> entities);

        /// <summary>
        /// Update entity in db
        /// </summary>
        /// <param name="entity"></param>
        void Update(Parent entity);

        

        /// <summary>
        /// Delete entity from db by primary key
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Delete entity from db
        /// </summary>
        /// <param name="entityToDelete"></param>
        void Delete(Parent entityToDelete);

        

        
    }
}
