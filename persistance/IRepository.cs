using System.Collections.Generic;
using domain;
namespace persistance
{
    interface IRepository<E,ID> where E : Entity<ID>
    {
        IEnumerable<E> FindAll();
        E Save(E entity);

        E Delete(E entity);

        E Update(E entity, E newEntity);
    }
}