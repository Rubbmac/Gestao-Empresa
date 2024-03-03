using System.Net.Http.Headers;
using System.Numerics;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Avaliacao_5119
{

    internal class Program
    {
        static bool testValid2(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++; // irá contar os caracteres possui a str
                if (count > 1)
                {
                    return false; // se possuir mais que um caracter, irá dar return de false e voltar a pedir nova inserçao
                }
            }
            if (s == "1" || s == "2") // se for igual a um dos digitos dá return true, nao posso fazer int.Parse porque se for uma letra irá quebrar o programa
            {
                return true;
            }
            else { return false; }
        }

        static bool testValid4(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++; // irá contar os caracteres possui a str
                if (count > 1)
                {
                    return false; // se possuir mais que um caracter, irá dar return de false e voltar a pedir nova inserçao
                }
            }
            if (s == "1" || s == "2" || s == "3" || s == "4") // se for igual a um dos digitos dá return true, nao posso fazer int.Parse porque se for uma letra irá quebrar o programa
            {
                return true;
            }
            else { return false; }
        }        

        static bool testValid5(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++; // irá contar os caracteres possui a str
                if (count > 1)
                {
                    return false; // se possuir mais que um caracter, irá dar return de false e voltar a pedir nova inserçao
                }
            }
            if (s == "1" || s == "2" || s == "3" || s == "4" || s == "5") // se for igual a um dos digitos dá return true, nao posso fazer int.Parse porque se for uma letra irá quebrar o programa
            {
                return true;
            }
            else { return false; }
        }

        static bool testDigit(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c)) //verifica se o caracter é ou não um digito, returnando false se não for
                {
                    return false;
                }
            }
            return true;
        }
        
        
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            // criação da classe empresa com alguns valores inseridos para fazer verificações
            empresa.funcionarios[1] = new Funcionario(1, "Ruben", 2500, "Diretor");
            empresa.funcionarios[2] = new Funcionario(2, "Sandra", 2000, "Engenheiro");
            empresa.funcionarios[3] = new Funcionario(3, "Gabriel", 1000, "Assistente");
            empresa.funcionarios[4] = new Funcionario(4, "Filipa", 1000, "Assistente");

            empresa.diretores[1] = new Diretor(empresa.funcionarios[1], "Comercial");
            empresa.engenheiros[1] = new Engenheiro();
            empresa.assistentes[1] = new Assistentes();

            empresa.diretores[2] = new Diretor();
            empresa.engenheiros[2] = new Engenheiro(empresa.funcionarios[2], "Prédio comercial");
            empresa.assistentes[2] = new Assistentes();

            empresa.diretores[3] = new Diretor();
            empresa.engenheiros[3] = new Engenheiro();
            empresa.assistentes[3] = new Assistentes(empresa.funcionarios[3], "Sandra");

            empresa.diretores[4] = new Diretor();
            empresa.engenheiros[4] = new Engenheiro();
            empresa.assistentes[4] = new Assistentes(empresa.funcionarios[4], "Ruben");

            empresa.IDglobal = 5;


            bool programa = true;
            do {
                string str;
                do
                {
                    Console.Clear();
                    Console.WriteLine("*******************************************************\n\t\t\tMENU\n*******************************************************\n");
                    Console.WriteLine("Bem vindo\n\nPor favor escolha uma opção: ");
                    Console.WriteLine("1 - Adicionar Diretor\n2 - Adicionar Engenheiro\n3 - Adicionar Assistente\n4 - Outros\n5 - Sair");
                    str = Console.ReadLine();
                    if (str =="")
                    {
                        str = "null"; //caso o user pressione "enter" sem escrever nada, a str fica igual a "null"
                    }
                    if (!testValid5(str))
                    {
                        Console.WriteLine("Valor inválido, por favor insira novamente");
                        Thread.Sleep(1000); // irá aguardar 1 segundos antes de chamar novamente a janela de inserção original após o erro
                    }
                } while (!testValid5(str));

                if (int.Parse(str) > 0 && int.Parse(str) < 4) {         //se for a opção 1, 2 ou 3 irá para o submenu de adicionar funcionarios
                    switch (str)
                    {
                        case "1":
                            empresa.AdicionaDiretor();
                            break;
                        case "2":
                            empresa.AdicionaEngenheiro();
                            break;
                        case "3":
                            empresa.AdicionaAssistente();
                            break;
                        default:
                            break;
                    }
                }             
                if (str=="4")
                {
                    string outros;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("*****\tMenu Adicional   *****");
                        Console.WriteLine("1 - Relatórios de Salários\n2 - Gestão de informações de funcionários");
                        outros= Console.ReadLine();
                        if (!testValid2(outros))
                        {
                            Console.WriteLine("Valor inválido, por favor insira novamente");
                            Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                        }
                    } while (!testValid2(outros));

                    if (outros =="1")
                    {
                        string outros1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("*****\tRelatórios de Salários   *****");
                            Console.WriteLine("1 - Salário total \n2 - Salário mais alto");
                            outros1=Console.ReadLine();
                            if (!testValid2(outros1))
                            {
                                Console.WriteLine("Valor inválido, por favor insira novamente");
                                Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                            }
                        } while (!testValid2(outros1));

                        if (outros1 == "1") 
                        {
                            //salario total
                            string outros1a;
                            do
                            {
                                Console.WriteLine("Indique a categoria:\n1 - Todos os funcionários\n2 - Diretores\n3 - Engenheiros\n4 - Assistentes");
                                outros1a=Console.ReadLine();
                                if (!testValid4(outros1a))
                                {
                                    Console.WriteLine("Valor inválido, por favor insira novamente");
                                    Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                                }
                            } while (!testValid4(outros1a));
                            empresa.relatorioSalarios(outros1a);
                        }
                        else
                        {
                            //salario mais alto
                            string outros1b;
                            do
                            {
                                Console.WriteLine("Indique a categoria:\n1 - Todos os funcionários\n2 - Diretores\n3 - Engenheiros\n4 - Assistentes");
                                outros1b = Console.ReadLine(); 
                                if (!testValid4(outros1b))
                                {
                                    Console.WriteLine("Valor inválido, por favor insira novamente");
                                    Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                                }
                            } while (!testValid4(outros1b));
                            empresa.salarioMaisAlto(outros1b);
                        }                    
                    }
                    else
                    {
                        string outros2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("*****\tGestão de informações de funcionários   *****");
                            Console.WriteLine("1 - Informação de um funcionário através do ID\n2 - Alterar informações de um funcionário através do ID");
                            outros2 = Console.ReadLine();
                            if (!testValid2(outros2))
                            {
                                Console.WriteLine("Valor inválido, por favor insira novamente");
                                Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                            }
                        } while (!testValid2(outros2));
                        if (outros2 == "1")
                        {
                            string strId;
                            do
                            {
                                Console.WriteLine("Insira o ID do funcionário: ");
                                strId = Console.ReadLine();
                                if (!testDigit(strId) || strId == "")
                                {
                                    Console.WriteLine("ID inválido");
                                    Thread.Sleep(1000);
                                }else if (empresa.IDglobal <= int.Parse(strId))
                                {
                                    Console.WriteLine("ID inexistente");
                                    strId = "NULL";  // caso o ID seja numérico mas não existe ainda na base de dados será alterado o valor para NULL de modo a pedir novamente
                                    Thread.Sleep(1000);
                                }  
                            } while (!testDigit(strId) || strId == "");
                            int id = int.Parse(strId);
                            empresa.printPorID(id);
                            string cont;
                            Console.WriteLine("\nPressione qualquer tecla para continuar");
                            cont = Console.ReadLine();
                        }
                        else
                        {
                            string strId;
                            do
                            {
                                Console.WriteLine("Insira o ID do funcionário: ");
                                strId = Console.ReadLine();
                                if (!testDigit(strId) || strId == "")
                                {
                                    Console.WriteLine("ID inválido");
                                    Thread.Sleep(1000);
                                }else if (empresa.IDglobal <= int.Parse(strId))
                                {
                                    Console.WriteLine("ID inexistente");
                                    strId = "NULL";  // caso o ID seja numérico mas não existe ainda na base de dados será alterado o valor para NULL de modo a pedir novamente
                                    Thread.Sleep(1000);
                                }
                            } while (!testDigit(strId) || strId == "");
                            int id = int.Parse(strId);
                            string altera;
                            do
                            {
                                Console.Clear();
                                empresa.printPorID(id);
                                Console.WriteLine("\nO que pretende alterar?\n1 - Nome\n2 - Salário\n3 - Departamento/Projeto/Gestor\n4 - Cancelar");
                                altera = Console.ReadLine();
                                if (!testValid4(altera))
                                {
                                    Console.WriteLine("Valor inválido, por favor insira novamente");
                                    Thread.Sleep(1000); // irá aguardar 1 segundo antes de chamar novamente a janela de inserção original após o erro
                                }
                            } while (!testValid4(altera));
                            if (int.Parse(altera)>0&&int.Parse(altera)<4)
                            {
                                empresa.alteraInformacao(int.Parse(altera),id);
                            }


                        }
                    }
                }

                if (str == "5") 
                {
                    programa = false;
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tAdeus\n\n");
                    Thread.Sleep(1000);
                }
            } while (programa);            
        }
    }
}