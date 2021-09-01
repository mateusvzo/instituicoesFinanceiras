using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Conta
    {
        public int Numero { get; private set; }

        public decimal Saldo { get; private set; }

        public Cliente Titular { get; set; }

        public Conta(int numero, Cliente titular)
        {
            if(numero < 999)
            {
                throw new System.ArgumentException("O número precisa ser superior a 999");
            }
            Numero = numero;
            Titular = titular;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if((Saldo - valor - 0.1m) < 0)
            {
                return false;
            } 

            Saldo -= (valor + 0.1m);
            return true;
        }

        public bool Transferir(Conta destino, decimal valor)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }

            return false;
        }













        /*        private int numero;
                private decimal saldo;
                public static decimal MaiorSaldo;
                public static int ContaGorda;
                public static decimal SaldoGeral;

                public int Numero { 
                    get
                    {
                        return numero;
                    }

                    set
                    {
                        if(value > 100000)
                        {
                            this.numero = value;
                        }
                        else
                        {
                            Console.WriteLine("O numero da conta deve ser superior a 100000");
                        }
                    }
                }
                public decimal Saldo
                {
                    get
                    {
                        return saldo;
                    }
                    set
                    {
                        if(value >= 0.0m)
                        {
                            this.saldo = value;
                            SaldoGeral = this.saldo;
                            if (this.saldo > MaiorSaldo)
                            {
                                MaiorSaldo = this.saldo;
                                ContaGorda = this.numero;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor Inválido");
                        }
                    }
                }
                public void Depositar()
                {

                }*/

    }
}
