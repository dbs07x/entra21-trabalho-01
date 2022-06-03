using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExecutarNumero
    {
        public void Executar()
        {
            Console.Clear();
            var opcaoMenu = 0;
            while (opcaoMenu == 0)
            {
                Console.Write(@"1 - ObterDecimalPorExtenso
2 - ObterUnidadePorExtenso
3 - ObterDezenaPorExtenso
4 - ObterCentenaPorExtenso
5 - ObterUnidadeDeMilharPorExtenso
6 - ObterNumeroCompletoPorExtenso
");
                Console.Write("\n");
                Console.WriteLine("Escolha um item no menu: ");
                var menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Numero numero = new Numero();
                    Console.WriteLine("Digite um número: ");
                    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Decimal por extenso: " + numero.ObterDecimalPorExtenso());
                }

                if (menu == 2)
                {
                    Numero numero = new Numero();
                    Console.WriteLine("Digite um número: ");
                    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Unidade por extenso: " + numero.ObterUnidadePorExtenso());
                }

                if (menu == 3)
                {
                    Numero numero = new Numero();
                    Console.WriteLine("Digite um número: ");
                    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dezena por extenso: " + numero.ObterDezenaPorExtenso());
                }

                if (menu == 4)
                {
                    Numero numero = new Numero();
                    Console.WriteLine("Digite um número: ");
                    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Centena por extenso: " + numero.ObterCentenaPorExtenso());
                }

                if (menu == 5)
                {
                    Numero numero = new Numero();
                    Console.WriteLine("Digite um número: ");
                    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Unidade de milhar por extenso: " + numero.ObterUnidadeDeMilharPorExtenso());
                }

                //if (menu == 6)
                //{
                //    Numero numero = new Numero();
                //    Console.WriteLine("Digite um número: ");
                //    numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Número completo por extenso: " + numero.ObterNumeroCompletoPorExtenso());
                //}
                Console.Write("\n");
            }   
        }
    }
}
