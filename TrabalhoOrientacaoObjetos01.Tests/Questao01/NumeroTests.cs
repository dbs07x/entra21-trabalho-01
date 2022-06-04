﻿using FluentAssertions;
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
        [InlineData(0.00, "zero")]
        [InlineData(0.01, "um")]
        [InlineData(0.02, "dois")]
        [InlineData(0.03, "três")]
        [InlineData(0.04, "quatro")]
        [InlineData(0.05, "cinco")]
        [InlineData(0.06, "seis")]
        [InlineData(0.07, "sete")]
        [InlineData(0.08, "oito")]
        [InlineData(0.09, "nove")]

        public void ValidarTodosNumerosUnidadesDeDecimais(double numeroSolicitado, string unidadeDecimalPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterUnidadeDecimalPorExtenso = numero.ObterUnidadeDecimalPorExtenso();

            //Assert
            obterUnidadeDecimalPorExtenso.Should().Be(unidadeDecimalPorExtenso);
        }

        [Theory]
        [InlineData(0.10, "dez")]
        [InlineData(0.11, "onze")]
        [InlineData(0.12, "doze")]
        [InlineData(0.13, "treze")]
        [InlineData(0.14, "catorze")]
        [InlineData(0.15, "quinze")]
        [InlineData(0.16, "dezesseis")]
        [InlineData(0.17, "dezessete")]
        [InlineData(0.18, "dezoito")]
        [InlineData(0.19, "dezenove")]
        [InlineData(0.20, "vinte")]
        [InlineData(0.21, "vinte e um")]
        [InlineData(0.22, "vinte e dois")]
        [InlineData(0.23, "vinte e três")]
        [InlineData(0.24, "vinte e quatro")]
        [InlineData(0.25, "vinte e cinco")]
        [InlineData(0.26, "vinte e seis")]
        [InlineData(0.27, "vinte e sete")]
        [InlineData(0.28, "vinte e oito")]
        [InlineData(0.29, "vinte e nove")]
        [InlineData(0.30, "trinta")]
        [InlineData(0.31, "trinta e um")]
        [InlineData(0.32, "trinta e dois")]
        [InlineData(0.33, "trinta e três")]
        [InlineData(0.34, "trinta e quatro")]
        [InlineData(0.35, "trinta e cinco")]
        [InlineData(0.36, "trinta e seis")]
        [InlineData(0.37, "trinta e sete")]
        [InlineData(0.38, "trinta e oito")]
        [InlineData(0.39, "trinta e nove")]
        [InlineData(0.41, "quarenta e um")]
        [InlineData(0.42, "quarenta e dois")]
        [InlineData(0.43, "quarenta e três")]
        [InlineData(0.44, "quarenta e quatro")]
        [InlineData(0.45, "quarenta e cinco")]
        [InlineData(0.46, "quarenta e seis")]
        [InlineData(0.47, "quarenta e sete")]
        [InlineData(0.48, "quarenta e oito")]
        [InlineData(0.49, "quarenta e nove")]
        [InlineData(0.50, "cinquenta")]
        [InlineData(0.51, "cinquenta e um")]
        [InlineData(0.52, "cinquenta e dois")]
        [InlineData(0.53, "cinquenta e três")]
        [InlineData(0.54, "cinquenta e quatro")]
        [InlineData(0.55, "cinquenta e cinco")]
        [InlineData(0.56, "cinquenta e seis")]
        [InlineData(0.57, "cinquenta e sete")]
        [InlineData(0.58, "cinquenta e oito")]
        [InlineData(0.59, "cinquenta e nove")]
        [InlineData(0.60, "sessenta")]
        [InlineData(0.61, "sessenta e um")]
        [InlineData(0.62, "sessenta e dois")]
        [InlineData(0.63, "sessenta e três")]
        [InlineData(0.64, "sessenta e quatro")]
        [InlineData(0.65, "sessenta e cinco")]
        [InlineData(0.66, "sessenta e seis")]
        [InlineData(0.67, "sessenta e sete")]
        [InlineData(0.68, "sessenta e oito")]
        [InlineData(0.69, "sessenta e nove")]
        [InlineData(0.70, "setenta")]
        [InlineData(0.71, "setenta e um")]
        [InlineData(0.72, "setenta e dois")]
        [InlineData(0.73, "setenta e três")]
        [InlineData(0.74, "setenta e quatro")]
        [InlineData(0.75, "setenta e cinco")]
        [InlineData(0.76, "setenta e seis")]
        [InlineData(0.77, "setenta e sete")]
        [InlineData(0.78, "setenta e oito")]
        [InlineData(0.79, "setenta e nove")]
        [InlineData(0.80, "oitenta")]
        [InlineData(0.81, "oitenta e um")]
        [InlineData(0.82, "oitenta e dois")]
        [InlineData(0.83, "oitenta e três")]
        [InlineData(0.84, "oitenta e quatro")]
        [InlineData(0.85, "oitenta e cinco")]
        [InlineData(0.86, "oitenta e seis")]
        [InlineData(0.87, "oitenta e sete")]
        [InlineData(0.88, "oitenta e oito")]
        [InlineData(0.89, "oitenta e nove")]
        [InlineData(0.90, "noventa")]
        [InlineData(0.91, "noventa e um")]
        [InlineData(0.92, "noventa e dois")]
        [InlineData(0.93, "noventa e três")]
        [InlineData(0.94, "noventa e quatro")]
        [InlineData(0.95, "noventa e cinco")]
        [InlineData(0.96, "noventa e seis")]
        [InlineData(0.97, "noventa e sete")]
        [InlineData(0.98, "noventa e oito")]
        [InlineData(0.99, "noventa e nove")]

        public void ValidarTodosNumerosDezenasDeDecimais(double numeroSolicitado, string dezenaDecimalPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterDezenaDecimalPorExtenso = numero.ObterDezenaDecimalPorExtenso();

            //Assert
            obterDezenaDecimalPorExtenso.Should().Be(dezenaDecimalPorExtenso);
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
        [InlineData(10, "dez")]
        [InlineData(11.00, "dez")]
        [InlineData(20, "vinte")]
        [InlineData(22.00, "vinte")]
        [InlineData(30, "trinta")]
        [InlineData(33.00, "trinta")]
        [InlineData(40, "quarenta")]
        [InlineData(44.00, "quarenta")]
        [InlineData(50, "cinquenta")]
        [InlineData(55.00, "cinquenta")]
        [InlineData(60, "sessenta")]
        [InlineData(66.00, "sessenta")]
        [InlineData(70, "setenta")]
        [InlineData(77.00, "setenta")]
        [InlineData(80, "oitenta")]
        [InlineData(88.00, "oitenta")]
        [InlineData(90, "noventa")]
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

        [Theory]
        [InlineData(1000, "mil")]
        [InlineData(1100, "mil e cem")]
        [InlineData(1110, "mil cento e dez")]
        [InlineData(1111.01, "mil cento e onze e um")]

        public void ObterNumeroCompletoPorExtenso(double numeroSolicitado, string numeroCompletoPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterNumeroCompletoPorExtenso = numero.ObterNumeroCompletoPorExtenso();

            //Assert
            obterNumeroCompletoPorExtenso.Should().Be(numeroCompletoPorExtenso);
        }
    }
}
