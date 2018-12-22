using System;
using System.Linq;
using System.Windows.Forms;

namespace ThreeUserDb.Controls
{
    public class ListViewControl<T> : BaseListViewControl where T : class, IModel, new()
    {
        public ListViewControl()
        {
            base.Dock = DockStyle.Fill;
        }

        protected override void ReloadData()
        {
            var query = DbContext.DataContext.GetTable<T>().AsQueryable();

            if (IsLimited)
            {
                query = query
                    .Skip((int)(Limit * (Page - 1)))
                    .Take((int)Limit);
            }

            dataGridViewOrders.DataSource = new BindingSource(query, null);
        }
    }
}