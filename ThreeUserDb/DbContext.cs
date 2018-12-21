using System.Data.Linq;
using ThreeUserDb.Models;

namespace ThreeUserDb
{
    public static class DbContext
    {
        public static DataContext DataContext { get; set; }

        public static User CurrentUser { get; set; }
    }
}