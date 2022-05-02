using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        private static string s = @"Data Source=LAPTOP-KTJ09GK5\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security=True";
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private SqlConnection cnn;
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            //SqlCommand cmd = new SqlCommand(query, cnn);
            //SqlDataReader r;
            //dt.Columns.AddRange(new DataColumn[] {
            //    new DataColumn {ColumnName = "ID", DataType = typeof(int)},
            //    new DataColumn {ColumnName = "TenTK", DataType = typeof(string)},
            //    new DataColumn {ColumnName = "MKhau", DataType = typeof(string)}
            //});
            //cnn.Open();
            //r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    dt.Rows.Add(
            //        Convert.ToInt32(r[0].ToString()),
            //        r[1].ToString(),
            //        r[2].ToString()
            //        );
            //}
            //cnn.Close();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            da.Fill(dt);
            return dt;
        }
    }
}