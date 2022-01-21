using System;

namespace Dio.Musics

{
    public class Musica : EntidadeBase
    {
        // Atrinutos 

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Cantor { get; set; }
        private int Ano { get; set; }

        private bool Excluido {get; set;}

        // Metodos

        public Musica(int id,Genero genero, string titulo, string cantor, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Cantor = cantor;
            this.Ano = ano;
            this.Excluido = false;
        }

          public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Cantor(a): " + this.Cantor + Environment.NewLine;
             retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}
          public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
		public string retornaCantor()
		{
			return this.Cantor;
		}
     public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir(){
            this.Excluido = true;
        }

    }
}