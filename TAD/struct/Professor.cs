namespace Struct;

public struct Professor {
    public string nome;
    public float salario;
    public int cargaHoraria;
    public int falta;

    public Professor(string nome, float salario, int cargaHoraria, int falta){
        this.nome = nome;
        this.salario = salario;
        this.cargaHoraria = cargaHoraria;
        this.falta = falta;
    }

    public void ReajusteSalarialEmValor(float valor) {
        this.salario += valor;
    }

    public void ReajusteSalarialEmPorcentagem(float porcentagem) {
        this.salario = this.salario + (this.salario * porcentagem);
    }

    public void DescontoSlarialPorFaltaEmValor(float valor) {
        this.salario -= valor * falta;
    }

    public void DescontoSalarialPorFaltaEmPorcentagem(float porcentagem) {
        for (int i = 0; i < this.falta; i++) {
            this.salario = this.salario - (this.salario * porcentagem);
        }
    }

    public void AumentarCargaHorariaDeTrabalho(int cargaAumentar) {
        this.salario += (this.salario * (this.cargaHoraria + cargaAumentar)) / cargaHoraria;
        this.cargaHoraria += cargaAumentar;
    }

    public string Imprimir() {
        return $"Nome {this.nome} \nSalario {this.salario} \nCarga Horaria {this.cargaHoraria} \nFalta {this.falta}";
    }
}