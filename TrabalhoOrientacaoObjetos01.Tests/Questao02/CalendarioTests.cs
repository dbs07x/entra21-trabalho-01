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
    // Aluno: Gustavo Lemos
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

        [Theory]
        [InlineData("2000/01/01", "janeiro")] [InlineData("2000/02/01", "fevereiro")] [InlineData("2000/03/01", "março")]
        [InlineData("2000/04/01", "abril")] [InlineData("2000/05/01", "maio")] [InlineData("2000/06/01", "junho")]
        [InlineData("2000/07/01", "julho")] [InlineData("2000/08/01", "agosto")] [InlineData("2000/09/01", "setembro")]
        [InlineData("2000/10/01", "outubro")] [InlineData("2000/11/01", "novembro")] [InlineData("2000/12/01", "dezembro")]
        public void Validar_ObterMesPorExtenso_Para_Todos_Meses(DateTime data, string mesPorExtenso)
        {
            // Arrange
            Calendario calendarioTeste = new Calendario();
            calendarioTeste.Data = data;

            // Act
            string mesObtido = calendarioTeste.ObterMesPorExtenso();
            string mesEsperado = mesPorExtenso;

            // Assert
            mesObtido.Should().Be(mesEsperado);
        }

        [Theory]
        [InlineData("1970/01/01", "mil e novecentos e setenta")] [InlineData("1971/01/01", "mil e novecentos e setenta e um")]
        [InlineData("1972/01/01", "mil e novecentos e setenta e dois")] [InlineData("1973/01/01", "mil e novecentos e setenta e três")]
        [InlineData("1974/01/01", "mil e novecentos e setenta e quatro")] [InlineData("1975/01/01", "mil e novecentos e setenta e cinco")]
        [InlineData("1976/01/01", "mil e novecentos e setenta e seis")] [InlineData("1977/01/01", "mil e novecentos e setenta e sete")]
        [InlineData("1978/01/01", "mil e novecentos e setenta e oito")] [InlineData("1979/01/01", "mil e novecentos e setenta e nove")]
        [InlineData("1980/01/01", "mil e novecentos e oitenta")] [InlineData("1981/01/01", "mil e novecentos e oitenta e um")]
        [InlineData("1982/01/01", "mil e novecentos e oitenta e dois")] [InlineData("1983/01/01", "mil e novecentos e oitenta e três")]
        [InlineData("1984/01/01", "mil e novecentos e oitenta e quatro")] [InlineData("1985/01/01", "mil e novecentos e oitenta e cinco")]
        [InlineData("1986/01/01", "mil e novecentos e oitenta e seis")] [InlineData("1987/01/01", "mil e novecentos e oitenta e sete")]
        [InlineData("1988/01/01", "mil e novecentos e oitenta e oito")] [InlineData("1989/01/01", "mil e novecentos e oitenta e nove")]
        [InlineData("1990/01/01", "mil e novecentos e noventa")] [InlineData("1991/01/01", "mil e novecentos e noventa e um")]
        [InlineData("1992/01/01", "mil e novecentos e noventa e dois")] [InlineData("1993/01/01", "mil e novecentos e noventa e três")]
        [InlineData("1994/01/01", "mil e novecentos e noventa e quatro")] [InlineData("1995/01/01", "mil e novecentos e noventa e cinco")]
        [InlineData("1996/01/01", "mil e novecentos e noventa e seis")] [InlineData("1997/01/01", "mil e novecentos e noventa e sete")]
        [InlineData("1998/01/01", "mil e novecentos e noventa e oito")] [InlineData("1999/01/01", "mil e novecentos e noventa e nove")]
        [InlineData("2000/01/01", "dois mil")] [InlineData("2001/01/01", "dois mil e um")]
        [InlineData("2002/01/01", "dois mil e dois")] [InlineData("2003/01/01", "dois mil e três")]
        [InlineData("2004/01/01", "dois mil e quatro")] [InlineData("2005/01/01", "dois mil e cinco")]
        [InlineData("2006/01/01", "dois mil e seis")] [InlineData("2007/01/01", "dois mil e sete")]
        [InlineData("2008/01/01", "dois mil e oito")] [InlineData("2009/01/01", "dois mil e nove")]
        [InlineData("2010/01/01", "dois mil e dez")] [InlineData("2011/01/01", "dois mil e onze")]
        [InlineData("2012/01/01", "dois mil e doze")] [InlineData("2013/01/01", "dois mil e treze")]
        [InlineData("2014/01/01", "dois mil e quatorze")] [InlineData("2015/01/01", "dois mil e quinze")]
        [InlineData("2016/01/01", "dois mil e dezesseis")] [InlineData("2017/01/01", "dois mil e dezessete")]
        [InlineData("2018/01/01", "dois mil e dezoito")] [InlineData("2019/01/01", "dois mil e dezenove")]
        [InlineData("2020/01/01", "dois mil e vinte")] [InlineData("2021/01/01", "dois mil e vinte e um")]
        [InlineData("2022/01/01", "dois mil e vinte e dois")] [InlineData("2023/01/01", "dois mil e vinte e três")]
        [InlineData("2024/01/01", "dois mil e vinte e quatro")] [InlineData("2025/01/01", "dois mil e vinte e cinco")]
        [InlineData("2026/01/01", "dois mil e vinte e seis")] [InlineData("2027/01/01", "dois mil e vinte e sete")]
        [InlineData("2028/01/01", "dois mil e vinte e oito")] [InlineData("2029/01/01", "dois mil e vinte e nove")]
        [InlineData("2030/01/01", "dois mil e trinta")]


        public void Validar_ObterAnoPorExtenso_Para_Anos_1970_Ate_2030(DateTime data, string anoPorExtenso)
        {
            // Arrange
            Calendario calendarioTeste = new Calendario();
            calendarioTeste.Data = data;

            // Act
            string anoObtido = calendarioTeste.ObterAnoPorExtenso();
            string anoEsperado = anoPorExtenso;

            // Assert
            anoObtido.Should().Be(anoEsperado);
        }

        [Theory]
        [InlineData("1970/01/01", "Um de janeiro de mil e novecentos e setenta")] [InlineData("1980/02/11", "Onze de fevereiro de mil e novecentos e oitenta")]
        [InlineData("1990/03/13", "Treze de março de mil e novecentos e noventa")] [InlineData("2000/04/21", "Vinte e um de abril de dois mil")]
        [InlineData("2010/05/25", "Vinte e cinco de maio de dois mil e dez")] [InlineData("2020/06/30", "Trinta de junho de dois mil e vinte")]
        [InlineData("2030/07/31", "Trinta e um de julho de dois mil e trinta")] [InlineData("1000/08/30", "Trinta de agosto de mil")]
        [InlineData("0500/09/25", "Vinte e cinco de setembro de quinhentos")] [InlineData("0011/10/17", "Dezessete de outubro de onze")]
        [InlineData("0009/11/12", "Doze de novembro de nove")] [InlineData("0001/12/29", "Vinte e nove de dezembro de um")]

        public void Validar_ObterDataCompletaPorExtenso_Para_Doze_Datas_Diferentes_Sendo_Cada_Uma_Em_Um_Mes_Diferente(DateTime data, string dataCompletaPorExtenso)
        {
            // Arrange
            Calendario calendarioTeste = new Calendario();
            calendarioTeste.Data = data;

            // Act
            string dataCompletaObtida = calendarioTeste.ObterDataCompletaPorExtenso();
            string dataCompletaEsperada = dataCompletaPorExtenso;

            // Assert
            dataCompletaObtida.Should().Be(dataCompletaEsperada);
        }
    }
}
