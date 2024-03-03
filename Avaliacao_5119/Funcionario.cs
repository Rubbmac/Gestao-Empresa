using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_5119
{
    internal class Funcionario
    {

        public int IdFunc { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }
        public string Funcao { get; set; }

        public Funcionario() { 
            IdFunc= 0;
            Nome = string.Empty;
            Salario = 0;
            Funcao = "null";
        }
        public Funcionario(int id, string nome, int sal, string f) {
            IdFunc = id;
            Nome = nome;
            Salario = sal;
            Funcao = f;
        }
        public string printFunc() {
            return  "\nId: " + IdFunc +
                    "\nNome: " + Nome +
                    "\nSalario: " + Salario +
                    "\nFunção: " + Funcao;
        }
    }
}
