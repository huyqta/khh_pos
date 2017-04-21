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
                            string sql = string.Format("SELECT Name FROM {0}", listDataSources[indexCol]);
                            DataTable dataTable = GetDataTable(sql);
                            RepositoryItemLookUpEdit ri = new RepositoryItemLookUpEdit() { DataSource = dataTable, ValueMember = dataTable.Columns[0].ColumnName, DisplayMember = dataTable.Columns[1].ColumnName };
                            gc.ColumnEdit = ri;
                        }
                        gc.OptionsColumn.AllowEdit = false;
                    }
                }
            }
            //for (int i = 0; i < listFields.Count(); i++)
            //{
            //    GridColumn gc = new GridColumn();
            //    gc.FieldName = listFields[i];
            //    gc.Caption = listColumns[i];


            //    if (listDataSources[i] != string.Empty)
            //    {
            //        string sql = string.Format("SELECT Id, Name FROM {0}", listDataSources[i]);
            //        DataTable dataTable = GetDataTable(sql);
            //        gc.ColumnEdit = new RepositoryItemLookUpEdit() { DataSource = dataTable, ValueMember = dataTable.Columns[0].ColumnName, DisplayMember = dataTable.Columns[1].ColumnName };
            //    }
            //    gc.OptionsColumn.AllowEdit = false;
            //    gridView1.Columns.Add(gc);
            //}
            
        }

        private void ucListItem_Load(object sender, EventArgs e)
        {
            //string[] listFields = this.ListFields.Split(',');
            //string[] listColumns = this.ListColumns.Split(',');
            //string[] listDataSources = this.ListDataSources.Split(',');

            //for (int i = 0; i < listFields.Count(); i++)
            //{
            //    GridColumn gc = new GridColumn();
            //    gc.FieldName = listFields[i];
            //    gc.Caption = listColumns[i];


            //    if (listDataSources[i] != string.Empty)
            //    {
            //        string sql = string.Format("SELECT Id, Name FROM {0}", listDataSources[i]);
            //        DataTable dataTable = GetDataTable(sql);
            //        gc.ColumnEdit = new RepositoryItemLookUpEdit() { DataSource = dataTable, ValueMember = dataTable.Columns[0].ColumnName, DisplayMember = dataTable.Columns[1].ColumnName };
            //    }
            //    gc.OptionsColumn.AllowEdit = false;
            //    gridView1.Columns.Add(gc);
            //}
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