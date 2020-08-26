﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views {
    class ListarProdutos {
        public static void Renderizar() {

            Console.WriteLine(" --- LISTAR PRODUTOS --- ");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar()) {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
