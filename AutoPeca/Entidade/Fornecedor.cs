using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public class Fornecedor : DadosGerais
    {
        public override void Cadastrado()
        {
            Console.Clear();
            Console.WriteLine("=======Cadastro Fornecedor==========");
            Console.Write("Digite o nome:");
            Nome = Console.ReadLine();
            Console.Write($"Digite o documento do {Nome}");
            Documento = Console.ReadLine();
            Console.WriteLine("Fornecedor Cadastro com sucesso!");
            Console.ReadKey();
        }
    }
}
