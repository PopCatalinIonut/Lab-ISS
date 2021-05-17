using System.Collections.Generic;
using domain;
using System.Linq;
using System.Net.Configuration;
using LinqToDB;

namespace persistance
{
    public class BugsRepository : IRepository<Bug, int>
    {

        public BugsRepository() { }

        public IEnumerable<Bug> FindAll()
        {
            var con = ORMConnectionFactory.getConnection();
            var elems = con.GetTable<Bug>();
            return elems;
        }

        public Bug Save(Bug entity)
        {
            var con = ORMConnectionFactory.getConnection();
            var inserted = con.Insert(entity);
            if (inserted != 0)
                return entity;
            return null;
        }

        public Bug Delete(Bug entity)
        {
            var con = ORMConnectionFactory.getConnection();
            var deleted = con.Delete(entity);
            if (deleted != 0)
                return entity;
            return null;
        }
        public int Delete(int entity)
        {
            var con = ORMConnectionFactory.getConnection();
            var deleted = con.GetTable<Bug>().Where(x => x.id == entity).Delete();
            return deleted;
        }
        
        public Bug Update(Bug entity, Bug newEntity)
        {
            var con = ORMConnectionFactory.getConnection();
            var updated = con.Update(newEntity);
            if (updated != 0)
                return newEntity;
            return null;
        }

        public IEnumerable<Bug> getBugsByOwner(string currentUser)
        {
            var con = ORMConnectionFactory.getConnection();
            var elems = con.GetTable<Bug>().Where(x => x.foundBy == currentUser);
            return elems;
        }

        public IEnumerable<Bug> findAvailableBugs()
        {
            var con = ORMConnectionFactory.getConnection();
            var elems = con.GetTable<Bug>().Where(x => x.status == Status.Unresolved || x.status==Status.WorkingOn);
            return elems;
        }

        public int updateStatus(int id, Status status)
        {
            var con = ORMConnectionFactory.getConnection();
            var updated = con.GetTable<Bug>().Where(x => x.id == id).Set(x=> x.status,status).Update();
            return updated;
        }
    }
}