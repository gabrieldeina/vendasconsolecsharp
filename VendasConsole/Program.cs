using System;
using System.Xml;

namespace VendasConsole {
    class Program {
        static void Main(string[] args) {
            string[] menu = { "Sair", "Cadastrar Cliente", "Listar Clientes", "Cadastrar Vendedor", "Listar Vendedores",
                "Cadastrar Produto", "Listar Produtos", "Registrar Venda", "Listar Vendas", "Listar Vendas por Cliente" };

            int opcao;

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
                        break;
                    case 2:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }

            } while (opcao != 0);
        }
    }
}