namespace Struct;

public struct ClienteS
{
    //Dados da Struct
    public string nome;
    public string cpf;
    public string email;
    public string dataNascimento;

    public ClienteS(string nome, string cpf, string email, string dataNascimento)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.email = email;
        this.dataNascimento = dataNascimento;
    }

    //Operacoes da Struct

    public string Imprimir() {
        return $"Nome - {this.nome} \n CPF - {this.cpf} \n Data de Nascimento - {this.dataNascimento} \n Email - {this.email}";
    }

}