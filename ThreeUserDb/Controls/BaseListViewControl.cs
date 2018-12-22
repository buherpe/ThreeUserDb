using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var item = dataGridViewOrders.Rows[e.RowIndex].DataBoundItem;

            switch (item)
            {
                case Order order:
                    var editForm = new EditOrderForm(order.Id);
                    editForm.Show();
                    break;
                case User user:
                    Console.WriteLine($"{user.Id}");
                    break;
                case Equipment equipment:
                    Console.WriteLine($"{equipment.Id} {equipment.Name}");
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
            var editForm = new EditOrderForm();
            editForm.Show();
        }
    }
}