using System;



namespace _1_avaliacao;

public class Medico:Funcionario
{
    public string Crm { get; set; }
    public double Horaextra { get; set; }
    public string Especialidade { get; set; }

    public Medico (string nome, string cpf, int matricula, DateTime datanas, string sexo, double salario, string crm, double horaextra, string especialidade) : base (nome, cpf, matricula, datanas, sexo,salario)         
    {
        Crm = crm;
        Horaextra = horaextra;
        Especialidade = especialidade;
    }   
    public void SalarioBeneficio()
    {
        double calculo = 22 / 100;
        double resul = Salario * calculo;
        double resul2 = Salario + resul;
    }
}
