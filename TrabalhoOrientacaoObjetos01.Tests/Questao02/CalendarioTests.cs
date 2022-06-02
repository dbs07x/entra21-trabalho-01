using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao02;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao02
{
    public class CalendarioTests
    {
        [Theory]
        [InlineData ("2000/01/01", "Um")] [InlineData ("2000/01/02", "Dois")] [InlineData ("2000/01/03", "Três")]
        [InlineData("2000/01/04", "Quatro")] [InlineData("2000/01/05", "Cinco")] [InlineData("2000/01/06", "Seis")]
        [InlineData("2000/01/07", "Sete")] [InlineData("2000/01/08", "Oito")] [InlineData("2000/01/09", "Nove")]
        [InlineData("2000/01/10", "Dez")] [InlineData("2000/01/11", "Onze")] [InlineData("2000/01/12", "Doze")]
        [InlineData("2000/01/13", "Treze")] [InlineData("2000/01/14", "Quatorze")] [InlineData("2000/01/15", "Quinze")]
        [InlineData("2000/01/16", "Dezesseis")] [InlineData("2000/01/17", "Dezessete")] [InlineData("2000/01/18", "Dezoito")]
        [InlineData("2000/01/19", "Dezenove")] [InlineData("2000/01/20", "Vinte")] [InlineData("2000/01/21", "Vinte e um")]
        [InlineData("2000/01/22", "Vinte e dois")] [InlineData("2000/01/23", "Vinte e três")] [InlineData("2000/01/24", "Vinte e quatro")]
        [InlineData("2000/01/25", "Vinte e cinco")] [InlineData("2000/01/26", "Vinte e seis")] [InlineData("2000/01/27", "Vinte e sete")]
        [InlineData("2000/01/28", "Vinte e oito")] [InlineData("2000/01/29", "Vinte e nove")] [InlineData("2000/01/30", "Trinta")]
        [InlineData("2000/01/31", "Trinta e um")]
        
        public void Validar_ObterDiaPorExtenso_Para_Todos_Dias(DateTime data, string diaPorExtenso)
        {
            // Arrange
            Calendario calendarioTeste = new Calendario();
            calendarioTeste.Data = data;

            // Act
            string diaObtido = calendarioTeste.ObterDiaPorExtenso();
            string diaEsperado = diaPorExtenso;

            // Assert
            diaObtido.Should().Be(diaEsperado);
        }
    }
}
