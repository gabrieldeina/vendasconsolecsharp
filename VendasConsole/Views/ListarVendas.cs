using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class ListarVendas {
        public static void Renderizar() {

            double totalGeral = 0, totalVenda = 0, totalItem = 0;

            Console.WriteLine(" --- LISTAR VENDAS --- ");
            foreach (Venda vendaCadastrada in VendaDAO.Listar()) {
                totalVenda = 0;
                Console.WriteLine($"\nCliente: {vendaCadastrada.Cliente.Nome}");
                Console.WriteLine($"Funcionário: {vendaCadastrada.Funcionario.Nome}");
                Console.WriteLine("\n ---- ITENS DA VENDA ---- \n");
                Console.WriteLine($"Produto: {vendaCadastrada.Produto.Nome}");
                totalItem = vendaCadastrada.Quantidade * vendaCadastrada.Produto.Valor;
                Console.WriteLine($"Produto: {vendaCadastrada.Produto.Valor:C2} " +
                    $"x {vendaCadastrada.Quantidade} = {totalItem:C2}");
                totalVenda += totalItem;
                Console.WriteLine($"Total da venda: {totalVenda:C2}");
                totalGeral += totalVenda;
            }

            Console.WriteLine($"Total geral: {totalGeral:C2}");
        }
    }
}
