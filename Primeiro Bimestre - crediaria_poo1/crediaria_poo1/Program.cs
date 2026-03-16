using classe;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

int menu = 0;
int outroMenu=0; 
List<CCorrente> contas = new List<CCorrente>();

do
{
    Console.WriteLine("Digite uma opcao:\n1- Acesso Administrativo\n2- Caixa Eletronico\n0 - Sair\nDigite sua opcao: ");
    Int32.TryParse(Console.ReadLine(), out menu );
    if (menu == 1)
    {
        do
        {
            Console.WriteLine("Digite uma opcao:\n1- Cadastro de conta corrente\n2- Mostrar saldo das contas\n3- Excluir Conta\n0 - Voltar\nDigite sua opcao: ");
            Int32.TryParse(Console.ReadLine() , out outroMenu );
            if (outroMenu == 1) 
            {
                Console.WriteLine("Digite seu numero: ");
                string? numero = Console.ReadLine();
                bool contaExistente = false;
                foreach (CCorrente c in contas)
                {
                    if (c.numero == numero)
                    {
                        contaExistente = true;
                        break;
                    }
                }

                if (!contaExistente)
                {
                    double limite;
                    do
                    {
                        Console.WriteLine("Digite o limite da conta:");
                        Double.TryParse(Console.ReadLine(), out limite);
                        if(limite<=0)
                        {
                            Console.WriteLine("Digite um limite positivo!");
                        }
                    } while (limite <= 0);

                    CCorrente novaConta = new CCorrente(numero, limite);
                    contas.Add(novaConta);

                    Console.WriteLine("Conta cadastrada com sucesso.");
                }
            }
            else if (outroMenu == 2) 
            {
                if (contas.Count == 0)
                {
                    Console.WriteLine("Não existe");
                }
                else
                {
                    foreach (CCorrente c in contas)
                    {
                        Console.WriteLine("Conta: " + c.numero + ", Saldo: " + c.saldo); 
                    }
                } 
            }
            else if (outroMenu == 3)
            {
                Console.WriteLine("Digite o número da conta que deseja excluir:");
                string? numero = Console.ReadLine();

                CCorrente conta = null;
                foreach (CCorrente c in contas)
                {
                    if (c.numero == numero)
                    {
                        conta = c;
                        break;
                    }
                }

                if (conta != null)
                {
                    conta.status = false;
                    contas.Remove(conta);
                    Console.WriteLine("Conta excluída.");
                }
                else
                {
                    Console.WriteLine("Conta não encontrada.");
                }
            }
            else if (outroMenu == 0)
            {
                Console.WriteLine("Retornando...");
            }
            else 
            {
                Console.WriteLine("Digite um numero valido");
            }
        }while(outroMenu !=0);
    }
    else if (menu == 2)
    {
            CCorrente conta = null;
            Console.WriteLine("Digite o numero da conta: ");
            string? num = Console.ReadLine();
            foreach(CCorrente c in contas)
            {
                if(c.numero == num)
                {
                    do
                    {
                        conta = c;
                        Console.WriteLine("Digite uma opcao:\n1- Saque\n2- Deposito\n3 - Transferencia\n0- Voltar\nDigite sua opcao: ");
                        Int32.TryParse(Console.ReadLine(), out outroMenu);
                        if (outroMenu == 1) 
                        {
                            Console.WriteLine("Digite o valor a sacar:");
                            double valorSaque;
                            Double.TryParse(Console.ReadLine(), out valorSaque);
                            if (conta.Sacar(valorSaque))
                            {
                                Console.WriteLine("Saque realizado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível realizar o saque.");
                            }
                        }
                        else if(outroMenu == 2) 
                        {
                            Console.WriteLine("Digite o valor a depositar:");
                            double valorDeposito;
                            Double.TryParse(Console.ReadLine(), out valorDeposito);
                            if (conta.Depositar(valorDeposito))
                            {
                                Console.WriteLine("Depósito realizado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível realizar o depósito.");
                            }
                        }
                        else if(outroMenu == 3)
                        {
                            Console.WriteLine("Digite o número da conta de destino:");
                            string? numeroDestino = Console.ReadLine();

                            if (numeroDestino == c.numero)
                            {
                                Console.WriteLine("Impossivel realizar uma transferencia para si mesmo");
                                break;
                            }
                            else
                            {
                                CCorrente contaDestino = null;
                                foreach (CCorrente x in contas)
                                {
                                    if (x.numero == numeroDestino)
                                    {
                                        contaDestino = x;
                                        break;
                                    }
                                }

                                if (contaDestino != null && contaDestino.status)
                                {
                                    Console.WriteLine("Digite o valor a transferir:");
                                    double valorTransferencia;
                                    Double.TryParse(Console.ReadLine(), out valorTransferencia);
                                    if (conta.Transferir(contaDestino, valorTransferencia))
                                        Console.WriteLine("Transferência realizada com sucesso.");
                                    else
                                        Console.WriteLine("Não foi possível realizar a transferência.");
                                }
                                else
                                {
                                    Console.WriteLine("Conta de destino não encontrada.");
                                }
                            }
                            break;
                        }
                        else if(outroMenu == 0 ) 
                        {
                            Console.WriteLine("Adios!");
                        }
                        else
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }while (outroMenu != 0);
                }
                else
                {
                    Console.WriteLine("Digite um numero existente");
                }
            }
    }
    else if (menu == 0)
        Console.WriteLine("Adios!");
    else
    {
        Console.WriteLine("Digite um numero valido!");
    }  
} while (menu != 0);