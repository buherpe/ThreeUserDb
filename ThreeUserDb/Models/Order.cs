using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace ThreeUserDb.Models
{
    [Table(Name = "Orders")]
    public class Order
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }



        [Browsable(false)]
        [Column(Name = "EquipmentId", CanBeNull = true)]
        public int? EquipmentId { get; set; }

        private EntityRef<Equipment> _equipment;

        [Browsable(false)]
        [Association(Name = "FK_Orders_Users_EquipmentId", Storage = "_equipment", ThisKey = "EquipmentId", IsForeignKey = true)]
        public Equipment Equipment
        {
            get => _equipment.Entity;
            internal set { _equipment.Entity = value; EquipmentId = value.Id; }
        }
        
        public string EquipmentName => Equipment?.Name;



        [Browsable(false)]
        [Column(Name = "AuthorId", CanBeNull = true)]
        public int? AuthorId { get; set; }

        private EntityRef<User> _author;

        [Browsable(false)]
        [Association(Name = "FK_Orders_Users_AuthorId", Storage = "_author", ThisKey = "AuthorId", IsForeignKey = true)]
        public User Author 
        {
            get => _author.Entity;
            internal set { _author.Entity = value; AuthorId = value.Id; }
        }

        public string AuthorName => Author?.Name;



        [Browsable(false)]
        [Column(Name = "ExecutorId", CanBeNull = true)]
        public int? ExecutorId { get; set; }

        private EntityRef<User> _executor;

        [Browsable(false)]
        [Association(Name = "FK_Orders_Users_ExecutorId", Storage = "_executor", ThisKey = "ExecutorId", IsForeignKey = true)]
        public User Executor
        {
            get => _executor.Entity;
            internal set { _executor.Entity = value; ExecutorId = value.Id; }
        }

        public string ExecutorName => Executor?.Name;
    }
}