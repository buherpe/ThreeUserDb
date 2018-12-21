using System.Data.Linq.Mapping;

namespace ThreeUserDb.Models
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Username")]
        public string Username { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
    }
}