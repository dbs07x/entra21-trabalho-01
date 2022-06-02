using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExecutarRelogio
    {
        public void Executar()
        {
            Relogio relogio = new Relogio();
            Console.WriteLine("Digite um horário: ");
            relogio.Hora = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(@$"Hora:  { relogio.ObterHoraPorExtenso()}
Minuto: {relogio.ObterMinutoPorExtenso()}
Segundo: {relogio.ObterSegundoPorExtenso()}");


        }

    }
}
