using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        [InlineData()]

        public void ValidarTodosNumerosDecimais(int numeroDecimal, string numeroDecimalPorExtenso)
        {
            //Arrange
            var numero = new Numero();


            //Act

            //Assert
        }

    }
}
