using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeUserDb.Models;

namespace ThreeUserDb.Forms
{
    public partial class LoginForm : Form
    {
        //string connectionString1 = @"Data Source=""(local)"";Initial Catalog=ThreeUserDb;Integrated Security=True";
        string connectionString { get; set; } =
            @"Data Source=""(local)"";Initial Catalog=ThreeUserDb;Integrated Security=True";

        //private DataContext _db;

        public bool IsAuth { get; set; } = false;

        public LoginForm()
        {
            InitializeComponent();

            DbContext.DataContext = new DataContext(connectionString);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var users = DbContext.DataContext.GetTable<User>();
            var auth = users.Where(x => x.Username == textBoxUsername.Text && 
                                        x.Password == textBoxPassword.Text);
            if (auth.Any())
            {
                IsAuth = true;
                DbContext.CurrentUser = auth.FirstOrDefault();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
