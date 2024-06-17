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
                  new ContaCorrente(4045, "Robert Parttison", 10598),
                  new ContaCorrente(5046, "Carlison Mattos", 10654),
                  new ContaCorrente(2654, "Robertos Justus", 10465),
                  new ContaCorrente(3060, "Roberto Carlos", 10875),
         };
        public void ExibirArrayDeContas()
        {
            for (int posi = 0; posi < arrayDeConta.Length; posi++)
            {
                ContaCorrente itemArrayConta = arrayDeConta[posi];
                Console.WriteLine($" Titular: {itemArrayConta.Titular}, Númere: {itemArrayConta.Numero}, Agência: {itemArrayConta.Agencia}");
            }
        }
    }
}
