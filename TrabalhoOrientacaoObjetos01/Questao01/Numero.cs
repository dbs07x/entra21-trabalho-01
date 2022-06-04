using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aluno: Douglas Braatz de Souza

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
        //public string ObterDecimalPorExtenso()
        //{
        //    string decimalPorExtenso = "";
        //    string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
        //    int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
        //    int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
        //    int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

        //    if ((unidadeDecimal == 0) && (dezenaDecimal == 0))
        //    {
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "um";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "dois";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "três";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "quatro";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "cinco";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "seis";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "sete";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "oito";
        //    }

        //    else if ((dezenaDecimal == 0) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "nove";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "dez";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "onze";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "doze";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "treze";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "catorze";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "quinze";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "dezesseis";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "dezessete";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "dezoito";
        //    }

        //    else if ((dezenaDecimal == 1) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "dezenove";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "vinte";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "vinte e um";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "vinte e dois";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "vinte e três";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "vinte e quatro";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "vinte e cinco";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "vinte e seis";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "vinte e sete";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "vinte e oito";
        //    }

        //    else if ((dezenaDecimal == 2) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "vinte e nove";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "trinta";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "trinta e um";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "trinta e dois";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "trinta e três";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "trinta e quatro";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "trinta e cinco";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "trinta e seis";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "trinta e sete";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "trinta e oito";
        //    }

        //    else if ((dezenaDecimal == 3) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "trinta e nove";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "quarenta";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "quarenta e um";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "quarenta e dois";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "quarenta e três";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "quarenta e quatro";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "quarenta e cinco";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "quarenta e seis";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "quarenta e sete";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "quarenta e oito";
        //    }

        //    else if ((dezenaDecimal == 4) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "quarenta e nove";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "cinquenta";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "cinquenta e um";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "cinquenta e dois";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "cinquenta e três";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "cinquenta e quatro";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "cinquenta e cinco";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "cinquenta e seis";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "cinquenta e sete";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "cinquenta e oito";
        //    }

        //    else if ((dezenaDecimal == 5) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "cinquenta e nove";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "sessenta";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "sessenta e um";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "sessenta e dois";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "sessenta e três";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "sessenta e quatro";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "sessenta e cinco";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "sessenta e seis";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "sessenta e sete";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "sessenta e oito";
        //    }

        //    else if ((dezenaDecimal == 6) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "sessenta e nove";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "setenta";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "setenta e um";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "setenta e dois";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "setenta e três";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "setenta e quatro";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "setenta e cinco";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "setenta e seis";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "setenta e sete";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "setenta e oito";
        //    }

        //    else if ((dezenaDecimal == 7) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "setenta e nove";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "oitenta";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "oitenta e um";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "oitenta e dois";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "oitenta e três";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "oitenta e quatro";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "oitenta e cinco";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "oitenta e seis";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "oitenta e sete";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "oitenta e oito";
        //    }

        //    else if ((dezenaDecimal == 8) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "oitenta e nove";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 0))
        //    {
        //        decimalPorExtenso = "noventa";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 1))
        //    {
        //        decimalPorExtenso = "noventa e um";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 2))
        //    {
        //        decimalPorExtenso = "noventa e dois";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 3))
        //    {
        //        decimalPorExtenso = "noventa e três";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 4))
        //    {
        //        decimalPorExtenso = "noventa e quatro";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 5))
        //    {
        //        decimalPorExtenso = "noventa e cinco";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 6))
        //    {
        //        decimalPorExtenso = "noventa e seis";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 7))
        //    {
        //        decimalPorExtenso = "noventa e sete";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 8))
        //    {
        //        decimalPorExtenso = "noventa e oito";
        //    }

        //    else if ((dezenaDecimal == 9) && (unidadeDecimal == 9))
        //    {
        //        decimalPorExtenso = "noventa e nove";
        //    }

        //    return decimalPorExtenso;
        //}

        public string ObterUnidadeDecimalPorExtenso()
        {
            string unidadeDecimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

            if ((dezenaDecimal == 0) && (unidadeDecimal == 0))
            {
                unidadeDecimalPorExtenso = "zero";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 1))
            {
                unidadeDecimalPorExtenso = "um";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 2))
            {
                unidadeDecimalPorExtenso = "dois";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 3))
            {
                unidadeDecimalPorExtenso = "três";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 4))
            {
                unidadeDecimalPorExtenso = "quatro";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 5))
            {
                unidadeDecimalPorExtenso = "cinco";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 6))
            {
                unidadeDecimalPorExtenso = "seis";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 7))
            {
                unidadeDecimalPorExtenso = "sete";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 8))
            {
                unidadeDecimalPorExtenso = "oito";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 9))
            {
                unidadeDecimalPorExtenso = "nove";
            }

            return unidadeDecimalPorExtenso;
        }

        public string ObterDezenaDecimalPorExtenso()
        {
            string dezenaDecimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

            if ((dezenaDecimal == 0) && (unidadeDecimal == 0))
            {
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "dez";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "onze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "doze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "treze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "catorze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "quinze";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "dezesseis";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "dezessete";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "dezoito";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "dezenove";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "vinte";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "vinte e um";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "vinte e dois";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "vinte e três";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "vinte e quatro";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "vinte e cinco";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "vinte e seis";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "vinte e sete";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "vinte e oito";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "vinte e nove";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "trinta";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "trinta e um";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "trinta e dois";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "trinta e três";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "trinta e quatro";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "trinta e cinco";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "trinta e seis";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "trinta e sete";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "trinta e oito";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "trinta e nove";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "quarenta";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "quarenta e um";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "quarenta e dois";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "quarenta e três";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "quarenta e quatro";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "quarenta e cinco";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "quarenta e seis";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "quarenta e sete";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "quarenta e oito";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "quarenta e nove";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "cinquenta";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "cinquenta e um";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "cinquenta e dois";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "cinquenta e três";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "cinquenta e quatro";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "cinquenta e cinco";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "cinquenta e seis";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "cinquenta e sete";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "cinquenta e oito";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "cinquenta e nove";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "sessenta";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "sessenta e um";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "sessenta e dois";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "sessenta e três";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "sessenta e quatro";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "sessenta e cinco";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "sessenta e seis";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "sessenta e sete";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "sessenta e oito";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "sessenta e nove";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "setenta";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "setenta e um";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "setenta e dois";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "setenta e três";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "setenta e quatro";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "setenta e cinco";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "setenta e seis";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "setenta e sete";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "setenta e oito";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "setenta e nove";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "oitenta";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "oitenta e um";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "oitenta e dois";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "oitenta e três";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "oitenta e quatro";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "oitenta e cinco";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "oitenta e seis";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "oitenta e sete";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "oitenta e oito";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "oitenta e nove";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 0))
            {
                dezenaDecimalPorExtenso = "noventa";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 1))
            {
                dezenaDecimalPorExtenso = "noventa e um";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 2))
            {
                dezenaDecimalPorExtenso = "noventa e dois";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 3))
            {
                dezenaDecimalPorExtenso = "noventa e três";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 4))
            {
                dezenaDecimalPorExtenso = "noventa e quatro";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 5))
            {
                dezenaDecimalPorExtenso = "noventa e cinco";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 6))
            {
                dezenaDecimalPorExtenso = "noventa e seis";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 7))
            {
                dezenaDecimalPorExtenso = "noventa e sete";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 8))
            {
                dezenaDecimalPorExtenso = "noventa e oito";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 9))
            {
                dezenaDecimalPorExtenso = "noventa e nove";
            }

            return dezenaDecimalPorExtenso;
        }

        public string ObterUnidadePorExtenso()
        {
            string unidadePorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidade = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 1, 1));

            if (unidade == 1)
            {
                unidadePorExtenso = "um";
            }

            else if (unidade == 2)
            {
                unidadePorExtenso = "dois";
            }

            else if (unidade == 3)
            {
                unidadePorExtenso = "três";
            }

            else if (unidade == 4)
            {
                unidadePorExtenso = "quatro";
            }

            else if (unidade == 5)
            {
                unidadePorExtenso = "cinco";
            }

            else if (unidade == 6)
            {
                unidadePorExtenso = "seis";
            }

            else if (unidade == 7)
            {
                unidadePorExtenso = "sete";
            }

            else if (unidade == 8)
            {
                unidadePorExtenso = "oito";
            }

            else if (unidade == 9)
            {
                unidadePorExtenso = "nove";
            }

            return unidadePorExtenso;
        }
        public string ObterDezenaPorExtenso()
        {
            string dezenaPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int dezena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 2, 1));

            if (dezena == 1)
            {
                dezenaPorExtenso = "dez";
            }

            else if (dezena == 2)
            {
                dezenaPorExtenso = "vinte";
            }

            else if (dezena == 3)
            {
                dezenaPorExtenso = "trinta";
            }

            else if (dezena == 4)
            {
                dezenaPorExtenso = "quarenta";
            }

            else if (dezena == 5)
            {
                dezenaPorExtenso = "cinquenta";
            }

            else if (dezena == 6)
            {
                dezenaPorExtenso = "sessenta";
            }

            else if (dezena == 7)
            {
                dezenaPorExtenso = "setenta";
            }

            else if (dezena == 8)
            {
                dezenaPorExtenso = "oitenta";
            }

            else if (dezena == 9)
            {
                dezenaPorExtenso = "noventa";
            }

            return dezenaPorExtenso;
        }
        public string ObterCentenaPorExtenso()
        {
            string centenaPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int centena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 3, 1));

            if (centena == 1)
            {
                centenaPorExtenso = "cem";
            }

            else if (centena == 2)
            {
                centenaPorExtenso = "duzentos";
            }

            else if (centena == 3)
            {
                centenaPorExtenso = "trezentos";
            }

            else if (centena == 4)
            {
                centenaPorExtenso = "quatrocentos";
            }

            else if (centena == 5)
            {
                centenaPorExtenso = "quinhentos";
            }

            else if (centena == 6)
            {
                centenaPorExtenso = "seiscentos";
            }

            else if (centena == 7)
            {
                centenaPorExtenso = "setecentos";
            }

            else if (centena == 8)
            {
                centenaPorExtenso = "oitocentos";
            }

            else if (centena == 9)
            {
                centenaPorExtenso = "novecentos";
            }

            return centenaPorExtenso;
        }
        public string ObterUnidadeDeMilharPorExtenso()
        {
            string milharPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");

            int milhar = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 5, 1));

            if (milhar == 1)
            {
                milharPorExtenso = "mil";
            }

            else if (milhar == 2)
            {
                milharPorExtenso = "dois mil";
            }

            else if (milhar == 3)
            {
                milharPorExtenso = "três mil";
            }

            else if (milhar == 4)
            {
                milharPorExtenso = "quatro mil";
            }

            else if (milhar == 5)
            {
                milharPorExtenso = "cinco mil";
            }

            else if (milhar == 6)
            {
                milharPorExtenso = "seis mil";
            }

            else if (milhar == 7)
            {
                milharPorExtenso = "sete mil";
            }

            else if (milhar == 8)
            {
                milharPorExtenso = "oito mil";
            }

            else if (milhar == 9)
            {
                milharPorExtenso = "nove mil";
            }

            return milharPorExtenso;
        }

        public string ObterNumeroCompletoPorExtenso()
        {
            string numeroCompletoPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2").PadLeft(7, '0');
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int milhar = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 5, 1));
            int centena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 3, 1));
            int dezena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 2, 1));
            int unidade = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 1, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));

            if (milhar > 0)
            {
                numeroCompletoPorExtenso = ObterUnidadeDeMilharPorExtenso();
            }

            if ((centena == 1) && (dezena == 0) && (unidade == 0))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " e " + ObterCentenaPorExtenso();
            }

            else if (centena >= 1)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " cento e ";
            }

            if (dezena > 0)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterDezenaDecimalPorExtenso();
            }

            else if (dezena >= 2)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterDezenaPorExtenso();
            }

            if ((unidade > 0) && (dezena >= 2))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterUnidadePorExtenso();
            }

            if ((dezenaDecimal == 0) && (unidadeDecimal > 1))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " e ";
            }

            else if (dezenaDecimal > 0)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " e " + ObterDezenaDecimalPorExtenso();
            }

            if (unidadeDecimal > 0)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterUnidadeDecimalPorExtenso();
            }

            return numeroCompletoPorExtenso;
        }
    }
}