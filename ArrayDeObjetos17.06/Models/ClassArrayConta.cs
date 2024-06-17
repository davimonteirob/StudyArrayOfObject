using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeObjetos17._06.Models
{
    internal class ClassArrayConta
    {
        ContaCorrente[] arrayDeConta = new ContaCorrente[]
         {
                  //instanciamos a conta e atribuimos valor de acordo com a conta;
                  // assim criamos um array de conta, pois cada conta instanciada está em uma posição do array.
                  new ContaCorrente(4045, "Robert Parttison", 10598, 10800),
                  new ContaCorrente(5046, "Carlison Mattos", 10654, 7600),
                  new ContaCorrente(2654, "Robertos Justus", 10465, 2500),
                  new ContaCorrente(3060, "Roberto Carlos", 10875, 900711),
         };
        public void ExibirArrayDeContas()
        {
            for (int posi = 0; posi < arrayDeConta.Length; posi++)
            {
                ContaCorrente itemArrayConta = arrayDeConta[posi];
                Console.WriteLine($" Titular: {itemArrayConta.Titular}, Númere: {itemArrayConta.Numero}, Agência: {itemArrayConta.Agencia}");
            }
        }

        //contas correntes do ByteBank na classe que encapsula as operações sobre uma lista de contas correntes,
        //foi solicitado que você desenvolva um método que retorne a conta corrente com o maior saldo da lista.


        
        public void MaiorSaldoDoArray()
        {
            // Inicializa a variável para armazenar o maior saldo
            decimal maiorSaldo = decimal.MinValue ; // Usando MinValue como ponto de partida



            for (int posi = 0; posi < arrayDeConta.Length; posi++) 
            {
                ContaCorrente itemArrayClass = arrayDeConta[posi];
                // Itera sobre o array de contas para encontrar o maior saldo
                if (itemArrayClass.Saldo > maiorSaldo)
                {
                    maiorSaldo = itemArrayClass.Saldo ;
                }

            }

            Console.WriteLine($" O Maior saldo do Array é: {maiorSaldo}");
        }
    }
}
