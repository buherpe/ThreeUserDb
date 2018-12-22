using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Equipments")]
    public class Equipment : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }
    }
}