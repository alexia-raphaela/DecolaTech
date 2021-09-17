namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        
        private string Titulo { get; set; }
        
        private string Descricao { get; set; }
        
        private int Ano { get; set; }

        // Métodos

        public Series(int: id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Enviroment.NewLine;
            retorno += "Título: " + this.Titulo + Enviroment.Newline;
            retorno += "Descrição: " + this.Descricao + Enviroment.Newline;
            retorno += "Ano de Início: " + this.Ano + Enviroment.Newline;
            return retorno
        }

        public string retornoTitulo()
        {
            return this.Título;
        }
        
        public int retornaId()
        {
            return this.Id;
        }
    }
}