using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Objetivo: Dado a entrada de um valor decimal, deverá escrever o mesmo por extenso.
- Classe: Número

- Propriedades:
- Valor: double

- Métodos:
- ObterDecimalPorExtenso
- ObterUnidadePorExtenso
- ObterDezenaPorExtenso
- ObterCentenaPorExtenso
- ObterUnidadeDeMilharPorExtenso
- ObterNumeroCompletoPorExtenso

- Cenários de teste unitários:
- Cenário 01: Validar todos os valores decimais de 0 até 99;
- Cenário 02: Validar todos os números menores que 10;
- Cenário 03: Validar todos os números menores que 100;
- Cenário 04: Validar 10 números, sendo um para cada centena;
- Cenário 05: Validar unidade de milhar, com dez números;
- Cenário 06: Validar o número completo por extenso, com 5 cenários.

- Classe Principal:
- Conter método executar, instanciando objeto da classe citada acima,
permitindo o usuário escolher qual dos métodos citados acima ele deseja
executar.*/

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class Numero
    {
        public double NumeroSolicitado;

        //Como os métodos solicitados vão até unidade de milhar, definimos que o valor máximo permitido será 9999,99
        public string ObterDecimalPorExtenso()
        {
            string decimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString();
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

            if ((unidadeDecimal == 0) && (dezenaDecimal == 0))
            {
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "um";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "dois";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "três";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "quatro";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "cinco";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "seis";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "sete";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "oito";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "nove";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "dez";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "onze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "doze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "treze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "catorze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "quinze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "dezesseis";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "dezessete";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "dezoito";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "dezenove";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "vinte";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "vinte e um";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "vinte e dois";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "vinte e três";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "vinte e quatro";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "vinte e cinco";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "vinte e seis";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "vinte e sete";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "vinte e oito";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "vinte e nove";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "trinta";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "trinta e um";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "trinta e dois";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "trinta e três";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "trinta e quatro";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "trinta e cinco";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "trinta e seis";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "trinta e sete";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "trinta e oito";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "trinta e nove";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "quarenta";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "quarenta e um";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "quarenta e dois";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "quarenta e três";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "quarenta e quatro";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "quarenta e cinco";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "quarenta e seis";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "quarenta e sete";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "quarenta e oito";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "quarenta e nove";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "cinquenta";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "cinquenta e um";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "cinquenta e dois";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "cinquenta e três";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "cinquenta e quatro";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "cinquenta e cinco";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "cinquenta e seis";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "cinquenta e sete";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "cinquenta e oito";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "cinquenta e nove";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "sessenta";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "sessenta e um";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "sessenta e dois";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "sessenta e três";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "sessenta e quatro";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "sessenta e cinco";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "sessenta e seis";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "sessenta e sete";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "sessenta e oito";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "sessenta e nove";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "setenta";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "setenta e um";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "setenta e dois";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "setenta e três";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "setenta e quatro";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "setenta e cinco";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "setenta e seis";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "setenta e sete";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "setenta e oito";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "setenta e nove";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "oitenta";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "oitenta e um";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "oitenta e dois";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "oitenta e três";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "oitenta e quatro";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "oitenta e cinco";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "oitenta e seis";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "oitenta e sete";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "oitenta e oito";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "oitenta e nove";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "noventa";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "noventa e um";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "noventa e dois";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "noventa e três";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "noventa e quatro";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "noventa e cinco";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "noventa e seis";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "noventa e sete";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "noventa e oito";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "noventa e nove";
            }

            return decimalPorExtenso;
        }
        public string ObterUnidadePorExtenso()
        {
            string unidadePorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString();
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidade = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 1, 1));

            if (unidade == 1)
            {
                unidadePorExtenso = "um";
            }

            if (unidade == 2)
            {
                unidadePorExtenso = "dois";
            }

            if (unidade == 3)
            {
                unidadePorExtenso = "três";
            }

            if (unidade == 4)
            {
                unidadePorExtenso = "quatro";
            }

            if (unidade == 5)
            {
                unidadePorExtenso = "cinco";
            }

            if (unidade == 6)
            {
                unidadePorExtenso = "seis";
            }

            if (unidade == 7)
            {
                unidadePorExtenso = "sete";
            }

            if (unidade == 8)
            {
                unidadePorExtenso = "oito";
            }

            if (unidade == 9)
            {
                unidadePorExtenso = "nove";
            }

            return unidadePorExtenso;
        }
        public string ObterDezenaPorExtenso()
        {
            string dezenaPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString();
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int dezena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 2, 1));

            if (dezena == 1)
            {
                dezenaPorExtenso = "dez";
            }

            if (dezena == 2)
            {
                dezenaPorExtenso = "vinte";
            }

            if (dezena == 3)
            {
                dezenaPorExtenso = "trinta";
            }

            if (dezena == 4)
            {
                dezenaPorExtenso = "quarenta";
            }

            if (dezena == 5)
            {
                dezenaPorExtenso = "cinquenta";
            }

            if (dezena == 6)
            {
                dezenaPorExtenso = "sessenta";
            }

            if (dezena == 7)
            {
                dezenaPorExtenso = "setenta";
            }

            if (dezena == 8)
            {
                dezenaPorExtenso = "oitenta";
            }

            if (dezena == 9)
            {
                dezenaPorExtenso = "noventa";
            }

            return dezenaPorExtenso;
        }
        public string ObterCentenaPorExtenso()
        {
            string centenaPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString();
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int centena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 3, 1));

            if (centena == 1)
            {
                centenaPorExtenso = "cem";
            }

            if (centena == 2)
            {
                centenaPorExtenso = "duzentos";
            }

            if (centena == 3)
            {
                centenaPorExtenso = "trezentos";
            }

            if (centena == 4)
            {
                centenaPorExtenso = "quatrocentos";
            }

            if (centena == 5)
            {
                centenaPorExtenso = "quinhentos";
            }

            if (centena == 6)
            {
                centenaPorExtenso = "seiscentos";
            }

            if (centena == 7)
            {
                centenaPorExtenso = "setecentos";
            }

            if (centena == 8)
            {
                centenaPorExtenso = "oitocentos";
            }

            if (centena == 9)
            {
                centenaPorExtenso = "novecentos";
            }

            return centenaPorExtenso;
        }
        public string ObterUnidadeDeMilharPorExtenso()
        {

        }
    }
}