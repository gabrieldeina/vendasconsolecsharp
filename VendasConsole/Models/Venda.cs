using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models {
    class Venda {
        public Venda() {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            List<Produto> produtos = new List<Produto>();
        }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Produto> Produtos { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
