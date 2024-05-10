namespace Struct;

public struct JogadorFutebol {
   public string nome;
   public string clube;
   public string posicao;
   public int amarelos;
   public int vermelhos;

   public JogadorFutebol(string nome, string clube, string posicao, int amarelos, int vermelhos){
    this.nome = nome;
    this.clube = clube;
    this.posicao = posicao;
    this.amarelos = amarelos;
    this.vermelhos = vermelhos;
   }

    public void RegistarNumeroCartoesAmarelos(int quantidade) {
        this.amarelos += quantidade;
    }

    public void RegistarNumeroCartoesVermelhos(int quantidade) {
        this.vermelhos += quantidade;
    }

    public string VerificarVinculoClube() {
        return this.clube;
    }

    public string Imprimir() {
        return $"\nNome: {this.nome} \nClube: {this.clube}\nPosicao: {this.posicao}\nAmarelos: {this.amarelos}/Vermelhos: {this.vermelhos}";
    }

}