using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using BusinessEntity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace MyPos.CustomControls
{
    public partial class ucListItem : DevExpress.XtraEditors.XtraForm
    {
        public string FormCaption { get; set; }
        public string ListColumns { get; set; }
        public string ListFields { get; set; }
        public string ListDataSources { get; set; }
        ProductModel model = new ProductModel();
        public object ReturnId { get; set; }
        public string SqlQuery { get; set; }

        public ucListItem()
        {
            InitializeComponent();
            this.Text = this.FormCaption;
            
        }

        public void SetDataSource<T>(List<T> datasource)
        {
            DataTable dataTable = GetDataTable(this.SqlQuery);
            gridControl1.DataSource = dataTable;

            List<string> listFields = this.ListFields.Split(',').ToList();
            List<string> listColumns = this.ListColumns.Split(',').ToList();
            List<string> listDataSources = this.ListDataSources.Split(',').ToList();

            foreach (GridColumn gc in gridView1.Columns)
            {
                int indexCol = listFields.IndexOf(gc.FieldName);
                if (indexCol == -1) gc.Visible = false;
                else
                {
                    if (gc.FieldName == "Id") gc.Visible = false;
                    else
                    {
                        gc.Caption = listColumns[indexCol];
                        gc.OptionsColumn.AllowEdit = false;
                    }
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.ReturnId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            this.Close();
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable retVal = new DataTable();
            SqlConnection entityConn = model.Database.Connection as SqlConnection;
            SqlCommand cmdReport = new SqlCommand(sql, entityConn);
            SqlDataAdapter daReport = new SqlDataAdapter(cmdReport);
            cmdReport.CommandType = CommandType.Text;
            daReport.Fill(retVal);
            return retVal;
        }
    }
}