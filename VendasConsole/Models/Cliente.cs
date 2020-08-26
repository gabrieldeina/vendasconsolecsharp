using System;

namespace VendasConsole.Models {
    class Cliente {
        //Construtores
        public Cliente(string nome, string cpf) {
            Nome = nome;
            Cpf = cpf;
        }
        public Cliente() {
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
