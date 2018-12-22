using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Equipments")]
    public class Equipment : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Column(Name = "Name")]
        public string Name { get; set; }
    }
}