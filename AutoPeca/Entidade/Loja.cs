using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public class Loja : DadosGerais
    {
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public List<Venda> Vendas { get; set; } = new List<Venda>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Fornecedor> Fornecedors { get; set; } = new List<Fornecedor>();
        public string Endereco { get; set; }

        public override void Cadastrado()
        {
            Console.WriteLine("===============Cadastro da loja===============");
            Console.Write("Digite o nome da loja:");
            Nome = "Lata Velha"; //Console.ReadLine();

            Console.WriteLine($"Digite o endereço da loja {Nome}");
            Endereco = "Avenida jabaquara,2819";// Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nEndereco: {Endereco}";
        }
    }

}
