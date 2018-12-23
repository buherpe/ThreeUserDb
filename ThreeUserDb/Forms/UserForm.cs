using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeUserDb.Models;

namespace ThreeUserDb.Forms
{
    public partial class UserForm : Form
    {
        private User _user { get; set; }

        public UserForm()
        {
            InitializeComponent();

            var userTypes = DbContext.DataContext.GetTable<UserType>();

            comboBoxType.DataSource = userTypes.GetNewBindingList();
        }

        public UserForm(User user)
        {
            InitializeComponent();

            _user = user;
            LoadData();
        }

        private void LoadData()
        {
            labelId.Text = $@"{_user.Id}";

            textBoxName.Text = _user.Name;

            var userTypes = DbContext.DataContext.GetTable<UserType>();

            textBoxName.Text = _user.Name;
            textBoxUsername.Text = _user.Username;
            textBoxPassword.Text = _user.Password;

            comboBoxType.DataSource = userTypes.GetNewBindingList();
            comboBoxType.SelectedItem = _user.Type;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            if (_user == null)
            {
                _user = new User();
                _user.Name = textBoxName.Text;
                _user.Username = textBoxUsername.Text;
                _user.Password = textBoxPassword.Text;
                _user.Type = (UserType) comboBoxType.SelectedItem;

                DbContext.DataContext.GetTable<User>().InsertOnSubmit(_user);
                DbContext.DataContext.SubmitChanges();

                labelId.Text = $@"{_user.Id}";

                return;
            }

            _user.Name = textBoxName.Text;
            _user.Username = textBoxUsername.Text;
            _user.Password = textBoxPassword.Text;
            _user.Type = (UserType) comboBoxType.SelectedItem;

            DbContext.DataContext.SubmitChanges();
        }
    }
}