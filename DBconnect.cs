using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBconnect
    {
        private static DBconnect instance;

        public static DBconnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBconnect();
                }
                return instance;
            }
            private set => instance = value;
        }

        private DBconnect() { }

        string connectionStr = @"Data Source=LAPTOP-8FSMF75E\SQLEXPRESS;Initial Catalog=QLMS;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string param in listPara)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, parameters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            return dt;
        }
    }
}
