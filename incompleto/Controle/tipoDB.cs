using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class TipoDB
    {
        private DB db;

        public bool insert(TipoDB tipo)
        {
            try
            {


                String sql = "INSERT INTO TB_TIPO (DESCRICAO)" + "VALUES (" + tipo.Descricao + ")";

                using (db = new DB())
                {
                    db.ExecutaComamndo(sql);
                }
            }
            catch (Exception)
            {
                return true;
            }
                return false;
            }


    }
        }
    


