using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class DB : IDisposable
    {
        private SqlConnection conexao;
        public DB()
        {
            conexao = new SqlConnection(

              ConfigurationManager.
              ConnectionStrings["ConexaoSQLServer"]
              .ConnectionString);
            conexao.Open();

        }

        public void Dispose()
        {
           if(conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public void ExecutaComamndo(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = System.Data.CommandType.Text,
                Connection = conexao

            };
            cmd.ExecuteNonQuery();
        }
    }
}
