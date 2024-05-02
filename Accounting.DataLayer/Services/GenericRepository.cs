using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<T> where T:class
    {
        private Accounting_DBEntities _db;
        private DbSet<T> _DbSet;

        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _DbSet = db.Set<T>();
        }

        public virtual T GetById(object Id)
        {
            return _DbSet.Find(Id);
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> where = null)
        {
            IQueryable<T> query = _DbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        public virtual void Insert(T consept)
        {
            _DbSet.Add(consept);
        }

        public virtual void Update(T row)
        {
            _DbSet.Attach(row);
            _db.Entry(row).State = EntityState.Modified;
        }
        public virtual void Delete(T row)
        {
            if (_db.Entry(row).State == EntityState.Detached)
            {
                _DbSet.Attach(row);
            }
            _db.Entry(row).State = EntityState.Deleted;
        }
        public virtual void Delete(object Id)
        {
            Delete(GetById(Id));
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
