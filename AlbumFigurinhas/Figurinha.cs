namespace AlbumFigurinhas
{
    public class Figurinha
    {
        public int NumeroCarta { get; set; }
        public string NomeJogador { get; set; }
        public string Selecao { get; set; }
        public int NumeroCamisa { get; set; }

        public Figurinha(int numerocarta, string nomejogador, string selecao, int numerocamisa)
        {
            this.NumeroCarta = numerocarta;
            this.NomeJogador = nomejogador;
            this.Selecao = selecao;
            this.NumeroCamisa = numerocamisa;
        }

        public string GetResumo()
        {
            return $"Figurinha \nNúmero da carta:{NumeroCarta} \nSeleção:{Selecao} /nNúmero da camisa:{NumeroCamisa}";
        }
    }
}