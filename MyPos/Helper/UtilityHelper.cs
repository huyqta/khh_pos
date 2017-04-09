using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPos.Helper
{
    public static class UtilityHelper
    {

        public static void ReadFileExcel(string filePath)
        {
            InitUnitsData();
            InitCategorysData();

            DataTable dtexcel = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            DataRow schemaRow = schemaTable.Rows[0];
            string sheet = schemaRow["TABLE_NAME"].ToString();
            if (!sheet.EndsWith("_"))
            {
                string query = "SELECT  * FROM [" + sheet + "]";
                OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
            }

            conn.Close();

            InitProductsData(dtexcel);
        }

        private static void InitUnitsData()
        {
            ProductModel model = new ProductModel();

            if (model.Units.Count() == 0)
            {
                List<string> listUnit = new List<string>();
                listUnit.Add("Tấm");
                listUnit.Add("Cái");
                listUnit.Add("Miếng");
                listUnit.Add("Kiện");
                listUnit.Add("Cục");
                listUnit.Add("Bó");
                listUnit.Add("Cuộn");
                listUnit.Add("Sợi");
                listUnit.Add("Cây");
                listUnit.Add("Mét");
                listUnit.Add("Ký");
                listUnit.Add("Cặp");
                listUnit.Add("Bộ");
                listUnit.Add("Bành");
                foreach (string dvt in listUnit)
                {
                    model.Units.Add(new Unit() { Name = dvt, Description = dvt });
                }
                model.SaveChanges();
            }
        }

        private static void InitCategorysData()
        {
            ProductModel model = new ProductModel();

            if (model.Categories.Count() == 0)
            {
                List<string> listCate = new List<string>();
                listCate.Add("Bao bì");
                listCate.Add("Bạt che");
                listCate.Add("Nylon");
                listCate.Add("Trang thiết bị");
                listCate.Add("Bảo hộ lao động");
                listCate.Add("Công cụ dụng cụ");
                listCate.Add("Dây, chỉ");
                listCate.Add("Lưới");
                listCate.Add("Xốp");
                listCate.Add("Vật tư");
                listCate.Add("Nhóm tạm");
                foreach (string dvt in listCate)
                {
                    model.Categories.Add(new Category() { Name = dvt, Description = dvt });
                }
                model.SaveChanges();
            }
        }

        private static void InitProductsData(DataTable dtexcel)
        {
            ProductModel model = new ProductModel();

            foreach (DataRow row in dtexcel.Rows)
            {
                var firstChar = row[0].ToString().Substring(0, 1).ToUpper();
                var capitalize = firstChar + row[0].ToString().Substring(1, row[0].ToString().Length - 1);
                if (!model.Products.Local.Any(p => p.Name.ToLower().Contains(capitalize.ToLower())))
                {
                    model.Products.Add(new Product()
                    {
                        CategoryId = GetCategoryIdByProduct(capitalize),
                        DefaultPrice = 0,
                        Description = string.Empty,
                        ImageUrl = string.Empty,
                        Name = capitalize,
                        UnitId = GetUnitIdByProduct(capitalize),
                    });
                }
            }
            model.SaveChanges();
        }

        private static int GetCategoryIdByProduct(string productName)
        {
            ProductModel model = new ProductModel();

            if (productName.ToLower().Contains("bao")) return model.Categories.Where(c => c.Name == "Bao bì").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("bạt")) return model.Categories.Where(c => c.Name == "Bạt che").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("nylon")
                || productName.ToLower().Contains("màng"))
                return model.Categories.Where(c => c.Name == "Nylon").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("lưới")) return model.Categories.Where(c => c.Name == "Lưới").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("xốp")) return model.Categories.Where(c => c.Name == "Xốp").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("áo")
                || productName.ToLower().Contains("quần")
                || productName.ToLower().Contains("mũ")
                || productName.ToLower().Contains("giày")
                || productName.ToLower().Contains("tay")
                || productName.ToLower().Contains("găng")
                || productName.ToLower().Contains("kính")
                || productName.ToLower().Contains("khẩu trang")
                || productName.ToLower().Contains("rọ")
                || productName.ToLower().Contains("ủng"))
                return model.Categories.Where(c => c.Name == "Bảo hộ lao động").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("dây")
                || productName.ToLower().Contains("chỉ")
                || productName.ToLower().Contains("đai")
                || productName.ToLower().Contains("bọ"))
                return model.Categories.Where(c => c.Name == "Dây, chỉ").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("băng keo")
                || productName.ToLower().Contains("túi")
                || productName.ToLower().Contains("ống")
                || productName.ToLower().Contains("phao")
                || productName.ToLower().Contains("túi"))
                return model.Categories.Where(c => c.Name == "Vật tư").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("xốp")) return model.Categories.Where(c => c.Name == "Xốp").FirstOrDefault().Id;
            else return model.Categories.Where(c => c.Name == "Nhóm tạm").FirstOrDefault().Id;
        }

        private static int GetUnitIdByProduct(string productName)
        {
            ProductModel model = new ProductModel();

            if (productName.ToLower().Contains("bao")) return model.Units.Where(c => c.Name == "Cái").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("bạt")) return model.Units.Where(c => c.Name == "Bành").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("nylon")
                || productName.ToLower().Contains("màng"))
                return model.Units.Where(c => c.Name == "Cây").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("lưới")) return model.Units.Where(c => c.Name == "Cây").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("xốp")) return model.Units.Where(c => c.Name == "Cái").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("áo")
                || productName.ToLower().Contains("quần")
                || productName.ToLower().Contains("mũ")
                || productName.ToLower().Contains("giày")
                || productName.ToLower().Contains("tay")
                || productName.ToLower().Contains("găng")
                || productName.ToLower().Contains("kính")
                || productName.ToLower().Contains("khẩu trang")
                || productName.ToLower().Contains("rọ")
                || productName.ToLower().Contains("ủng"))
                return model.Units.Where(c => c.Name == "Cái").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("dây")
                || productName.ToLower().Contains("chỉ")
                || productName.ToLower().Contains("đai")
                || productName.ToLower().Contains("bọ"))
                return model.Units.Where(c => c.Name == "Cuộn").FirstOrDefault().Id;
            else if (productName.ToLower().Contains("băng keo")
                || productName.ToLower().Contains("túi")
                || productName.ToLower().Contains("ống")
                || productName.ToLower().Contains("phao"))
                return model.Units.Where(c => c.Name == "Cái").FirstOrDefault().Id;
            else return model.Units.Where(c => c.Name == "Cái").FirstOrDefault().Id;
        }
    }
}
