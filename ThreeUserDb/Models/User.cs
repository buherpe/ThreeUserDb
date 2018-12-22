using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Users")]
    public class User : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Column(Name = "Name")]
        public string Name { get; set; }

        [DisplayName("Логин")]
        [Column(Name = "Username")]
        public string Username { get; set; }

        [Browsable(false)]
        [Column(Name = "Password")]
        public string Password { get; set; }
    }
}