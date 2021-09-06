using System;

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            Boolean sair = false;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Informe a ação a ser realizada: ");
                    Console.WriteLine("(1) Cadastrar Cliente");
                    Console.WriteLine("(2) Criar Conta");
                    Console.WriteLine("(3) Listar Contas");
                    Console.WriteLine("(4) Listar Clientes");
                    Console.WriteLine("(5) Sacar");
                    Console.WriteLine("(6) Depositar");
                    Console.WriteLine("(7) Transferir");
                    Console.WriteLine("(8) Saldo Geral");
                    Console.WriteLine("(9) Encerrar aplicação");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Faça seu Cadastro");
                            Console.WriteLine("Digite seu nome");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite seu email: (teste@teste.com)");
                            string email = Console.ReadLine();
                            Console.WriteLine("Digite seu ano de nascimento:(ex: 1999)");
                            string anoString = Console.ReadLine();
                            int ano = Int32.Parse(anoString);
                            Console.WriteLine("Digite seu CPF: ");
                            string cpf = Console.ReadLine();
                            Cliente cliente = new Cliente();
                            cliente.CriarCliente(nome, email, ano, cpf);
                            Console.WriteLine(cliente.Nome);
                            Console.ReadLine();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":

                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        case "9":
                            sair = true;
                            break;

                    }
                } while (sair != true);
                Cliente cliente1 = new Cliente("Alfredo", 2000, "12345678987");
                Conta conta1 = new Conta(123456, cliente1);
                Conta conta2 = new Conta(654321, cliente1);
                Console.WriteLine(conta1.Numero);
                Console.WriteLine("O saldo da inicial da conta é: " + conta1.Saldo);
                conta1.Depositar(1000);
                Console.WriteLine("O saldo da inicial da conta {0} é: {1} ", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo da inicial da conta {0} é: {1} ", conta2.Numero, conta2.Saldo);
                conta1.Transferir(conta2, 300);
                Console.WriteLine("O saldo da inicial da conta {0} é: {1} ", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo da inicial da conta {0} é: {1} ", conta2.Numero, conta2.Saldo);
                Console.WriteLine("O Titular da conta {0} é: {1} ", conta2.Numero, conta2.Titular.Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
