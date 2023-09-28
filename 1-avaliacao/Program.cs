using _1_avaliacao;
using System;


static void Main(string[] args)
   {
        Console.WriteLine("Seja Bem-vindo");
        Console.WriteLine("Escolha uma opção: 1- Cadastro de Medico, 2- Cadastro de Administrador");
        int opcao =  Convert.ToInt32(Console.ReadLine());
        
        
  else if (opcao == 1)
       {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Matricula: ");
            int matricula = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Data de Nascimento: ");
            DateTime datanas = Convert.ToDateTime( Console.ReadLine());

            Console.WriteLine("Sexo:");
            string sexo = Console.ReadLine();

            Console.WriteLine("Salario: ");
            double salario= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Crm:");
            string crm = Console.ReadLine();

            Console.WriteLine("Valor da hora extra :");
            double he = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Especialidade :");
            string especialidade = Console.ReadLine();

            Medico m = new Medico(nome,cpf,matricula,datanas, sexo, salario,crm,he, especialidade);
            m.SalarioBeneficio();
            List<Medico> lista = new List<Medico>();    
            lista.Add(m);
            
       }
       else if (opcao == 2)
       {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Matricula: ");
            int matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Data de Nascimento: ");
            DateTime datanas = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Sexo:");
            string sexo = Console.ReadLine();

            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Função:");
            string funcao= Console.ReadLine();

            Administrador ad = new Administrador(nome, cpf, matricula, datanas, sexo, salario, funcao);
            ad.Vale();
            List<Administrador> administradors = new List<Administrador>();
            administradors.Add(ad);
        }
   }

