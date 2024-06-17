using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeObjetos17._06.Models
{
    internal class ContaCorrente
    {

        public ContaCorrente(int numero, string titular, int agencia, decimal saldo)
        {
            Numero = numero;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }
        public decimal Saldo { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }

        public int Agencia { get; set; }

        public void ApresentarConta()
        {
            Console.WriteLine($"Numero: {Numero},Titular: {Titular},Agencia: {Agencia}, Saldo: {Saldo}");
        }


    }
}
