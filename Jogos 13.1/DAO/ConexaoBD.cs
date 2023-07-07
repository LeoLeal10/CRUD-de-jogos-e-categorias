using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection getConnection()
        {
            string strConexao = "data source=DESKTOP-AUHG4DS\\SQLEXPRESS;database=auladb;user id=sa;password=123456";
            SqlConnection sqlConnection = new SqlConnection(strConexao);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
