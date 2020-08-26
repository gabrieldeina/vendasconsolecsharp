using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL {
    class ProdutoDAO {
        private static List<Produto> produtos = new List<Produto>();
        public static List<Produto> Listar() => produtos;
        public static Produto BuscarPorNome(string nome) {
            foreach (Produto produtoCadastrado in produtos) {
                if (produtoCadastrado.nome == nome) {
                    return produtoCadastrado;
                }
            }
            return null;
        }
        public static bool Cadastrar(Produto produto) {
            if (BuscarPorNome(produto.nome) == null) {
                produtos.Add(produto);
                return true;
            }
            return false;
        }
    }
}
