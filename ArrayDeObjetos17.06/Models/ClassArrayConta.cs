using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeObjetos17._06.Models
{
    internal class ClassArrayConta
    {
        int _proximaPosicao = 7;
 
        //propriedade define o tamanho do array
        //propriedade apenas de leitura

        public  int Tamanho 
        {
            get
            {
                return _proximaPosicao;  
            }
                
        }
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
                Console.WriteLine($" Titular: {itemArrayConta.Titular}, Número: {itemArrayConta.Numero}, Agência: {itemArrayConta.Agencia}");
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

 

        
        //removendo item do array
        public void RemoverItem(ContaCorrente conta)
        {
           
            int indiceItem = -1;
            //for para encontrar o índice
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = arrayDeConta[i];
                //a contaAsendo igual, encontramos a posição da nossa conta no array por meio do parâmetro recebido.
                if (contaAtual == conta)
                {
                    //a cada repetição essa condição é testada, quando confirmada (a conta igual) o indice que achou
                    // a conta é salvo em "indiceItem"
                    indiceItem = i;
                    break;// o break para sair do for, da estrutura de repetição
                }

            }
            //aqui usamos o indice que encontramos no for anterior, que é a conta que recebemos como parâmetro,
            //pois confirmamos pela condição que ambas são iguais.
            //inicialmente a partir da conta a ser removida a estrutura de repetição começa pela posição da conta
            //a ser removida. Assim, a conta da posição posterior assume a posição da anterior e assim por diante
            //até a a condição exigida do laço de repetição ser satisfeita.
            

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                //aqui adicionamos à posição da conta que queremos remover a conta da posição posterior,
                //removendo assim a conta.
                arrayDeConta[i] = arrayDeConta[i + 1];
            }
            _proximaPosicao--;//será decrementado - 1
            //aqui colocamos na última posição um "null"
            arrayDeConta[_proximaPosicao] = null;
        }
        //encontrar uma conta através de um índice
        public ContaCorrente RecuperarItemIndice(int indice)
        {
            if (indice < 0 || indice > arrayDeConta.Length)
            {
                Console.WriteLine("O índice é nullo ou maior que a capacidade do array");
            }
            ContaCorrente contaIndice = arrayDeConta[indice];

            return contaIndice;
        }
    }
}
