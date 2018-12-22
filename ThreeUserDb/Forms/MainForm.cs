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
            var tabPageOrders = new TabPage("Заказы");
            tabPageOrders.Controls.Add(new ListViewControl<Order>());
            tabControl1.TabPages.Add(tabPageOrders);
            tabControl1.SelectedIndex = 0;
            
            var tabPageEquipments = new TabPage("Оборудование");
            tabPageEquipments.Controls.Add(new ListViewControl<Equipment>());
            tabControl1.TabPages.Add(tabPageEquipments);
            
            var tabPageUsers = new TabPage("Пользователи");
            tabPageUsers.Controls.Add(new ListViewControl<User>());
            tabControl1.TabPages.Add(tabPageUsers);
        }
    }
}