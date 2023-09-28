using System;



namespace _1_avaliacao;

public class Administrador:Funcionario
{
    public string Funcao { get; set; }

    public Administrador  (string nome, string cpf, int matricula, DateTime datanas, string sexo, double salario,string funcao): base (nome, cpf, matricula, datanas, sexo, salario)
    {
        Funcao = funcao;
    }
    public void Vale()
    {
        double cal = 17 / 100;
        double result = Salario * cal;
        double resultado = Salario + result;
    }
}


