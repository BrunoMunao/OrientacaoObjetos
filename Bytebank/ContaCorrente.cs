using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public int conta;
        public string agencia;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor; 
        }

        public bool Sacar(double valor)
        {
            if (this.saldo > 0 && valor <= this.saldo)
                this.saldo -= valor;
            else return false;

            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo > 0 && valor <= this.saldo)
            {
                this.Sacar(valor);
                destino.Depositar(valor);
            }
            else return false;
            return true;
        }
    }
}
