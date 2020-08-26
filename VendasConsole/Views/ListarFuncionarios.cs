using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class ListarFuncionarios {
        public static void Renderizar() {

            Console.WriteLine(" --- LISTAR PRODUTOS --- ");
            foreach (Funcionario funcionarioCadastrado in FuncionarioDAO.Listar()) {
                Console.WriteLine(funcionarioCadastrado);
            }
        }
    }
}
