using System;
using System.Linq;
using System.Windows.Forms;
using ThreeUserDb.Models;

namespace ThreeUserDb.Controls
{
    public class ListViewControl<T> : BaseListViewControl where T : class, IModel, new()
    {
        public ListViewControl()
        {
            base.Dock = DockStyle.Fill;

            EntityType = typeof(T);

            if (EntityType == typeof(Order))
            {
                buttonAdd.Visible = true;
                buttonDelete.Visible = true;
            }
            else if (EntityType == typeof(User))
            {
                buttonAdd.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        protected override void ReloadData()
        {
            var query = DbContext.DataContext.GetTable<T>().AsQueryable();

            if (IsLimited)
            {
                query = query
                    .Skip((int) (Limit * (Page - 1)))
                    .Take((int) Limit);
            }

            dataGridView.DataSource = new BindingSource(query, null);
        }
    }
}