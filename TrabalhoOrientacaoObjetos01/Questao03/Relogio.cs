using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {
        public DateTime Hora;

        public string ObterHoraPorExtenso()
        {
            string horaPorExtenso = Hora.Hour.ToString();
            return horaPorExtenso;
        }
        public void ObterMinutoPorExtenso()
        {
            string minutoPorExtenso = Hora.Minute.ToString();
        }
        public void ObterSegundoPorExtenso()
        {
            string SegundoDigitado = Hora.Second.ToString();

        }
    }
}
