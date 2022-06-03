using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

//Aluno: Douglas Braatz de Souza


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
        [InlineData(0.02, "dois")]
        [InlineData(0.03, "três")]
        [InlineData(0.04, "quatro")]
        [InlineData(0.05, "cinco")]
        [InlineData(0.06, "seis")]
        [InlineData(0.07, "sete")]
        [InlineData(0.08, "oito")]
        [InlineData(0.09, "nove")]
        [InlineData(0.10, "dez")]
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
        [InlineData(11.00, "dez")]
        [InlineData(22.00, "vinte")]
        [InlineData(33.00, "trinta")]
        [InlineData(44.00, "quarenta")]
        [InlineData(55.00, "cinquenta")]
        [InlineData(66.00, "sessenta")]
        [InlineData(77.00, "setenta")]
        [InlineData(88.00, "oitenta")]
        [InlineData(99.00, "noventa")]

        public void ValidarTodosNumerosMenoresQueCem(double numeroSolicitado, string dezenaPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterDezenaPorExtenso = numero.ObterDezenaPorExtenso();

            //Assert
            obterDezenaPorExtenso.Should().Be(dezenaPorExtenso);
        }

        [Theory]
        [InlineData(111.00, "cem")]
        [InlineData(222.00, "duzentos")]
        [InlineData(333.00, "trezentos")]
        [InlineData(444.00, "quatrocentos")]
        [InlineData(555.00, "quinhentos")]
        [InlineData(666.00, "seiscentos")]
        [InlineData(777.00, "setecentos")]
        [InlineData(888.00, "oitocentos")]
        [InlineData(999.00, "novecentos")]


        public void ValidarDezNumerosDeCentena(double numeroSolicitado, string centenaPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterCentenaPorExtenso = numero.ObterCentenaPorExtenso();

            //Assert
            obterCentenaPorExtenso.Should().Be(centenaPorExtenso);
        }

        [Theory]
        [InlineData(1111.00, "mil")]
        [InlineData(2222.00, "dois mil")]
        [InlineData(3333.00, "três mil")]
        [InlineData(4444.00, "quatro mil")]
        [InlineData(5555.00, "cinco mil")]
        [InlineData(6666.00, "seis mil")]
        [InlineData(7777.00, "sete mil")]
        [InlineData(8888.00, "oito mil")]
        [InlineData(9999.00, "nove mil")]

        public void ValidarDezNumerosDeMilhar(double numeroSolicitado, string milharPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterMilharPorExtenso = numero.ObterUnidadeDeMilharPorExtenso();

            //Assert
            obterMilharPorExtenso.Should().Be(milharPorExtenso);
        }

    }
}
