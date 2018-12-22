using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Equipments")]
    public class Equipment : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Column(Name = "Name", DbType = "varchar(50) NULL")]
        public string Name { get; set; }
    }
}