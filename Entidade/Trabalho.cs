using System;
using System.Collections.Generic;
using System.Text;

namespace Entidade
{
    class Trabalho
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return "Id: " + this.Id +
                "\nNome: "+ this.Nome+"\nPontuacao" + this.Pontuacao;
        }

        #endregion
    
}
}
