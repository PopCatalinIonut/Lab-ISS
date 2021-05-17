using System;
using LinqToDB.Mapping;

namespace domain
{
    [Table(Name = "Bugs")]
    public class Bug : Entity<int>
    {
        [Column(Name = "name"), NotNull] 
        public string name { get; set; }
        
        [Column(Name = "description"), NotNull] 
        public string description { get; set; }
        
        [Column(Name = "foundBy"), NotNull] 
        public string foundBy { get; set; }
        
        [Column(Name = "date"), NotNull] 
        public DateTime date { get; set; }
        
        [Column(Name = "status"), NotNull] 
        public Status status { get; set; }
        
        [PrimaryKey, Column(Name = "id"), NotNull, Identity] 
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public Bug(){ }

        public Bug(string name, string description, string foundBy, DateTime date, Status status)
        {
            
            this.name = name;
            this.description = description;
            this.foundBy = foundBy;
            this.date = date;
            this.status = status;
        }
    }
}