using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    //Samuel Lopes 
    public class ExecutarRelogio
    {
        public void Executar()
        {
            Relogio relogio = new Relogio();
            Console.WriteLine("Digite um horário neste formatado (hh:mm:ss): ");
            relogio.Hora = Convert.ToDateTime(Console.ReadLine());

            var valido = false;
            while (valido == false)
            {
                Console.WriteLine(@"1: Obter Hora por extenso
2: Obter Minuto por extenso
3: Obter Segundo por Extenso
4: Obter Hora Completa por Extenso
5: SAIR");
                var escolha = Convert.ToInt32(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine($"Hora:  { relogio.ObterHoraPorExtenso()}");
                    Console.WriteLine("---------------------------------------------");
                }
                else if (escolha == 2)
                {
                    Console.WriteLine($"Minuto: {relogio.ObterMinutoPorExtenso()}");
                    Console.WriteLine("---------------------------------------------");
                }
                else if (escolha == 3)
                {
                    Console.WriteLine($"Segundo: {relogio.ObterSegundoPorExtenso()}");
                    Console.WriteLine("---------------------------------------------");
                }
                else if (escolha == 4)
                {
                    Console.WriteLine($"Hora por extenso completo: {relogio.ObterHoraCompletaPorExtenso()}");
                    Console.WriteLine("---------------------------------------------");
                }
                else if (escolha <= 0 || escolha >= 6)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("---------------------------------------------");
                }
                else
                {
                    valido = true;
                }
            }



        }

    }
}
