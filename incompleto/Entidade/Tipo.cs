namespace Entidade
{
    public class Tipo
    {

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion

        public override string ToString()
        {
            return "ID: " +this.Id+
                "\n Descricao: " + this.Descricao;
        }
    }
}