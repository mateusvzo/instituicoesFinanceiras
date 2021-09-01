using System;

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
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
