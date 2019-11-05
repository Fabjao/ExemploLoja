using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public class Cliente : DadosGerais
    {
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public override void Cadastrado()
        {
            Console.Clear();
            Console.WriteLine("=======Cadastro Cliente==========");
            Console.Write("Digite o nome:");
            Nome = Console.ReadLine();
            Console.Write($"Digite o documento do {Nome}");
            Documento = Console.ReadLine();
            Console.WriteLine("Sexo");
            Sexo = Console.ReadLine();
            Console.WriteLine("Idade");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Cliente Cadastro com sucesso!");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Id:{Id} - Nome:{Nome}";
        }
    }
}
