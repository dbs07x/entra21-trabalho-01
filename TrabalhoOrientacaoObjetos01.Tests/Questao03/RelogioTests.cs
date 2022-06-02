using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao03;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class RelogioTests
    {
        [Theory]
        [InlineData("00:05:02", "Zero hora")]
        [InlineData("01:05:02", "Uma hora")]
        [InlineData("02:05:02", "Duas horas")]
        [InlineData("03:05:02", "Três horas")]
        [InlineData("04:05:02", "Quatro horas")]
        [InlineData("05:05:02", "Cinco horas")]
        [InlineData("06:05:02", "Seis horas")]
        [InlineData("07:05:02", "Sete horas")]
        [InlineData("08:05:02", "Oito horas")]
        [InlineData("09:05:02", "Nove horas")]
        [InlineData("10:05:02", "Dez horas")]
        [InlineData("11:05:02", "Onze horas")]
        [InlineData("12:05:02", "Doze horas")]
        [InlineData("13:05:02", "Treze horas")]
        [InlineData("14:05:02", "Quatorze horas")]
        [InlineData("15:05:02", "Quinze horas")]
        [InlineData("16:05:02", "Dezesseis horas")]
        [InlineData("17:05:02", "Dezessete horas")]
        [InlineData("18:05:02", "Dezoito horas")]
        [InlineData("19:05:02", "Dezenove horas")]
        [InlineData("20:05:02", "Vinte horas")]
        [InlineData("21:05:02", "Vinte e uma horas")]
        [InlineData("22:05:02", "Vinte e duas horas")]
        [InlineData("23:05:02", "Vinte e três horas")]


        public void Validar_ObterHorasPorExtenso_Todas_Horas(DateTime hora, string horaPorExtenso)
        {
            //Arrange
            Relogio relogioTeste = new Relogio();
            relogioTeste.Hora=hora;

            //act
            string horaObtida = relogioTeste.ObterHoraPorExtenso();
            string horaEsperada = horaPorExtenso;
            
            //assert
            horaObtida.Should().Be(horaEsperada);

        }

        [Theory]
        [InlineData("00:00:12", "Zero minutos")]
        [InlineData("00:01:12", "Um minuto")]
        [InlineData("00:02:12", "Dois minutos")]
        [InlineData("00:03:12", "Três minutos")]
        [InlineData("00:04:12", "Quatro minutos")]
        [InlineData("00:05:12", "Cinco minutos")]
        [InlineData("00:06:12", "Seis minutos")]
        [InlineData("00:07:12", "Sete minutos")]
        [InlineData("00:08:12", "Oito minutos")]
        [InlineData("00:09:12", "Nove minutos")]
        [InlineData("00:10:12", "Dez minutos")]


        public void Validar_ObterMinutosPorExtenso_Todos_Minutos(DateTime hora, string minutoPorExtenso)
        {
            //Arrange
            Relogio relogioTeste = new Relogio();
            relogioTeste.Hora = hora;

            //act
            string minutoObtido = relogioTeste.ObterMinutoPorExtenso();
            string minutoEsperado = minutoPorExtenso;

            //assert
            minutoObtido.Should().Be(minutoEsperado);

        }


        [Theory]
        [InlineData("00:00:12", "Zero segundos")]
        [InlineData("00:01:12", "Um segundos")]
        [InlineData("00:02:12", "Dois segundos")]
        [InlineData("00:03:12", "Três segundos")]
        [InlineData("00:04:12", "Quatro segundos")]
        [InlineData("00:05:12", "Cinco segundos")]
        [InlineData("00:06:12", "Seis segundos")]
        [InlineData("00:07:12", "Sete segundos")]
        [InlineData("00:08:12", "Oito segundos")]
        [InlineData("00:09:12", "Nove segundos")]
        [InlineData("00:10:12", "Dez segundos")]

        public void Validar_ObterSegundosPorExtenso_Todos_Segundos(DateTime hora, string segundoPorExtenso)
        {
            //Arrange
            Relogio relogioTeste = new Relogio();
            relogioTeste.Hora = hora;

            //act
            string segundoObtido = relogioTeste.ObterSegundoPorExtenso();
            string segundoEsperado = segundoPorExtenso;

            //assert
            segundoObtido.Should().Be(segundoEsperado);

        }

    }
}
