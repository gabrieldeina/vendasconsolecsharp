using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class CadastrarVenda {
        public static void Renderizar() {
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Funcionario f = new Funcionario();
            Produto p = new Produto();

            Console.WriteLine(" ----- CADASTRAR VENDA ---- \n");
            Console.Write("Digite o CPF do cliente: ");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarPorCpf(c.Cpf);
            if (c != null) {
                venda.Cliente = c;

                Console.Write("Digite o CPF do funcionário: ");
                f.Cpf = Console.ReadLine();
                f = FuncionarioDAO.BuscarPorCpf(f.Cpf);
                if (f != null) {
                    venda.Funcionario = f;

                    Console.Write("Digite o nome do produto: ");
                    p.Nome = Console.ReadLine();
                    p = ProdutoDAO.BuscarPorNome(p.Nome);
                    if (p != null) {
                        venda.Produto = p;
                        Console.Write("Digite a quantidade do produto: ");
                        venda.Quantidade = Convert.ToInt32(Console.ReadLine());
                        VendaDAO.Cadastrar(venda);
                        Console.WriteLine("Venda cadastrada com sucesso!!!");
                    } else {
                        Console.WriteLine("Esse produto não existe!!!");
                    }
                } else {
                    Console.WriteLine("Esse funcionário não existe!!!");
                }
            } else {
                Console.WriteLine("Esse cliente não existe!!!");
            }
        }
    }
}
