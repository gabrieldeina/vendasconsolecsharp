using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class CadastrarProduto {
        public static void Renderizar() {
            Produto p = new Produto();

            Console.WriteLine(" --- CADASTRAR PRODUTO --- ");
            Console.Write("Informe o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Informe o valor do produto: ");
            p.Valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (ProdutoDAO.Cadastrar(p)) {
                Console.WriteLine("Produto cadastrado com sucesso!");
            } else {
                Console.WriteLine("O nome desse produto já está cadastrado!");
            }
        }
    }
}
