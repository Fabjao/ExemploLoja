using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public class Funcionario : DadosGerais
    {
        public string Sexo { get; set; }
        public int Idade { get; set; }

        public override void Cadastrado()
        {
            Console.Clear();
            Console.WriteLine("=======Cadastro Funcionario==========");
            Console.Write("Digite o nome:");
            Nome = Console.ReadLine();
            Console.Write($"Digite o documento do {Nome}");
            Documento = Console.ReadLine();
            Console.WriteLine("Sexo");
            Sexo = Console.ReadLine();
            Console.WriteLine("Idade");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Funcionario Cadastro com sucesso!");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Id:{Id} - Nome:{Nome}";
        }
    }
}
