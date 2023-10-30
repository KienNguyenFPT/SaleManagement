using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_Solution.Models
{
    public class DBContext
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-V3HIBDP6;Initial Catalog=SaleManagement;Persist Security Info=True;User ID=sa;Password=trungkien;TrustServerCertificate=true");
        public SqlConnection GetConn()
        {
            return connection;
        }

        public void OpenConn()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();  
            }
        }

        public void CloseConn() {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
