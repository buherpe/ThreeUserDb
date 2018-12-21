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
    public partial class ListViewControl : UserControl
    {
        //private Table<object> _orders;
        private IBindingList _data;

        public ListViewControl()
        {
            InitializeComponent();
        }

        //public ListViewControl(Table<object> orders)
        //{
        //    InitializeComponent();
        //    _orders = orders;
        //}

        //public ListViewControl(IBindingList data)
        //{
        //    InitializeComponent();
        //    _data = data;
        //}

        public ListViewControl(IBindingList data)
        {
            InitializeComponent();
            _data = data;
        }

        private void ListViewControl_Load(object sender, EventArgs e)
        {
            dataGridViewOrders.DataSource = new BindingSource(_data, null);
        }

        //private void ReloadData()
        //{
        //    dataGridViewOrders.DataSource = new BindingSource(_data, null);
        //}

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
    }
}