namespace Struct;

public struct EquipeEsports {
    public string nome;
    public int anoDeEstreia;
    public int qtdCampeonatosVencidos;
    public float valorTotal;

    public EquipeEsports(string nome, int anoDeEstreia, int qtdCampeonatosVencidos, float valorTotal) {
        this.nome = nome;
        this.anoDeEstreia = anoDeEstreia;
        this.qtdCampeonatosVencidos = qtdCampeonatosVencidos;
        this.valorTotal = valorTotal;
    }

    public void RegistrarCampeonatoVencido(float valor) {
        this.qtdCampeonatosVencidos += 1;
        AtualizarValorTotalPremiacoes(valor);
    }
    public void AtualizarValorTotalPremiacoes(float valor) {
        this.valorTotal += valor;
    }

    public string VerificarAnoEstreia() {
        DateTime now = DateTime.Now;
        if(this.anoDeEstreia == now.Year){
            return "Novata";
        }
        return "Veterana";
    }
    public string Imprimir() {
        return $"\nNome: {this.nome} \nAno de Estreia: {this.anoDeEstreia}\nQuantidade de Vitorias de Campeonatos: {this.qtdCampeonatosVencidos}\n Valor Total: {this.valorTotal}";
    }

}