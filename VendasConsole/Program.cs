using System;
using System.Collections.Generic;
using System.Xml;

namespace VendasConsole {
    class Program {
        static void Main(string[] args) {
            string[] menu = { "Sair", "Cadastrar Cliente", "Listar Clientes", "Cadastrar Vendedor", "Listar Vendedores",
                "Cadastrar Produto", "Listar Produtos", "Registrar Venda", "Listar Vendas", "Listar Vendas por Cliente" };

            int opcao;
            Cliente c = new Cliente();
            List<Cliente> clientes = new List<Cliente>();
            bool clienteEncontrado = false;

            do {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++) {
                    Console.WriteLine(i + " - " + menu[i]);
                }
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao) {
                    case 1:
                        c = new Cliente();
                        Console.WriteLine(" --- CADASTRAR CLIENTE --- ");
                        Console.Write("Informe o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.Write("Informe o cpf do cliente: ");
                        c.Cpf = Console.ReadLine();

                        if (clientes.Count == 0) {
                            clientes.Add(c);
                        } else {
                            foreach (Cliente clienteCadastrado in clientes) {
                                if (clienteCadastrado.Cpf == c.Cpf) {
                                    Console.WriteLine("Esse cliente já existe");
                                    clienteEncontrado = true;
                                }
                            }
                            if (!clienteEncontrado) {
                                clientes.Add(c);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine(" --- LISTAR CLIENTES --- ");
                        for (int i = 0; i < clientes.Count; i++) {
                            Console.WriteLine(clientes[i].Nome);
                        }
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nAperte uma tecla qualquer...");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}