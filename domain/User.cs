using System;
using LinqToDB.Mapping;

namespace domain
{
    [Serializable]
    [Table(Name = "Users")]
    public class User : Entity<string>
    {
        [PrimaryKey, Column(Name = "username"), NotNull] 
        public String username;

        [Column(Name = "password"), NotNull] 
        public String password;

        [Column(Name = "position"), NotNull] 
        public String position;

        public User() { }

        public override string ToString() {
            return username + ' ' + password + ' ' + position;
        }

    }
}