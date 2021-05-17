using System.Collections.Generic;
using System.Linq;
using domain;

namespace persistance
{
    public class UsersRepository : IRepository<User,string>
    {
        public IEnumerable<User> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public User Save(User entity)
        {
            throw new System.NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public User Update(User entity, User newEntity)
        {
            throw new System.NotImplementedException();
        }

        public User findOne(string username, string password)
        {
            var con = ORMConnectionFactory.getConnection();
            var elems = con.GetTable<User>().Where(x => x.username == username && x.password == password);
            if (elems.Count() > 0){
                con.Close();
                return elems.First();
            }
            con.Close();
            return null;
        }

        public List<User> findAllByPosition(string programmer)
        {
            var con = ORMConnectionFactory.getConnection();
            var elems = con.GetTable<User>().Where(x => x.position == programmer);
            con.Close();
            return elems.ToList();
        }
    }
}