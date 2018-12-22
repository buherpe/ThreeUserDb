using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Users")]
    public class User : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL")]
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Column(Name = "Name", DbType = "varchar(50) NULL")]
        public string Name { get; set; }

        [DisplayName("Логин")]
        [Column(Name = "Username", DbType = "varchar(50) NOT NULL")]
        public string Username { get; set; }

        [Browsable(false)]
        [Column(Name = "Password", DbType = "varchar(50) NOT NULL")]
        public string Password { get; set; }
    }
}