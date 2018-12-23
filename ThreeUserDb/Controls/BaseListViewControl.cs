using System;
using System.Reflection;
using System.Windows.Forms;
using ThreeUserDb.Forms;
using ThreeUserDb.Models;

namespace ThreeUserDb.Controls
{
    public partial class BaseListViewControl : UserControl
    {
        protected bool IsLimited { get; set; } = true;
        protected decimal Limit { get; set; } = 10;
        protected decimal Page { get; set; } = 1;

        //protected Type EntityType { get; set; }
        public Type EntityType { get; set; }
        public object SelectedEntity { get; set; }

        //public event EntityDeleteHandler OnEntityDelete;

        protected BaseListViewControl()
        {
            InitializeComponent();
        }

        private void BaseListViewControl_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        protected virtual void ReloadData()
        {
            Console.WriteLine($"1) {IsLimited} {Limit} {Page}");
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dataGridView.Rows[e.RowIndex].DataBoundItem;

            switch (item)
            {
                case Order order:
                    var orderForm = new OrderForm(order);
                    orderForm.Show();
                    break;
                case User user:
                    var userForm = new UserForm(user);
                    userForm.Show();
                    break;
            }
        }

        private void checkBoxLimit_CheckedChanged(object sender, EventArgs e)
        {
            IsLimited = checkBoxLimit.Checked;
            ReloadData();
        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {
            Limit = numericUpDownLimit.Value;
            ReloadData();
        }

        private void numericUpDownPage_ValueChanged(object sender, EventArgs e)
        {
            Page = numericUpDownPage.Value;
            ReloadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (EntityType == typeof(Order))
            {
                var editForm = new OrderForm();
                editForm.Show();
            }
            else if (EntityType == typeof(User))
            {
                var userForm = new UserForm();
                userForm.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1) return;

            if (EntityType == typeof(Order))
            {
                foreach (var selectedRow in dataGridView.SelectedRows)
                {
                    var order = (Order) ((DataGridViewRow) selectedRow).DataBoundItem;
                    DbContext.DataContext.GetTable<Order>().DeleteOnSubmit(order);
                }
            }
            else if (EntityType == typeof(User))
            {
                foreach (var selectedRow in dataGridView.SelectedRows)
                {
                    var user = (User) ((DataGridViewRow) selectedRow).DataBoundItem;
                    DbContext.DataContext.GetTable<User>().DeleteOnSubmit(user);
                }
            }

            DbContext.DataContext.SubmitChanges();
            ReloadData();
        }
    }
}