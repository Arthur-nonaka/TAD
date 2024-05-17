namespace Struct;

public struct Produto {
    public string nome;
    public int quantidade;
    public float valor;

    public Produto(string nome, int quantidade, float valor){
        this.nome = nome;
        this.quantidade = quantidade;
        this.valor = valor;
    }

    public float AplicarCupomDeDescontoValor(float desconto) {
        return this.valor - desconto;
    }

    public float AplicarCupomDescontoPorcentagem(float desconto) {
        return this.valor - (this.valor * desconto);
    }

    public int VerificarQuantidadeEmEstoque() {
        return this.quantidade;
    }

    public string Imprimir() {
        return $"Nome {this.nome} \nQuantidade {this.quantidade} \nValor {this.valor}";
    }
}