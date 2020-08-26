using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models {
    class Funcionario {
        //Construtores
        public Funcionario(string nome, string cpf) {
            Nome = nome;
            Cpf = cpf;
        }
        public Funcionario() {
            CriadoEm = DateTime.Now;
        }
        //Atributos
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString() {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
