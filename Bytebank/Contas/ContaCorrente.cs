using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Pessoas;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public Titular Titular { get; set; }
        public int Conta { get; set; }
        public string Agencia { get; set; }
        public static int NumeroContas { get; private set; }
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set {
                if (value <= 0)
                    return;
                else this.saldo = value;
            }
        }

        public ContaCorrente(string titular, int conta, string agencia)
        {
            this.Titular = new Titular(titular);
            this.Conta = conta;
            this.Agencia = agencia;
            NumeroContas++;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo > 0 && valor <= saldo)
                saldo -= valor;
            else return false;

            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo > 0 && valor <= saldo)
            {
                Sacar(valor);
                destino.Depositar(valor);
            }
            else return false;
            return true;
        }

        public void EscreveDados()
        {
            Console.WriteLine($"Titular da conta: {Titular.Nome}");
            Console.WriteLine($"Número da conta: {Conta}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo R$ {string.Format("{0:0.00}", Saldo)}");
        }
    }
}
