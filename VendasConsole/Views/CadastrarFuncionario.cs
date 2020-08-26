using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views {
    class CadastrarFuncionario {
        public static void Renderizar() {
            Funcionario f = new Funcionario();

            Console.WriteLine(" --- CADASTRAR FUNCIONARIO --- ");
            Console.Write("Informe o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.Write("Informe o cpf do funcionário: ");
            f.Cpf = Console.ReadLine();
            if (ValidarCpf.Validar(f.Cpf)) {
                if (FuncionarioDAO.Cadastrar(f)) {
                    Console.WriteLine("Funcionário cadastrado com sucesso!");
                } else {
                    Console.WriteLine("O CPF desse funcionário já está cadastrado!");
                }
            } else {
                Console.WriteLine("CPF inválido");
            }
        }
    }
}
