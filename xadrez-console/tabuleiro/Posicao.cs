namespace tabuleiro {
    internal class Posicao {
        //atributos
        public int linha { get; set; } 
        public int coluna { get; set; }

        //construtores
        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString() {
            return $"{linha}, {coluna}";
        }

    }
}
