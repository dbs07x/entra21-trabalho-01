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
        [InlineData(0.00, "zero")]
        [InlineData(0.01, "um centésimo")]
        [InlineData(0.02, "dois centésimos")]
        [InlineData(0.03, "três centésimos")]
        [InlineData(0.04, "quatro centésimos")]
        [InlineData(0.05, "cinco centésimos")]
        [InlineData(0.06, "seis centésimos")]
        [InlineData(0.07, "sete centésimos")]
        [InlineData(0.08, "oito centésimos")]
        [InlineData(0.09, "nove centésimos")]

        public void ValidarTodosNumerosCentesimais(double numeroSolicitado, string centesimalPorExtenso)
        {
            //Arrange
            var numero = new Numero();
            numero.NumeroSolicitado = numeroSolicitado;

            //Act
            var obterCentesimalPorExtenso = numero.ObterCentesimalPorExtenso();

            //Assert
            obterCentesimalPorExtenso.Should().Be(centesimalPorExtenso);
        }

        [Theory]
        [InlineData(0.10, "dez centésimos")]
        [InlineData(0.11, "onze centésimos")]
        [InlineData(0.12, "doze centésimos")]
        [InlineData(0.13, "treze centésimos")]
        [InlineData(0.14, "catorze centésimos")]
        [InlineData(0.15, "quinze centésimos")]
        [InlineData(0.16, "dezesseis centésimos")]
        [InlineData(0.17, "dezessete centésimos")]
        [InlineData(0.18, "dezoito centésimos")]
        [InlineData(0.19, "dezenove centésimos")]
        [InlineData(0.20, "vinte centésimos")]
        [InlineData(0.21, "vinte e um centésimos")]
        [InlineData(0.22, "vinte e dois centésimos")]
        [InlineData(0.23, "vinte e três centésimos")]
        [InlineData(0.24, "vinte e quatro centésimos")]
        [InlineData(0.25, "vinte e cinco centésimos")]
        [InlineData(0.26, "vinte e seis centésimos")]
        [InlineData(0.27, "vinte e sete centésimos")]
        [InlineData(0.28, "vinte e oito centésimos")]
        [InlineData(0.29, "vinte e nove centésimos")]
        [InlineData(0.30, "trinta centésimos")]
        [InlineData(0.31, "trinta e um centésimos")]
        [InlineData(0.32, "trinta e dois centésimos")]
        [InlineData(0.33, "trinta e três centésimos")]
        [InlineData(0.34, "trinta e quatro centésimos")]
        [InlineData(0.35, "trinta e cinco centésimos")]
        [InlineData(0.36, "trinta e seis centésimos")]
        [InlineData(0.37, "trinta e sete centésimos")]
        [InlineData(0.38, "trinta e oito centésimos")]
        [InlineData(0.39, "trinta e nove centésimos")]
        [InlineData(0.40, "quarenta centésimos")]
        [InlineData(0.41, "quarenta e um centésimos")]
        [InlineData(0.42, "quarenta e dois centésimos")]
        [InlineData(0.43, "quarenta e três centésimos")]
        [InlineData(0.44, "quarenta e quatro centésimos")]
        [InlineData(0.45, "quarenta e cinco centésimos")]
        [InlineData(0.46, "quarenta e seis centésimos")]
        [InlineData(0.47, "quarenta e sete centésimos")]
        [InlineData(0.48, "quarenta e oito centésimos")]
        [InlineData(0.49, "quarenta e nove centésimos")]
        [InlineData(0.50, "cinquenta centésimos")]
        [InlineData(0.51, "cinquenta e um centésimos")]
        [InlineData(0.52, "cinquenta e dois centésimos")]
        [InlineData(0.53, "cinquenta e três centésimos")]
        [InlineData(0.54, "cinquenta e quatro centésimos")]
        [InlineData(0.55, "cinquenta e cinco centésimos")]
        [InlineData(0.56, "cinquenta e seis centésimos")]
        [InlineData(0.57, "cinquenta e sete centésimos")]
        [InlineData(0.58, "cinquenta e oito centésimos")]
        [InlineData(0.59, "cinquenta e nove centésimos")]
        [InlineData(0.60, "sessenta centésimos")]
        [InlineData(0.61, "sessenta e um centésimos")]
        [InlineData(0.62, "sessenta e dois centésimos")]
        [InlineData(0.63, "sessenta e três centésimos")]
        [InlineData(0.64, "sessenta e quatro centésimos")]
        [InlineData(0.65, "sessenta e cinco centésimos")]
        [InlineData(0.66, "sessenta e seis centésimos")]
        [InlineData(0.67, "sessenta e sete centésimos")]
        [InlineData(0.68, "sessenta e oito centésimos")]
        [InlineData(0.69, "sessenta e nove centésimos")]
        [InlineData(0.70, "setenta centésimos")]
        [InlineData(0.71, "setenta e um centésimos")]
        [InlineData(0.72, "setenta e dois centésimos")]
        [InlineData(0.73, "setenta e três centésimos")]
        [InlineData(0.74, "setenta e quatro centésimos")]
        [InlineData(0.75, "setenta e cinco centésimos")]
        [InlineData(0.76, "setenta e seis centésimos")]
        [InlineData(0.77, "setenta e sete centésimos")]
        [InlineData(0.78, "setenta e oito centésimos")]
        [InlineData(0.79, "setenta e nove centésimos")]
        [InlineData(0.80, "oitenta centésimos")]
        [InlineData(0.81, "oitenta e um centésimos")]
        [InlineData(0.82, "oitenta e dois centésimos")]
        [InlineData(0.83, "oitenta e três centésimos")]
        [InlineData(0.84, "oitenta e quatro centésimos")]
        [InlineData(0.85, "oitenta e cinco centésimos")]
        [InlineData(0.86, "oitenta e seis centésimos")]
        [InlineData(0.87, "oitenta e sete centésimos")]
        [InlineData(0.88, "oitenta e oito centésimos")]
        [InlineData(0.89, "oitenta e nove centésimos")]
        [InlineData(0.90, "noventa centésimos")]
        [InlineData(0.91, "noventa e um centésimos")]
        [InlineData(0.92, "noventa e dois centésimos")]
        [InlineData(0.93, "noventa e três centésimos")]
        [InlineData(0.94, "noventa e quatro centésimos")]
        [InlineData(0.95, "noventa e cinco centésimos")]
        [InlineData(0.96, "noventa e seis centésimos")]
        [InlineData(0.97, "noventa e sete centésimos")]
        [InlineData(0.98, "noventa e oito centésimos")]
        [InlineData(0.99, "noventa e nove centésimos")]

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
        [InlineData(1, "um")]
        [InlineData(2, "dois")]
        [InlineData(3, "três")]
        [InlineData(4, "quatro")]
        [InlineData(5, "cinco")]
        [InlineData(6, "seis")]
        [InlineData(7, "sete")]
        [InlineData(8, "oito")]
        [InlineData(9, "nove")]

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
        [InlineData(10.00, "dez")]
        [InlineData(10, "dez")]
        [InlineData(11, "onze")]
        [InlineData(12, "doze")]
        [InlineData(13, "treze")]
        [InlineData(14, "catorze")]
        [InlineData(15, "quinze")]
        [InlineData(16, "dezesseis")]
        [InlineData(17, "dezessete")]
        [InlineData(18, "dezoito")]
        [InlineData(19, "dezenove")]
        [InlineData(20, "vinte")]
        [InlineData(21, "vinte e um")]
        [InlineData(22, "vinte e dois")]
        [InlineData(23, "vinte e três")]
        [InlineData(24, "vinte e quatro")]
        [InlineData(25, "vinte e cinco")]
        [InlineData(26, "vinte e seis")]
        [InlineData(27, "vinte e sete")]
        [InlineData(28, "vinte e oito")]
        [InlineData(29, "vinte e nove")]
        [InlineData(30, "trinta")]
        [InlineData(31, "trinta e um")]
        [InlineData(32, "trinta e dois")]
        [InlineData(33, "trinta e três")]
        [InlineData(34, "trinta e quatro")]
        [InlineData(35, "trinta e cinco")]
        [InlineData(36, "trinta e seis")]
        [InlineData(37, "trinta e sete")]
        [InlineData(38, "trinta e oito")]
        [InlineData(39, "trinta e nove")]
        [InlineData(40, "quarenta")]
        [InlineData(41, "quarenta e um")]
        [InlineData(42, "quarenta e dois")]
        [InlineData(43, "quarenta e três")]
        [InlineData(44, "quarenta e quatro")]
        [InlineData(45, "quarenta e cinco")]
        [InlineData(46, "quarenta e seis")]
        [InlineData(47, "quarenta e sete")]
        [InlineData(48, "quarenta e oito")]
        [InlineData(49, "quarenta e nove")]
        [InlineData(50, "cinquenta")]
        [InlineData(51, "cinquenta e um")]
        [InlineData(52, "cinquenta e dois")]
        [InlineData(53, "cinquenta e três")]
        [InlineData(54, "cinquenta e quatro")]
        [InlineData(55, "cinquenta e cinco")]
        [InlineData(56, "cinquenta e seis")]
        [InlineData(57, "cinquenta e sete")]
        [InlineData(58, "cinquenta e oito")]
        [InlineData(59, "cinquenta e nove")]
        [InlineData(60, "sessenta")]
        [InlineData(61, "sessenta e um")]
        [InlineData(62, "sessenta e dois")]
        [InlineData(63, "sessenta e três")]
        [InlineData(64, "sessenta e quatro")]
        [InlineData(65, "sessenta e cinco")]
        [InlineData(66, "sessenta e seis")]
        [InlineData(67, "sessenta e sete")]
        [InlineData(68, "sessenta e oito")]
        [InlineData(69, "sessenta e nove")]
        [InlineData(70, "setenta")]
        [InlineData(71, "setenta e um")]
        [InlineData(72, "setenta e dois")]
        [InlineData(73, "setenta e três")]
        [InlineData(74, "setenta e quatro")]
        [InlineData(75, "setenta e cinco")]
        [InlineData(76, "setenta e seis")]
        [InlineData(77, "setenta e sete")]
        [InlineData(78, "setenta e oito")]
        [InlineData(79, "setenta e nove")]
        [InlineData(80, "oitenta")]
        [InlineData(81, "oitenta e um")]
        [InlineData(82, "oitenta e dois")]
        [InlineData(83, "oitenta e três")]
        [InlineData(84, "oitenta e quatro")]
        [InlineData(85, "oitenta e cinco")]
        [InlineData(86, "oitenta e seis")]
        [InlineData(87, "oitenta e sete")]
        [InlineData(88, "oitenta e oito")]
        [InlineData(89, "oitenta e nove")]
        [InlineData(90, "noventa")]
        [InlineData(91, "noventa e um")]
        [InlineData(92, "noventa e dois")]
        [InlineData(93, "noventa e três")]
        [InlineData(94, "noventa e quatro")]
        [InlineData(95, "noventa e cinco")]
        [InlineData(96, "noventa e seis")]
        [InlineData(97, "noventa e sete")]
        [InlineData(98, "noventa e oito")]
        [InlineData(99, "noventa e nove")]

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
        [InlineData(100.00, "cem")]
        [InlineData(111, "cem")]
        [InlineData(222, "duzentos")]
        [InlineData(333, "trezentos")]
        [InlineData(444, "quatrocentos")]
        [InlineData(555, "quinhentos")]
        [InlineData(666, "seiscentos")]
        [InlineData(777, "setecentos")]
        [InlineData(888, "oitocentos")]
        [InlineData(999, "novecentos")]

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
        [InlineData(1000.00, "mil")]
        [InlineData(1111, "mil")]
        [InlineData(2222, "dois mil")]
        [InlineData(3333, "três mil")]
        [InlineData(4444, "quatro mil")]
        [InlineData(5555, "cinco mil")]
        [InlineData(6666, "seis mil")]
        [InlineData(7777, "sete mil")]
        [InlineData(8888, "oito mil")]
        [InlineData(9999, "nove mil")]

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
        [InlineData(0.01, "um centésimo")]
        [InlineData(0.02, "dois centésimos")]
        [InlineData(0.03, "três centésimos")]
        [InlineData(0.11, "onze centésimos")]
        [InlineData(0.12, "doze centésimos")]
        [InlineData(0.13, "treze centésimos")]
        [InlineData(1, "um inteiro")]
        [InlineData(1.11, "um inteiro e onze centésimos")]
        [InlineData(2.22, "dois inteiros e vinte e dois centésimos")]
        [InlineData(3.33, "três inteiros e trinta e três centésimos")]
        [InlineData(10, "dez inteiros")]
        [InlineData(11.11, "onze inteiros e onze centésimos")]
        [InlineData(12.22, "doze inteiros e vinte e dois centésimos")]
        [InlineData(13.33, "treze inteiros e trinta e três centésimos")]
        [InlineData(100, "cem inteiros")]
        [InlineData(111.11, "cento e onze inteiros e onze centésimos")]
        [InlineData(222.22, "duzentos e vinte e dois inteiros e vinte e dois centésimos")]
        [InlineData(333.33, "trezentos e trinta e três inteiros e trinta e três centésimos")]
        [InlineData(1000, "mil inteiros")]
        [InlineData(1111.11, "mil cento e onze inteiros e onze centésimos")]
        [InlineData(1234.56, "mil duzentos e trinta e quatro inteiros e cinquenta e seis centésimos")]
        [InlineData(2222.22, "dois mil duzentos e vinte e dois inteiros e vinte e dois centésimos")]
        [InlineData(3333.33, "três mil trezentos e trinta e três inteiros e trinta e três centésimos")]
        [InlineData(9876.54, "nove mil oitocentos e setenta e seis inteiros e cinquenta e quatro centésimos")]

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
