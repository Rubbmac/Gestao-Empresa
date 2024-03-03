using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_5119
{
    internal class Assistentes
    {
        public Funcionario Func { get; set; }
        public string Gestor { get; set; }

        public Assistentes()
        {
            Func = new Funcionario();
            Gestor = string.Empty;
        }

        public Assistentes(Funcionario f, string ges)
        {
            Func = f;
            Gestor = ges;
        }

        public override string ToString()
        {
            return Func.printFunc() + "\nGestor: " + Gestor;
        }

    }
}
