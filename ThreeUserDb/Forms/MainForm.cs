using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeUserDb.Controls;
using ThreeUserDb.Models;

namespace ThreeUserDb.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            labelCurrentUser.Text = DbContext.CurrentUser.Username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var orders = DbContext.DataContext.GetTable<Order>().GetNewBindingList();
            
            var tabPageOrders = new TabPage("Заказы");
            tabPageOrders.Controls.Add(new ListViewControl(orders) {Dock = DockStyle.Fill});
            tabControl1.TabPages.Add(tabPageOrders);
            tabControl1.SelectedIndex = 0;

            var equipment = DbContext.DataContext.GetTable<Equipment>().GetNewBindingList();
            
            var tabPageEquipments = new TabPage("Заказы");
            tabPageEquipments.Controls.Add(new ListViewControl(equipment) {Dock = DockStyle.Fill});
            tabControl1.TabPages.Add(tabPageEquipments);
        }
    }
}