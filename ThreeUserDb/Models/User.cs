using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Users")]
    public class User : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL IDENTITY")]
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Column(Name = "Name", DbType = "varchar(50) NULL")]
        public string Name { get; set; }

        [DisplayName("Логин")]
        [Column(Name = "Username", DbType = "varchar(50) NOT NULL")]
        public string Username { get; set; }

        //[Browsable(false)]
        [DisplayName("Пароль")]
        [Column(Name = "Password", DbType = "varchar(50) NOT NULL")]
        public string Password { get; set; }



        [Browsable(false)]
        [Column(Name = "TypeId", DbType = "int NOT NULL")]
        public int? TypeId { get; set; }

        private EntityRef<UserType> _type;

        [Browsable(false)]
        [Association(Name = "FK_Users_UserTypes", Storage = "_type",
            ThisKey = "TypeId", IsForeignKey = true)]
        public UserType Type
        {
            get => _type.Entity;
            internal set
            {
                _type.Entity = value;
                TypeId = value?.Id;
            }
        }

        [DisplayName("Тип")] public string TypeName => Type?.Name;
    }
}