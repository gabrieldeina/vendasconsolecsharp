using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views {
    class CadastrarCliente {
        public static void Renderizar() {
            Cliente c = new Cliente();

            Console.WriteLine(" --- CADASTRAR CLIENTE --- ");
            Console.Write("Informe o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.Write("Informe o cpf do cliente: ");
            c.Cpf = Console.ReadLine();
            if (ValidarCpf.Validar(c.Cpf)) {
                if (ClienteDAO.Cadastrar(c)) {
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                } else {
                    Console.WriteLine("O CPF desse cliente já está cadastrado!");
                }
            } else {
                Console.WriteLine("CPF inválido");
            }
        }
    }
}
