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
            string horaPorExtenso = "";
            string horaDigitada = Hora.Hour.ToString();
            int primeiroCaracterHora = Convert.ToInt32(horaDigitada.Substring(0, 1));
            int segundoCaracterHora = Convert.ToInt32(horaDigitada.Substring(1, 1));

            if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 0))
            {
            }
             else if((primeiroCaracterHora == 0) && (segundoCaracterHora == 1))
            {
                horaPorExtenso = "Uma hora";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 2))
            {
                horaPorExtenso = "Duas horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 3))
            {
                horaPorExtenso = "Três horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 4))
            {
                horaPorExtenso = "Quatro horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 5))
            {
                horaPorExtenso = "Cinco horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 6))
            {
                horaPorExtenso = "Seis horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 7))
            {
                horaPorExtenso = "Sete horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 8))
            {
                horaPorExtenso = "Oito horas";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 9))
            {
                horaPorExtenso = "Nove horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 0))
            {
                horaPorExtenso = "Dez Horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 1))
            {
                horaPorExtenso = "Onze horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 2))
            {
                horaPorExtenso = "Doze horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 3))
            {
                horaPorExtenso = "Treze horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 4))
            {
                horaPorExtenso = "Quatorze horas";
            }
            else if((primeiroCaracterHora == 1) && (segundoCaracterHora == 5))
            {
                horaPorExtenso = "Quinze horas";
            }
            else if((primeiroCaracterHora == 1) && (segundoCaracterHora == 6))
            {
                horaPorExtenso = "Dezesseis horas";
            }
            else if((primeiroCaracterHora == 1) && (segundoCaracterHora == 7))
            {
                horaPorExtenso = "Dezessete horas";
            }
            else if((primeiroCaracterHora == 1) && (segundoCaracterHora == 8))
            {
                horaPorExtenso = "Dezoito horas";
            }
            else if((primeiroCaracterHora == 1) && (segundoCaracterHora == 9))
            {
                horaPorExtenso = "Dezenove horas";
            }
            else if((primeiroCaracterHora == 2) && (segundoCaracterHora == 0))
            {
                horaPorExtenso = "Vinte horas";
            }
            else if((primeiroCaracterHora == 2) && (segundoCaracterHora == 1))
            {
                horaPorExtenso = "Vinte e uma horas";
            }
            else if((primeiroCaracterHora == 2) && (segundoCaracterHora == 2))
            {
                horaPorExtenso = "Vinte e duas horas";
            }
            else if((primeiroCaracterHora == 2) && (segundoCaracterHora == 3))
            {
                horaPorExtenso = "Vinte e três horas";
            }
             else
            {
                horaPorExtenso = "(Horas inválidas) ";
            }

            return horaPorExtenso;

        }
        public string ObterMinutoPorExtenso()
        {
            string minutoPorExtenso = "";
            string minutoDigitado = Hora.Minute.ToString();
            int primeiroCaracterMinuto = Convert.ToInt32(minutoDigitado.Substring(0, 1));
            int segundoCaracterMinuto = Convert.ToInt32(minutoDigitado.Substring(1,1));

            if((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 0))
            {
            }
            else if((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "um minuto";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Dois minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Três minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "quatro minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Cinco minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Seis minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Sete minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Oito minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Nove minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Dez minutos";
            }

            return minutoPorExtenso;
        }
        public string ObterSegundoPorExtenso()
        {
            string segundoPorExtenso = Hora.Second.ToString();
            return segundoPorExtenso;
        }
        
        //public string ObterHoraCompletaPorExtenso()
        //{
            
            
            
            
        //    return 
        //}
    }
}
