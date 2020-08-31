using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Utils {
    class Dados {
        public static void Inicializar() {
            Cliente cliente = new Cliente {
                Nome = "Gabriel Deina",
                Cpf = "09792676929"
            };
            ClienteDAO.Cadastrar(cliente);

            Funcionario funcionario = new Funcionario {
                Nome = "Gabriel Deina", Cpf = "09792676929"
            };
            FuncionarioDAO.Cadastrar(funcionario);

            Produto produto = new Produto {
                Nome = "iPhone", Valor = 2399.99, Quantidade = 10
            };
            ProdutoDAO.Cadastrar(produto);
        }
    }
}
