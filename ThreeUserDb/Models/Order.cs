using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace ThreeUserDb.Models
{
    [Table(Name = "Orders")]
    public class Order : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL IDENTITY")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Column(Name = "Name", DbType = "varchar(50) NULL")]
        public string Name { get; set; }



        //[Browsable(false)]
        //[Column(Name = "EquipmentId", DbType = "int NULL", CanBeNull = true)]
        //public int? EquipmentId { get; set; }

        //private EntityRef<Equipment> _equipment;

        //[Browsable(false)]
        //[Association(Name = "FK_Orders_Users_EquipmentId", Storage = "_equipment", 
        //    ThisKey = "EquipmentId", IsForeignKey = true)]
        //public Equipment Equipment
        //{
        //    get => _equipment.Entity;
        //    internal set
        //    {
        //        _equipment.Entity = value;
        //        EquipmentId = value?.Id;
        //    }
        //}

        //[DisplayName("Оборудование")] public string EquipmentName => Equipment?.Name;



        //[Browsable(false)]
        //[Column(Name = "ExecutorId", DbType = "int NULL", CanBeNull = true)]
        //public int? ExecutorId { get; set; }

        //private EntityRef<User> _executor;

        //[Browsable(false)]
        //[Association(Name = "FK_Orders_Users_ExecutorId", Storage = "_executor", 
        //    ThisKey = "ExecutorId", IsForeignKey = true)]
        //public User Executor
        //{
        //    get => _executor.Entity;
        //    internal set
        //    {
        //        _executor.Entity = value;
        //        ExecutorId = value?.Id;
        //    }
        //}

        //[DisplayName("Исполнитель")] public string ExecutorName => Executor?.Name;

        [DisplayName("Оборудование")]
        [Column(Name = "Equipment", DbType = "varchar(50) NULL", CanBeNull = true)]
        public string Equipment { get; set; }

        [DisplayName("Кто принял")]
        [Column(Name = "Executor", DbType = "varchar(50) NULL", CanBeNull = true)]
        public string Executor { get; set; }

        [DisplayName("Кто выполнил")]
        [Column(Name = "CompletedBy", DbType = "varchar(50) NULL", CanBeNull = true)]
        public string CompletedBy { get; set; }



        [Browsable(false)]
        [Column(Name = "AuthorId", DbType = "int NULL", CanBeNull = true)]
        public int? AuthorId { get; set; }

        private EntityRef<User> _author;

        [Browsable(false)]
        [Association(Name = "FK_Orders_Users_AuthorId", Storage = "_author",
            ThisKey = "AuthorId", IsForeignKey = true)]
        public User Author
        {
            get => _author.Entity;
            internal set
            {
                _author.Entity = value;
                AuthorId = value?.Id;
            }
        }

        [DisplayName("Кто передал")] public string AuthorName => Author?.Name;
    }
}