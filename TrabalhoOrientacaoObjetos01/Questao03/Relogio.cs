using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    //Samuel Lopes 
    public class Relogio
    {
        public DateTime Hora;

        public string ObterHoraPorExtenso()
        {
            string horaPorExtenso = "";
            string horaDigitada = Hora.ToString("HH");
            int primeiroCaracterHora = Convert.ToInt32(horaDigitada.Substring(0, 1));
            int segundoCaracterHora = Convert.ToInt32(horaDigitada.Substring(1, 1));

            if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 0))
            {
                horaPorExtenso = "Zero hora";
            }
            else if ((primeiroCaracterHora == 0) && (segundoCaracterHora == 1))
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
                horaPorExtenso = "Dez horas";
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
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 5))
            {
                horaPorExtenso = "Quinze horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 6))
            {
                horaPorExtenso = "Dezesseis horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 7))
            {
                horaPorExtenso = "Dezessete horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 8))
            {
                horaPorExtenso = "Dezoito horas";
            }
            else if ((primeiroCaracterHora == 1) && (segundoCaracterHora == 9))
            {
                horaPorExtenso = "Dezenove horas";
            }
            else if ((primeiroCaracterHora == 2) && (segundoCaracterHora == 0))
            {
                horaPorExtenso = "Vinte horas";
            }
            else if ((primeiroCaracterHora == 2) && (segundoCaracterHora == 1))
            {
                horaPorExtenso = "Vinte e uma horas";
            }
            else if ((primeiroCaracterHora == 2) && (segundoCaracterHora == 2))
            {
                horaPorExtenso = "Vinte e duas horas";
            }
            else if ((primeiroCaracterHora == 2) && (segundoCaracterHora == 3))
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
            string minutoDigitado = Hora.ToString("mm");
            int primeiroCaracterMinuto = Convert.ToInt32(minutoDigitado.Substring(0, 1));
            int segundoCaracterMinuto = Convert.ToInt32(minutoDigitado.Substring(1, 1));

            if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Zero minutos";
            }
            else if ((primeiroCaracterMinuto == 0) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Um minuto";
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
                minutoPorExtenso = "Quatro minutos";
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
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Onze Minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Doze minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Treze minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "quatorze minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Quinze minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Dezesseis minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Dezessete minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Dezoito minutos";
            }
            else if ((primeiroCaracterMinuto == 1) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Dezenove minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Vinte minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Vinte e um minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Vinte e dois minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Vinte e três minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "Vinte e quatro minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Vinte e cinco minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Vinte e seis minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Vinte e sete minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Vinte e oito minutos";
            }
            else if ((primeiroCaracterMinuto == 2) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Vinte e nove minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Trinta minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Trinta e um minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Trinta e dois minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Trinta e três minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "Trinta e quatro minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Trinta e cinco minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Trinta e seis minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Trinta e sete minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Trinta e oito minutos";
            }
            else if ((primeiroCaracterMinuto == 3) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Trinta e nove minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Quarenta minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Quarenta e um minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Quarenta e dois minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Quarenta e três minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "Quarenta e quatro minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Quarenta e cinco minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Quarenta e seis minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Quarenta e sete minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Quarenta e oito minutos";
            }
            else if ((primeiroCaracterMinuto == 4) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Quarenta e nove minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 0))
            {
                minutoPorExtenso = "Cinquenta minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 1))
            {
                minutoPorExtenso = "Cinquenta e um minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 2))
            {
                minutoPorExtenso = "Cinquenta e dois minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 3))
            {
                minutoPorExtenso = "Cinquenta e três minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 4))
            {
                minutoPorExtenso = "Cinquenta e quatro minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 5))
            {
                minutoPorExtenso = "Cinquenta e cinco minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 6))
            {
                minutoPorExtenso = "Cinquenta e seis minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 7))
            {
                minutoPorExtenso = "Cinquenta e sete minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 8))
            {
                minutoPorExtenso = "Cinquenta e oito minutos";
            }
            else if ((primeiroCaracterMinuto == 5) && (segundoCaracterMinuto == 9))
            {
                minutoPorExtenso = "Cinquenta e nove minutos";
            }

            return minutoPorExtenso;
        }
        public string ObterSegundoPorExtenso()
        {
            string segundoPorExtenso = "";
            string segundoDigitado = Hora.ToString("ss");
            int primeiroCaracterSegundos = Convert.ToInt32(segundoDigitado.Substring(0, 1));
            int segundoCaracterSegundos = Convert.ToInt32(segundoDigitado.Substring(1, 1));

            if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Zero segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Um segundo";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Dois segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Três segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "Quatro segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Cinco segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Seis segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Sete segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Oito segundos";
            }
            else if ((primeiroCaracterSegundos == 0) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Nove segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Dez segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Onze segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Doze segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Treze segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "quatorze segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Quinze segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Dezesseis segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Dezessete segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Dezoito segundos";
            }
            else if ((primeiroCaracterSegundos == 1) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Dezenove segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Vinte segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Vinte e um segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Vinte e dois segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Vinte e três segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "Vinte e quatro segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Vinte e cinco segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Vinte e seis segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Vinte e sete segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Vinte e oito segundos";
            }
            else if ((primeiroCaracterSegundos == 2) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Vinte e nove segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Trinta segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Trinta e um segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Trinta e dois segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Trinta e três segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "Trinta e quatro segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Trinta e cinco segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Trinta e seis segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Trinta e sete segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Trinta e oito segundos";
            }
            else if ((primeiroCaracterSegundos == 3) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Trinta e nove segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Quarenta segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Quarenta e um segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Quarenta e dois segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Quarenta e três segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "Quarenta e quatro segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Quarenta e cinco segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Quarenta e seis segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Quarenta e sete segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Quarenta e oito segundos";
            }
            else if ((primeiroCaracterSegundos == 4) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Quarenta e nove segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 0))
            {
                segundoPorExtenso = "Cinquenta segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 1))
            {
                segundoPorExtenso = "Cinquenta e um segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 2))
            {
                segundoPorExtenso = "Cinquenta e dois segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 3))
            {
                segundoPorExtenso = "Cinquenta e três segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 4))
            {
                segundoPorExtenso = "Cinquenta e quatro segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 5))
            {
                segundoPorExtenso = "Cinquenta e cinco segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 6))
            {
                segundoPorExtenso = "Cinquenta e seis segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 7))
            {
                segundoPorExtenso = "Cinquenta e sete segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 8))
            {
                segundoPorExtenso = "Cinquenta e oito segundos";
            }
            else if ((primeiroCaracterSegundos == 5) && (segundoCaracterSegundos == 9))
            {
                segundoPorExtenso = "Cinquenta e nove segundos";
            }

            return segundoPorExtenso;
        }
        public string ObterHoraCompletaPorExtenso()
        {
  
            return ObterHoraPorExtenso() + " e " + ObterMinutoPorExtenso() + " e " + ObterSegundoPorExtenso();
        }
        
    }
}
