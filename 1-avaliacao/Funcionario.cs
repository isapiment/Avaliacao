using System;
using System.Security.Cryptography.X509Certificates;

//: nome, CPF,matrícula, data de nascimento, sexo, salário.
namespace _1_avaliacao;

public class Funcionario
{
    public string Nome { get; set; }    
    public string Cpf { get; set; }
    public int Matricula { get; set; }  
    public DateTime Datanas { get; set; }
    public string Sexo { get; set; }
    public double Salario { get; set; } 

    public Funcionario (string nome, string cpf, int matricula, DateTime datanas, string sexo, double salario)
    {
        Nome = nome;
        Cpf = cpf;
        Matricula = matricula;
        Datanas = datanas;
        Salario = salario;
        Sexo = sexo;
    }
}

