using System;
using LinqToDB.Mapping;

namespace domain
{
    [Serializable]
    public class Entity<TID>
    {
        public TID ID { get; set; }
    }
}