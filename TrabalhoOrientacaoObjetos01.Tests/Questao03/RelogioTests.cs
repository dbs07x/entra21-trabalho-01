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
    //Samuel Lopes
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
        [InlineData("00:11:12", "Onze minutos")]
        [InlineData("00:12:12", "Doze minutos")]
        [InlineData("00:13:12", "Treze minutos")]
        [InlineData("00:14:12", "Quatorze minutos")]
        [InlineData("00:15:12", "Quinze minutos")]
        [InlineData("00:16:12", "Dezesseis minutos")]
        [InlineData("00:17:12", "Dezessete minutos")]
        [InlineData("00:18:12", "Dezoito minutos")]
        [InlineData("00:19:12", "Dezenove minutos")]

        [InlineData("00:20:12", "Vinte minutos")]
        [InlineData("00:21:12", "Vinte e um minutos")]
        [InlineData("00:22:12", "Vinte e dois minutos")]
        [InlineData("00:23:12", "Vinte e três minutos")]
        [InlineData("00:24:12", "Vinte e quatro minutos")]
        [InlineData("00:25:12", "Vinte e cinco minutos")]
        [InlineData("00:26:12", "Vinte e seis minutos")]
        [InlineData("00:27:12", "Vinte e sete minutos")]
        [InlineData("00:28:12", "Vinte e oito minutos")]
        [InlineData("00:29:12", "Vinte e nove minutos")]

        [InlineData("00:30:12", "Trinta minutos")]
        [InlineData("00:31:12", "Trinta e um minutos")]
        [InlineData("00:32:12", "Trinta e dois minutos")]
        [InlineData("00:33:12", "Trinta e três minutos")]
        [InlineData("00:34:12", "Trinta e quatro minutos")]
        [InlineData("00:35:12", "Trinta e cinco minutos")]
        [InlineData("00:36:12", "Trinta e seis minutos")]
        [InlineData("00:37:12", "Trinta e sete minutos")]
        [InlineData("00:38:12", "Trinta e oito minutos")]
        [InlineData("00:39:12", "Trinta e nove minutos")]

        [InlineData("00:40:12", "Quarenta minutos")]
        [InlineData("00:41:12", "Quarenta e um minutos")]
        [InlineData("00:42:12", "Quarenta e dois minutos")]
        [InlineData("00:43:12", "Quarenta e três minutos")]
        [InlineData("00:44:12", "Quarenta e quatro minutos")]
        [InlineData("00:45:12", "Quarenta e cinco minutos")]
        [InlineData("00:46:12", "Quarenta e seis minutos")]
        [InlineData("00:47:12", "Quarenta e sete minutos")]
        [InlineData("00:48:12", "Quarenta e oito minutos")]
        [InlineData("00:49:12", "Quarenta e nove minutos")]

        [InlineData("00:50:12", "Cinquenta minutos")]
        [InlineData("00:51:12", "Cinquenta e um minutos")]
        [InlineData("00:52:12", "Cinquenta e dois minutos")]
        [InlineData("00:53:12", "Cinquenta e três minutos")]
        [InlineData("00:54:12", "Cinquenta e quatro minutos")]
        [InlineData("00:55:12", "Cinquenta e cinco minutos")]
        [InlineData("00:56:12", "Cinquenta e seis minutos")]
        [InlineData("00:57:12", "Cinquenta e sete minutos")]
        [InlineData("00:58:12", "Cinquenta e oito minutos")]
        [InlineData("00:59:12", "Cinquenta e nove minutos")]

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
        [InlineData("01:00:12", "Uma hora e Zero minutos e Doze segundos")]
        [InlineData("03:01:12", "Três horas e Um minuto e Doze segundos")]
        [InlineData("05:02:05", "Cinco horas e Dois minutos e Cinco segundos")]
        [InlineData("09:12:09", "Nove horas e Doze minutos e Nove segundos")]
        [InlineData("11:04:52", "Onze horas e Quatro minutos e Cinquenta e dois segundos")]
        [InlineData("12:05:42", "Doze horas e Cinco minutos e Quarenta e dois segundos")]
        [InlineData("14:06:22", "Quatorze horas e Seis minutos e Vinte e dois segundos")]
        [InlineData("16:07:12", "Dezesseis horas e Sete minutos e Doze segundos")]
        [InlineData("18:08:02", "Dezoito horas e Oito minutos e Dois segundos")]
        [InlineData("19:09:16", "Dezenove horas e Nove minutos e Dezesseis segundos")]
        [InlineData("20:10:39", "Vinte horas e Dez minutos e Trinta e nove segundos")]

        public void Validar_ObterHoraCompletaPorExtenso_10_Horas_Completas(DateTime horaCompleta, string horaCompletaPorExtenso)
        {
            //Arrange
            Relogio relogioTeste = new Relogio();
            relogioTeste.Hora = horaCompleta;

            //act
            string horaCompletaObtida = relogioTeste.ObterHoraCompletaPorExtenso();
            string horaCompletaEsperada = horaCompletaPorExtenso;

            //assert
            horaCompletaObtida.Should().Be(horaCompletaEsperada);
        }


        [Theory]
        [InlineData("00:00:00", "Zero segundos")]
        [InlineData("00:01:01", "Um segundo")]
        [InlineData("00:02:02", "Dois segundos")]
        [InlineData("00:03:03", "Três segundos")]
        [InlineData("00:04:04", "Quatro segundos")]
        [InlineData("00:05:05", "Cinco segundos")]
        [InlineData("00:06:06", "Seis segundos")]
        [InlineData("00:07:07", "Sete segundos")]
        [InlineData("00:08:08", "Oito segundos")]
        [InlineData("00:09:09", "Nove segundos")]
        [InlineData("00:10:10", "Dez segundos")]

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
