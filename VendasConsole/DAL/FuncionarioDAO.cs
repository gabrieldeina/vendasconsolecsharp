using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;
using VendasConsole.Views;

namespace VendasConsole.DAL {
    class FuncionarioDAO {
        private static List<Funcionario> funcionarios = new List<Funcionario>();
        public static List<Funcionario> Listar() => funcionarios;
        public static Funcionario BuscarPorCpf(string cpf) {
            foreach (Funcionario funcionarioCadastrado in funcionarios) {
                if (funcionarioCadastrado.Cpf == cpf) {
                    return funcionarioCadastrado;
                }
            }
            return null;
        }
        public static bool Cadastrar(Funcionario funcionario) {
            if (BuscarPorCpf(funcionario.Cpf) == null) {
                funcionarios.Add(funcionario);
                return true;
            }
            return false;
        }

    }
}
