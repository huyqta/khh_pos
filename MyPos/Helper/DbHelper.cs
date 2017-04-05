using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPos.Helper
{
    public static class DbHelper
    {
        
        public static void UpdateDatasource(GridControl grid, DbDataAdapter dataAdapter, System.Data.DataTable dataTable)
        {
            try
            {
                //Save the latest changes to the bound DataTable 
                ColumnView View = (ColumnView)grid.FocusedView;
                if (!(View.PostEditor() && View.UpdateCurrentRow())) return;

                //Update the database's Suppliers table to which oleDBDataAdapter1 is connected 
                DoUpdate(dataAdapter, dataTable);
                grid.DataSource = dataTable;
                grid.RefreshDataSource();
                grid.Refresh();
                MessageBox.Show("Saved successfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DoUpdate(DbDataAdapter dataAdapter, System.Data.DataTable dataTable)
        {
            try
            {
                dataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
