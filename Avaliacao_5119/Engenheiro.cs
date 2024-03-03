using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_5119
{
    internal class Engenheiro
    {
        public Funcionario Func { get; set; }
        public string Projeto { get; set; }

        public Engenheiro()
        {
            Func = new Funcionario();
            Projeto = string.Empty;
        }

        public Engenheiro(Funcionario f, string proj)
        {
            Func = f;
            Projeto = proj;
        }


        public override string ToString()
        {
            return Func.printFunc() + "\nProjeto: " + Projeto;
        }
    }
}
