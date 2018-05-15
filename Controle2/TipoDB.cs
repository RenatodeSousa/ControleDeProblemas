using Controle;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle2
{
    public class TipoDB
    {
        private DB db; 

        public bool insert (Tipo tipo)
        {
            try
            {
                string sql = "INSERT INTO DB_TIPO (DESCRICAO)" +
                         " VALUES ('" + tipo.Descricao + "')";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Tipo> ListarTipo()
        {//determinando o inicio e fim da classe db using
            using (db = new DB())//instancia a classe DB 
                                // delimitando o inicio e o fim
                                //inicio -> construtor da classe
                                //abre a conexao com a base de dados
                                //fim -> chama o metodo dispose()
                                //da interface(IDisposable)
                                //Fecha a conexao com o banco de dados
            {
                var sql = "SELECT id, descricao FROM DB_TIPO";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }
        // transformar retorno em lista
        private List<Tipo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listTipo = new List<Tipo>();
            //ler linha por linha na tabela retorno.read
            while (retorno.Read())
            {
                var item = new Tipo()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                };
                //preencher a lista com os dados da tabela
                listTipo.Add(item);
            }
            return listTipo;
        }
    }
}
