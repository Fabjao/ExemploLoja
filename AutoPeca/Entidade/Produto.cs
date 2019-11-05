using System;
using System.Collections.Generic;
using AutoPeca.Entidade;
using System.Globalization;

namespace AutoPeca.Entidade
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public void Cadastrar(List<Fornecedor> fornecedores)
        {
            Console.Clear();
            Console.WriteLine("=============Cadastro de Produto==============");
            //Todo, só deve cadastrar um produto se houve mais de um fornecedor
            if (fornecedores.Count == 0) {
                Console.WriteLine("Cadastre um fornecedor primeiro");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("===Lista de fornecedores=====");
            fornecedores.ForEach(f => {
                Console.WriteLine($"Codigo: {f.Id} Nome:{f.Nome}");
            });
            Console.WriteLine("Digite o código");
            int codigo = int.Parse(Console.ReadLine());
            Fornecedor fornecedor = fornecedores.Find(f => f.Id == codigo);

            this.Fornecedor = fornecedor;

            Console.WriteLine();
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o Preço:");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"id:{Id} - Nome:{Nome}" +
                $"\n Fornecedor: Id:{this.Fornecedor.Id} - Nome:{this.Fornecedor.Nome}";
        }
    }
}
