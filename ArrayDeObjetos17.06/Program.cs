using ArrayDeObjetos17._06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeObjetos17._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassArrayConta classArrayConta = new ClassArrayConta();
            
            for (int i =0; i < 3; i++)
            {
                //queremos consultar a conta pelo indice na classe ArrayConta, para isso precisamos indexar a classe, uma classe indexável.
                ContaCorrente conta = ClassArrayConta[i];
                Console.WriteLine($"{conta.Titular}, {conta.Numero}, {conta.Saldo} ");
            }

            classArrayConta.ExibirArrayDeContas();
            Console.WriteLine("\n");
            Console.WriteLine("##ITEM PELO INDICE##");
            classArrayConta.RecuperarItemIndice(2);



        }
    }
}
