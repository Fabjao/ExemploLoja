using System;
using AutoPeca.Entidade;

namespace AutoPeca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Loja loja = new Loja();
            loja.Cadastrado();


            do {
                Console.Clear();
                Console.WriteLine($"Bem vindo a Loja {loja.Nome}");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Fornecedor");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Exibir Produto");
                Console.WriteLine("6 - Venda");
                Console.WriteLine("7 - Exibir Venda");
                Console.WriteLine("9 - Sair");
                Console.WriteLine();
                Console.Write("Digite uma opção:");
                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao) {
                    case 1:
                        Funcionario funcionario = new Funcionario();
                        funcionario.Cadastrado();
                        loja.Funcionarios.Add(funcionario);
                        break;
                    case 2:
                        Cliente cliente = new Cliente();
                        cliente.Cadastrado();
                        loja.Clientes.Add(cliente);
                        break;
                    case 3:
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Cadastrado();
                        loja.Fornecedors.Add(fornecedor);
                        break;
                    case 4:
                        Produto produto = new Produto();
                        produto.Cadastrar(loja.Fornecedors);
                        loja.Produtos.Add(produto);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("======Lista de Produtos========");
                        if (loja.Produtos.Count == 0) Console.WriteLine("Não existe nenhum produto cadastrado");                        
                        loja.Produtos.ForEach(p => {
                            Console.WriteLine(p);
                        });
                        Console.ReadKey();
                        break;
                    case 6:
                        Venda venda = new Venda();
                        venda.Cadastrar(loja);
                        loja.Vendas.Add(venda);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("======Lista de Vendas========");
                        if (loja.Vendas.Count == 0) Console.WriteLine("Não existe nenhum produto cadastrado");
                        Console.WriteLine();
                        loja.Vendas.ForEach(v => {
                            v.ExibirDados();
                            Console.WriteLine();
                        });
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Volte sempre");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida Digite novamente:");
                        Console.ReadKey();
                        break;
                }


            } while (true);

        }
    }
}
