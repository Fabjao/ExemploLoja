using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public class Venda : Base
    {
        public List<VendaItem> Items { get; set; } = new List<VendaItem>();
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public double Total { get; set; }

        public void Cadastrar(Loja loja)
        {

            void sempre()
            {
                Console.Clear();
                Console.WriteLine("============Venda=============");
            };

            sempre();

            if (loja.Clientes.Count == 0) {
                Console.WriteLine("Cadastre pelo menos 1 cliente");
                Console.ReadKey();
                return;
            }

            if (loja.Produtos.Count == 0) {
                Console.WriteLine("Cadastre pelo menos 1 Produto");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("=====Clientes======");
            loja.Clientes.ForEach(c => {
                Console.WriteLine(c);
            });
            Console.WriteLine("Digite o codigo do cliente");
            int codigoCliente = int.Parse(Console.ReadLine());

            Cliente = loja.Clientes.Find(c => c.Id == codigoCliente);

            sempre();
            Console.WriteLine("=====Funcionario======");
            loja.Funcionarios.ForEach(f => {
                Console.WriteLine(f);
            });
            Console.WriteLine("Digite o codigo do funcionario");
            int.TryParse(Console.ReadLine(), out int codigoFuncionario);
            if (codigoFuncionario != 0)
                Funcionario = loja.Funcionarios.Find(f => f.Id == codigoFuncionario);

            string teste = string.Empty;
            do {
                sempre();
                Console.WriteLine("==========Lista de Produtos===========");
                loja.Produtos.ForEach(p => {
                    Console.WriteLine(p);
                });

                Console.WriteLine("Digite a quantidade:");
                int.TryParse(Console.ReadLine(), out int quantidade);

                Console.WriteLine("Digite o codigo do produto");
                int.TryParse(Console.ReadLine(), out int codigoProduto);
                Produto produto = loja.Produtos.Find(p => p.Id == codigoProduto);

                VendaItem item = new VendaItem();
                item.Produto = produto;
                item.Quantidade = quantidade;
                Items.Add(item);
                Total += (produto.Preco * quantidade);

                Console.WriteLine("Deseja comparar mais, caso não digite sair");
                teste = Console.ReadLine().ToUpper();

            } while (teste != "SAIR");

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Funcionario:{this.Funcionario.Nome}");
            Console.WriteLine($"Cliente: {this.Cliente.Nome}");
            Items.ForEach(p => {
                Console.WriteLine($"Id:{p.Produto.Id} Nome:{p.Produto.Nome} Quantidade:{p.Quantidade} - preço:{p.Produto.Preco}");
            });
            Console.WriteLine($"Total:{Total}");
        }

    }
}
