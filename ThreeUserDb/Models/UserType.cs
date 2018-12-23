using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "UserTypes")]
    public class UserType : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL IDENTITY")]
        public int Id { get; set; }
        
        [DisplayName("Имя")]
        [Column(Name = "Name", DbType = "varchar(50) NULL", CanBeNull = true)]
        public string Name { get; set; }
    }
}