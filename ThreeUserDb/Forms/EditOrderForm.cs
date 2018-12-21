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
        }

        public EditOrderForm(int id)
        {
            InitializeComponent();
            _order = DbContext.DataContext.GetTable<Order>().FirstOrDefault(x => x.Id == id);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            labelId.Text = $@"{_order.Id}";

            textBoxName.Text = _order.Name;

            var users = DbContext.DataContext.GetTable<User>();

            comboBoxAuthor.DataSource = users.GetNewBindingList();
            comboBoxAuthor.DisplayMember = "Name";
            comboBoxAuthor.SelectedItem = users.FirstOrDefault(x => x.Id == _order.Author.Id);
            
            comboBoxExecutor.DataSource = users.GetNewBindingList();
            comboBoxExecutor.DisplayMember = "Name";
            comboBoxExecutor.SelectedItem = users.FirstOrDefault(x => x.Id == _order.Executor.Id);

            var equipments = DbContext.DataContext.GetTable<Equipment>();
            comboBoxEquipment.DataSource = equipments.GetNewBindingList();
            comboBoxEquipment.DisplayMember = "Name";
            comboBoxEquipment.SelectedItem = equipments.FirstOrDefault(x => x.Id == _order.Equipment.Id);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            _order.Name = textBoxName.Text;
            _order.Equipment = (Equipment)comboBoxEquipment.SelectedItem;
            _order.Author = (User) comboBoxAuthor.SelectedItem;
            _order.Executor = (User)comboBoxExecutor.SelectedItem;
            
            DbContext.DataContext.SubmitChanges();

            Close();
        }
    }
}