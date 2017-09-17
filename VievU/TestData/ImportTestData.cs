using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievU.TestData
{
    class ImportTestData
    {
        public void importTestData()
        {
            var fileName = string.Format(@"F:\TestData\TestData.xlsx");
            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;data source="+fileName+";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;\"");

            var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(ds,"Data");
            dt = ds.Tables["Data"];

            var count = dt.Columns.Count;

            foreach (DataRow dr in dt.Rows)
            {
                string Module = dr[0].ToString();
                string Submodule = dr[1].ToString();
                string TestCase = dr[2].ToString();
                string ExpectedResult = dr[3].ToString();
                string FieldName = dr[4].ToString();
                string FieldValue = dr[5].ToString();
               
            }


        }
    }
}
