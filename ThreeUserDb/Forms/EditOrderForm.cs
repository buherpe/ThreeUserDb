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
    public partial class EditOrderForm : Form
    {
        private Order _order { get; set; }

        public EditOrderForm()
        {
            InitializeComponent();

            var users = DbContext.DataContext.GetTable<User>();
            var equipments = DbContext.DataContext.GetTable<Equipment>();

            comboBoxEquipment.DataSource = equipments.GetNewBindingList();
            comboBoxEquipment.SelectedItem = null;

            comboBoxExecutor.DataSource = users.GetNewBindingList();
            comboBoxExecutor.SelectedItem = null;

            comboBoxAuthor.DataSource = users.GetNewBindingList();
            comboBoxAuthor.SelectedItem = DbContext.CurrentUser;
        }

        public EditOrderForm(int id)
        {
            InitializeComponent();

            _order = DbContext.DataContext.GetTable<Order>().FirstOrDefault(x => x.Id == id);
            LoadData();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            labelId.Text = $@"{_order.Id}";

            textBoxName.Text = _order.Name;

            var users = DbContext.DataContext.GetTable<User>();
            var equipments = DbContext.DataContext.GetTable<Equipment>();

            comboBoxEquipment.DataSource = equipments.GetNewBindingList();
            comboBoxEquipment.SelectedItem = _order.Equipment;

            comboBoxExecutor.DataSource = users.GetNewBindingList();
            comboBoxExecutor.SelectedItem = _order.Executor;
            
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
                _order.Equipment = (Equipment)comboBoxEquipment.SelectedItem;
                _order.Author = (User)comboBoxAuthor.SelectedItem;
                _order.Executor = (User)comboBoxExecutor.SelectedItem;

                DbContext.DataContext.GetTable<Order>().InsertOnSubmit(_order);
                DbContext.DataContext.SubmitChanges();

                return;
            }

            _order.Name = textBoxName.Text;
            _order.Equipment = (Equipment)comboBoxEquipment.SelectedItem;
            _order.Author = (User)comboBoxAuthor.SelectedItem;
            _order.Executor = (User)comboBoxExecutor.SelectedItem;

            DbContext.DataContext.SubmitChanges();
        }
    }
}