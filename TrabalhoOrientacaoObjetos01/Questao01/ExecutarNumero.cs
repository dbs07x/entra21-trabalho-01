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
            }
        }
    }
}
