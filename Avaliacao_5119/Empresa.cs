using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Avaliacao_5119
{
    internal class Empresa
    {
        public int IDglobal { get; set; }
        public Funcionario[] funcionarios = new Funcionario[100];
        public Diretor[] diretores = new Diretor[100];
        public Assistentes[] assistentes = new Assistentes[100];
        public Engenheiro[] engenheiros = new Engenheiro[100];         
 
        public void AdicionaDiretor()
        {
            Console.Clear();
            bool b = false;
            string nome, departamento;
            int salario = 0;
            Console.WriteLine("\n*****\tAdicinar Diretor   *****");


            Console.WriteLine("Insira o nome: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                nome = Console.ReadLine();
                if (nome == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o nome: "); } else { b = true; }
            } while (!b);


            Console.WriteLine("Insira o departamento: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                departamento = Console.ReadLine();
                if (departamento == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o departamento: "); } else { b = true; }
            } while (!b);

            //proximo do while irá confirmar se o o valor inserido é válido ou não
            do
            {
                Console.WriteLine("Insira o salario bruto: ");
                string s = Console.ReadLine();
                b = false;
                foreach (char c in s) //percorre a string inserida e verifica se existe algum caracter que não seja digito
                {
                    if (!char.IsDigit(c)&&c!='.')
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }
                if (b) { salario = int.Parse(s); }
            } while (!b);

            // depois de todos os valores serem verificados, irá ser feita a criação do Diretor se o user confirmar
            string confirmacao;
            Console.WriteLine($"Por favor confirme os dados:\nNome: {nome}\nSalario: {salario}\nDepartamento: {departamento}\nDeseja adicionar? (s/n)");            
            do
            {
                confirmacao= Console.ReadLine();
                confirmacao = confirmacao.ToLower();
                if (confirmacao != "s" && confirmacao != "n")
                {
                    Console.WriteLine("\t\t*****Erro*****\n\nDeseja adicionar? (s/n)");
                }
            } while (confirmacao!="s"&&confirmacao!="n");
            if (confirmacao=="s")
            {
                funcionarios[IDglobal] = new Funcionario(IDglobal, nome, salario, "Diretor");
                diretores[IDglobal] = new Diretor(funcionarios[IDglobal], departamento);
                engenheiros[IDglobal] = new Engenheiro();
                assistentes[IDglobal] = new Assistentes();
                IDglobal++;
                Console.WriteLine("Funcionário adicionado com sucesso!"); 
                Thread.Sleep(1000);
            }
            else { Console.WriteLine("Funcionário não adicionado");Thread.Sleep(1000) ; }
            
        }

        public void AdicionaEngenheiro()
        {
            Console.Clear();
            bool b = false;
            string nome, projeto;
            int salario = 0;
            Console.WriteLine("\n*****\tAdicinar Engenheiro   *****");


            Console.WriteLine("Insira o nome: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                nome = Console.ReadLine();
                if (nome == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o nome: "); } else { b = true; }
            } while (!b);


            Console.WriteLine("Insira o projeto: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                projeto = Console.ReadLine();
                if (projeto == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o projeto: "); } else { b = true; }
            } while (!b);

            //proximo do while irá confirmar se o o valor inserido é válido ou não
            do
            {
                Console.WriteLine("Insira o salario bruto: ");
                string s = Console.ReadLine();
                b = false;
                foreach (char c in s) //percorre a string inserida e verifica se existe algum caracter que não seja digito
                {
                    if (!char.IsDigit(c))
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }
                if (b) { salario = int.Parse(s); }
            } while (!b);

            // depois de todos os valores serem verificados, irá ser feita a criação do Engenheiro
            string confirmacao;
            Console.WriteLine($"Por favor confirme os dados:\nNome: {nome}\nSalario: {salario}\nProjeto: {projeto}\nDeseja adicionar? (s/n)");
            do
            {
                confirmacao = Console.ReadLine();
                confirmacao = confirmacao.ToLower();
                if (confirmacao != "s" && confirmacao != "n")
                {
                    Console.WriteLine("\t\t*****Erro*****\n\nDeseja adicionar? (s/n)");
                }
            } while (confirmacao != "s" && confirmacao != "n");
            if (confirmacao == "s")
            {
                funcionarios[IDglobal] = new Funcionario(IDglobal, nome, salario, "Engenheiro");
                engenheiros[IDglobal] = new Engenheiro(funcionarios[IDglobal], projeto);
                diretores[IDglobal] = new Diretor();
                assistentes[IDglobal] = new Assistentes();
                IDglobal++;
                Console.WriteLine("Funcionário adicionado com sucesso!");
                Thread.Sleep(1000);
            }
            else { Console.WriteLine("Funcionário não adicionado"); Thread.Sleep(1000); }
            
        }

        public void AdicionaAssistente()
        {
            Console.Clear();
            bool b = false;
            string nome, gestor;
            int salario = 0;
            Console.WriteLine("\n*****\tAdicinar Assistente   *****");


            Console.WriteLine("Insira o nome: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                nome = Console.ReadLine();
                if (nome == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o nome: "); } else { b = true; }
            } while (!b);


            Console.WriteLine("Insira o gestor: ");
            // proximo do-while irá verificar se o nome foi inserido ou não
            do
            {
                gestor = Console.ReadLine();
                if (gestor == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o gestor: "); } else { b = true; }
            } while (!b);

            //proximo do while irá confirmar se o o valor inserido é válido ou não
            do
            {
                Console.WriteLine("Insira o salario bruto: ");
                string s = Console.ReadLine();
                b = false;
                foreach (char c in s) //percorre a string inserida e verifica se existe algum caracter que não seja digito
                {
                    if (!char.IsDigit(c))
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }
                if (b) { salario = int.Parse(s); }
            } while (!b);

            // depois de todos os valores serem verificados, irá ser feita a criação do Assistente
            string confirmacao;
            Console.WriteLine($"Por favor confirme os dados:\nNome: {nome}\nSalario: {salario}\nGestor: {gestor}\nDeseja adicionar? (s/n)");
            do
            {
                confirmacao = Console.ReadLine();
                confirmacao = confirmacao.ToLower();
                if (confirmacao != "s" && confirmacao != "n")
                {
                    Console.WriteLine("\t\t*****Erro*****\n\nDeseja adicionar? (s/n)");
                }
            } while (confirmacao != "s" && confirmacao != "n");
            if (confirmacao == "s")
            {
                funcionarios[IDglobal] = new Funcionario(IDglobal, nome, salario, "Assistente");
                assistentes[IDglobal] = new Assistentes(funcionarios[IDglobal], gestor);
                diretores[IDglobal] = new Diretor();
                engenheiros[IDglobal] = new Engenheiro();
                IDglobal++;
                Console.WriteLine("Funcionário adicionado com sucesso!");
                Thread.Sleep(1000);
            }
            else { Console.WriteLine("Funcionário não adicionado"); Thread.Sleep(1000); }
            
        }

        public void relatorioSalarios(string str)
        {
            string cont;
            int soma = 0;
            if (str=="1")
            {
                //todos os funcionarios
                for (int i = 1; i < IDglobal; i++)
                {
                    soma += funcionarios[i].Salario;
                }
                Console.WriteLine($"A soma do salário de todos os funcionários é: {soma} euros.");                
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else if (str=="2")
            {
                //diretores
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao=="Diretor")
                    {
                        soma += funcionarios[i].Salario;
                    }
                }
                Console.WriteLine($"A soma do salário de todos os diretores é: {soma} euros.");
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else if (str=="3")
            {
                //engenheiros
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao == "Engenheiro")
                    {
                        soma += funcionarios[i].Salario;
                    }
                }
                Console.WriteLine($"A soma do salário de todos os diretores é: {soma} euros.");
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else
            {
                //assistentes
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao == "Assistente")
                    {
                        soma += funcionarios[i].Salario;
                    }
                }
                Console.WriteLine($"A soma do salário de todos os funcionários é: {soma} euros.");
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
        }

        public void salarioMaisAlto(string str)
        {
            string cont;
            int max = 0;
            int id; // ficou aqui devido à alteração da classe program para empresa
            if (str == "1")
            {
                //todos os funcionarios
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Salario>max)
                    {
                        max= funcionarios[i].Salario;
                    }
                }
                Console.WriteLine($"O funcionário com salário mais alto é/são: ");
                for (int e = 1; e < IDglobal; e++)
                {
                    if (funcionarios[e].Salario==max)
                    {
                        printPorID(e);
                    }
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else if (str == "2")
            {
                //diretores
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao == "Diretor")
                    {
                        if (funcionarios[i].Salario > max)
                        {
                            max = funcionarios[i].Salario;
                        }
                    }
                }
                Console.WriteLine($"O Diretor com salário mais alto é/são: ");
                for (int e = 1; e < IDglobal; e++)
                {
                    if (funcionarios[e].Salario == max)
                    {
                        Console.WriteLine(printDiretor(e));
                    }
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else if (str == "3")
            {
                //engenheiros
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao == "Engenheiro")
                    {
                        if (funcionarios[i].Salario > max)
                        {
                            max = funcionarios[i].Salario;
                        }
                    }
                }
                Console.WriteLine($"O Engenheiro com salário mais alto é/são: ");
                for (int e = 1; e < IDglobal; e++)
                {
                    if (funcionarios[e].Salario == max)
                    {
                        Console.WriteLine(printEngen(e));
                    }
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
            else
            {
                //assistentes
                for (int i = 1; i < IDglobal; i++)
                {
                    if (funcionarios[i].Funcao == "Assistente")
                    {
                        if (funcionarios[i].Salario > max)
                        {
                            max = funcionarios[i].Salario;
                        }
                    }
                }
                Console.WriteLine($"O assistente com salário mais alto é/são: ");
                for (int e = 1; e < IDglobal; e++)
                {
                    if (funcionarios[e].Salario == max)
                    {
                        Console.WriteLine(printAssist(e));
                    }
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                cont = Console.ReadLine();
            }
        }

        public void alteraInformacao(int num, int id)
        {
            bool b;
            if (num==1)
            {
                string nome;
                Console.WriteLine("Insira o novo nome: ");
                do
                {
                    nome = Console.ReadLine();
                    if (nome == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o nome: "); } else { b = true; }
                } while (!b);
                if (funcionarios[id].Funcao == "Diretor")
                {
                    funcionarios[id].Nome = nome;
                    diretores[id].Func.Nome = nome;
                }
                else if (funcionarios[id].Funcao == "Engenheiro")
                {
                    funcionarios[id].Nome = nome;
                    engenheiros[id].Func.Nome = nome;
                }
                else
                {
                    funcionarios[id].Nome = nome;
                    assistentes[id].Func.Nome = nome;
                }
            }
            else if (num==2)
            {
                int salario=0;
                Console.WriteLine("Insira o novo salário: ");
                do
                {
                    Console.WriteLine("Insira o salario bruto: ");
                    string s = Console.ReadLine();
                    b = false;
                    foreach (char c in s) //percorre a string inserida e verifica se existe algum caracter que não seja digito
                    {
                        if (!char.IsDigit(c))
                        {
                            b = false;
                            break;
                        }
                        else
                        {
                            b = true;
                        }
                    }
                    if (b) { salario = int.Parse(s); }
                } while (!b);
                if (funcionarios[id].Funcao == "Diretor")
                {
                    funcionarios[id].Salario = salario;
                    diretores[id].Func.Salario = salario;
                }
                else if (funcionarios[id].Funcao == "Engenheiro")
                {
                    funcionarios[id].Salario = salario;
                    engenheiros[id].Func.Salario = salario;
                }
                else
                {
                    funcionarios[id].Salario = salario;
                    assistentes[id].Func.Salario = salario;
                }
            }
            else    //num == 3
            {
                string DePrGe; //string para departamento, projeto ou gestor
                Console.WriteLine("Insira o novo departamento / projeto ou gestor: ");
                do
                {
                    DePrGe = Console.ReadLine();
                    if (DePrGe == "") { b = false; Console.WriteLine("Nome inválido, insira novamente o departamento: "); } else { b = true; }
                } while (!b);
                if (funcionarios[id].Funcao == "Diretor")
                {
                    diretores[id].Departamento = DePrGe;
                }
                else if (funcionarios[id].Funcao == "Engenheiro")
                {
                    engenheiros[id].Projeto = DePrGe;
                }
                else
                {
                    assistentes[id].Gestor = DePrGe;
                }
            }
        }

        public void printPorID(int id)
        {
            if (funcionarios[id].Funcao == "Diretor")
            {
                Console.WriteLine(printDiretor(id));                
            }
            else if (funcionarios[id].Funcao == "Engenheiro")
            {
                Console.WriteLine(printEngen(id));                
            }
            else
            {
                Console.WriteLine(printAssist(id));                
            }
        }

        public string printDiretor(int id)
        {
            return diretores[id].ToString();
        }

        public string printEngen(int id)
        {
            return engenheiros[id].ToString();
        }

        public string printAssist(int id)
        {
            return assistentes[id].ToString();
        }
    }
}
