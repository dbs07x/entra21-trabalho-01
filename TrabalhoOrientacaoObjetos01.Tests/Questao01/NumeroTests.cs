using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

/*-Cenários de teste unitários:
-Cenário 01: Validar todos os valores decimais de 0 até 99;
-Cenário 02: Validar todos os números menores que 10;
-Cenário 03: Validar todos os números menores que 100;
-Cenário 04: Validar 10 números, sendo um para cada centena;
-Cenário 05: Validar unidade de milhar, com dez números;
-Cenário 06: Validar o número completo por extenso, com 5 cenários.*/

namespace TrabalhoOrientacaoObjetos01.Tests.Questao01
{
    public class NumeroTests
    {
        [Theory]
        [InlineData(0.01, "um")]
        [InlineData(0.11, "onze")]
        [InlineData(0.22, "vinte e dois")]
        [InlineData(0.33, "trinta e três")]
        [InlineData(0.44, "quarenta e quatro")]
        [InlineData(0.55, "cinquenta e cinco")]
        [InlineData(0.66, "sessenta e seis")]
        [InlineData(0.77, "setenta e sete")]
        [InlineData(0.88, "oitenta e oito")]
        [InlineData(0.99, "noventa e nove")]

        public void ValidarTodosNumerosDecimais(double numeroSolicitado, string decimalPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterDecimalPorExtenso = numero.ObterDecimalPorExtenso();

            //Assert
            obterDecimalPorExtenso.Should().Be(decimalPorExtenso);
        }

        [Theory]
        [InlineData(1.00, "um")]
        [InlineData(2.00, "dois")]
        [InlineData(3.00, "três")]
        [InlineData(4.00, "quatro")]
        [InlineData(5.00, "cinco")]
        [InlineData(6.00, "seis")]
        [InlineData(7.00, "sete")]
        [InlineData(8.00, "oito")]
        [InlineData(9.00, "nove")]

        public void ValidarTodosNumerosMenoresQueDez(double numeroSolicitado, string unidadePorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterUnidadePorExtenso = numero.ObterUnidadePorExtenso();

            //Assert
            obterUnidadePorExtenso.Should().Be(unidadePorExtenso);
        }

        [Theory]
        [InlineData(11.00, "onze")]
        [InlineData(22.00, "vinte e dois")]
        [InlineData(33.00, "trinta e três")]
        [InlineData(44.00, "quarenta e quatro")]
        [InlineData(55.00, "cinquenta e cinco")]
        [InlineData(66.00, "sessenta e seis")]
        [InlineData(77.00, "setenta e sete")]
        [InlineData(88.00, "oitenta e oito")]
        [InlineData(99.00, "noventa e nove")]

        public void ValidarTodosNumerosMenoresQueCem(double numeroSolicitado, string centenaPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterCentenaPorExtenso = numero.ObterCentenaPorExtenso();

            //Assert
            obterCentenaPorExtenso.Should().Be(centenaPorExtenso);
        }

    }
}
