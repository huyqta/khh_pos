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

        RepositoryItemLookUpEdit ri = new RepositoryItemLookUpEdit();

        public ucListItem()
        {
            InitializeComponent();
            this.Text = this.FormCaption;
            
        }

        public void SetDataSource<T>(List<T> datasource)
        {
            gridControl1.DataSource = datasource;

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
                        if (listDataSources[indexCol] != string.Empty)
                        {
                            string sql = string.Format("SELECT Id, Name FROM {0}", listDataSources[indexCol]);
                            DataTable dataTable = GetDataTable(sql);
                            ri = new RepositoryItemLookUpEdit();
                            ri.BeginInit();
                            ri.DataSource = dataTable;
                            ri.ValueMember = dataTable.Columns[0].ColumnName;
                            ri.DisplayMember = dataTable.Columns[1].ColumnName;
                            gridControl1.RepositoryItems.Add(ri);
                            gc.ColumnEdit = ri;
                        }
                        gc.OptionsColumn.AllowEdit = false;
                    }
                }
            }
            gridControl1.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(gridControl1_ViewRegistered);
        }

        private void ucListItem_Load(object sender, EventArgs e)
        {
            
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

        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            (e.View as GridView).Columns["VendorId"].ColumnEdit = ri;
        }
    }
}