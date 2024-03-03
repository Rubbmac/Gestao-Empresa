using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_5119
{
    internal class Diretor
    {
        public Funcionario Func { get; set; }
        public string Departamento { get; set; }
       
        public Diretor() {
            Func=new Funcionario();
            Departamento = string.Empty;
        }

        public Diretor(Funcionario f, string dep)
        {
            Func=f;
            Departamento = dep;
        }

        public override string ToString()
        {
            return Func.printFunc() + "\nDepartamento: " + Departamento;
        }
    }
}
