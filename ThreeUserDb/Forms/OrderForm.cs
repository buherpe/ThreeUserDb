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
    public partial class OrderForm : Form
    {
        private Order _order { get; set; }

        public OrderForm()
        {
            InitializeComponent();

            var users = DbContext.DataContext.GetTable<User>();

            comboBoxAuthor.DataSource = users.GetNewBindingList();
            comboBoxAuthor.SelectedItem = DbContext.CurrentUser;
        }

        public OrderForm(Order order)
        {
            InitializeComponent();

            _order = order;
            LoadData();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (DbContext.CurrentUser.TypeId == 1)
                comboBoxAuthor.Enabled = true;
        }

        private void LoadData()
        {
            labelId.Text = $@"{_order.Id}";

            textBoxName.Text = _order.Name;

            var users = DbContext.DataContext.GetTable<User>();

            textBoxEquipment.Text = _order.Equipment;
            textBoxExecutor.Text = _order.Executor;
            textBoxCompletedBy.Text = _order.CompletedBy;

            comboBoxAuthor.DataSource = users.GetNewBindingList();
            comboBoxAuthor.SelectedItem = _order.Author;
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
            if (_order == null)
            {
                _order = new Order();
                _order.Name = textBoxName.Text;
                _order.Equipment = textBoxEquipment.Text;
                _order.Executor = textBoxExecutor.Text;
                _order.CompletedBy = textBoxCompletedBy.Text;
                _order.Author = (User) comboBoxAuthor.SelectedItem;

                DbContext.DataContext.GetTable<Order>().InsertOnSubmit(_order);
                DbContext.DataContext.SubmitChanges();

                labelId.Text = $@"{_order.Id}";

                return;
            }

            _order.Name = textBoxName.Text;
            _order.Equipment = textBoxEquipment.Text;
            _order.Executor = textBoxExecutor.Text;
            _order.CompletedBy = textBoxCompletedBy.Text;
            _order.Author = (User) comboBoxAuthor.SelectedItem;

            DbContext.DataContext.SubmitChanges();
        }
    }
}