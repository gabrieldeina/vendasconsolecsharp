using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models {
    class Produto {
        //Construtores
        public Produto(string nome, double valor, int quantidade) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        public Produto() {
            CriadoEm = DateTime.Now;
        }
        //Atributos
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() {
            return $"Nome: {Nome} | Valor: {Valor} | Quantidade: {Quantidade} | Criado em: {CriadoEm}";
        }
    }
}
