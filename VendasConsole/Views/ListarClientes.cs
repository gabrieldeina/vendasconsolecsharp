using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class ListarClientes {
        public static void Renderizar() {
            Cliente c = new Cliente();

            Console.WriteLine(" --- LISTAR CLIENTES --- ");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar()) {
                Console.WriteLine(clienteCadastrado);
            }
        }
    }
}
