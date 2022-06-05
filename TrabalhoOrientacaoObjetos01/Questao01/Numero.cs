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

        //Como os métodos solicitados vão até unidade de milhar, definimos os métodos para o valor máximo de 9999,99

        public string ObterCentesimalPorExtenso()
        {
            string numeroCentesimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

            if ((dezenaDecimal == 0) && (unidadeDecimal == 0))
            {
                numeroCentesimalPorExtenso = "zero";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 1))
            {
                numeroCentesimalPorExtenso = "um centésimo";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 2))
            {
                numeroCentesimalPorExtenso = "dois centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 3))
            {
                numeroCentesimalPorExtenso = "três centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 4))
            {
                numeroCentesimalPorExtenso = "quatro centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 5))
            {
                numeroCentesimalPorExtenso = "cinco centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 6))
            {
                numeroCentesimalPorExtenso = "seis centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 7))
            {
                numeroCentesimalPorExtenso = "sete centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 8))
            {
                numeroCentesimalPorExtenso = "oito centésimos";
            }

            else if ((dezenaDecimal == 0) && (unidadeDecimal == 9))
            {
                numeroCentesimalPorExtenso = "nove centésimos";
            }

            return numeroCentesimalPorExtenso;
        }
        public string ObterDecimalPorExtenso()
        {
            string decimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2");
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));

            if ((dezenaDecimal == 0) && (unidadeDecimal == 0))
            {
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "dez centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "onze centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "doze centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "treze centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "catorze centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "quinze centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "dezesseis centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "dezessete centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "dezoito centésimos";
            }

            else if ((dezenaDecimal == 1) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "dezenove centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "vinte centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "vinte e um centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "vinte e dois centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "vinte e três centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "vinte e quatro centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "vinte e cinco centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "vinte e seis centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "vinte e sete centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "vinte e oito centésimos";
            }

            else if ((dezenaDecimal == 2) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "vinte e nove centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "trinta centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "trinta e um centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "trinta e dois centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "trinta e três centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "trinta e quatro centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "trinta e cinco centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "trinta e seis centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "trinta e sete centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "trinta e oito centésimos";
            }

            else if ((dezenaDecimal == 3) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "trinta e nove centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "quarenta centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "quarenta e um centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "quarenta e dois centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "quarenta e três centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "quarenta e quatro centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "quarenta e cinco centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "quarenta e seis centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "quarenta e sete centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "quarenta e oito centésimos";
            }

            else if ((dezenaDecimal == 4) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "quarenta e nove centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "cinquenta centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "cinquenta e um centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "cinquenta e dois centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "cinquenta e três centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "cinquenta e quatro centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "cinquenta e cinco centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "cinquenta e seis centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "cinquenta e sete centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "cinquenta e oito centésimos";
            }

            else if ((dezenaDecimal == 5) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "cinquenta e nove centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "sessenta centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "sessenta e um centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "sessenta e dois centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "sessenta e três centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "sessenta e quatro centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "sessenta e cinco centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "sessenta e seis centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "sessenta e sete centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "sessenta e oito centésimos";
            }

            else if ((dezenaDecimal == 6) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "sessenta e nove centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "setenta centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "setenta e um centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "setenta e dois centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "setenta e três centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "setenta e quatro centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "setenta e cinco centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "setenta e seis centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "setenta e sete centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "setenta e oito centésimos";
            }

            else if ((dezenaDecimal == 7) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "setenta e nove centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "oitenta centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "oitenta e um centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "oitenta e dois centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "oitenta e três centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "oitenta e quatro centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "oitenta e cinco centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "oitenta e seis centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "oitenta e sete centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "oitenta e oito centésimos";
            }

            else if ((dezenaDecimal == 8) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "oitenta e nove centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 0))
            {
                decimalPorExtenso = "noventa centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 1))
            {
                decimalPorExtenso = "noventa e um centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 2))
            {
                decimalPorExtenso = "noventa e dois centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 3))
            {
                decimalPorExtenso = "noventa e três centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 4))
            {
                decimalPorExtenso = "noventa e quatro centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 5))
            {
                decimalPorExtenso = "noventa e cinco centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 6))
            {
                decimalPorExtenso = "noventa e seis centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 7))
            {
                decimalPorExtenso = "noventa e sete centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 8))
            {
                decimalPorExtenso = "noventa e oito centésimos";
            }

            else if ((dezenaDecimal == 9) && (unidadeDecimal == 9))
            {
                decimalPorExtenso = "noventa e nove centésimos";
            }

            return decimalPorExtenso;
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
            int unidade = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 1, 1));

            if ((dezena == 1) && (unidade == 0))
            {
                dezenaPorExtenso = "dez";
            }

            else if ((dezena == 1) && (unidade == 1))
            {
                dezenaPorExtenso = "onze";
            }

            else if ((dezena == 1) && (unidade == 2))
            {
                dezenaPorExtenso = "doze";
            }

            else if ((dezena == 1) && (unidade == 3))
            {
                dezenaPorExtenso = "treze";
            }

            else if ((dezena == 1) && (unidade == 4))
            {
                dezenaPorExtenso = "catorze";
            }

            else if ((dezena == 1) && (unidade == 5))
            {
                dezenaPorExtenso = "quinze";
            }

            else if ((dezena == 1) && (unidade == 6))
            {
                dezenaPorExtenso = "dezesseis";
            }

            else if ((dezena == 1) && (unidade == 7))
            {
                dezenaPorExtenso = "dezessete";
            }

            else if ((dezena == 1) && (unidade == 8))
            {
                dezenaPorExtenso = "dezoito";
            }

            else if ((dezena == 1) && (unidade == 9))
            {
                dezenaPorExtenso = "dezenove";
            }

            else if ((dezena == 2) && (unidade == 0))
            {
                dezenaPorExtenso = "vinte";
            }

            else if ((dezena == 2) && (unidade == 1))
            {
                dezenaPorExtenso = "vinte e um";
            }

            else if ((dezena == 2) && (unidade == 2))
            {
                dezenaPorExtenso = "vinte e dois";
            }

            else if ((dezena == 2) && (unidade == 3))
            {
                dezenaPorExtenso = "vinte e três";
            }

            else if ((dezena == 2) && (unidade == 4))
            {
                dezenaPorExtenso = "vinte e quatro";
            }

            else if ((dezena == 2) && (unidade == 5))
            {
                dezenaPorExtenso = "vinte e cinco";
            }

            else if ((dezena == 2) && (unidade == 6))
            {
                dezenaPorExtenso = "vinte e seis";
            }

            else if ((dezena == 2) && (unidade == 7))
            {
                dezenaPorExtenso = "vinte e sete";
            }

            else if ((dezena == 2) && (unidade == 8))
            {
                dezenaPorExtenso = "vinte e oito";
            }

            else if ((dezena == 2) && (unidade == 9))
            {
                dezenaPorExtenso = "vinte e nove";
            }

            else if ((dezena == 3) && (unidade == 0))
            {
                dezenaPorExtenso = "trinta";
            }

            else if ((dezena == 3) && (unidade == 1))
            {
                dezenaPorExtenso = "trinta e um";
            }

            else if ((dezena == 3) && (unidade == 2))
            {
                dezenaPorExtenso = "trinta e dois";
            }

            else if ((dezena == 3) && (unidade == 3))
            {
                dezenaPorExtenso = "trinta e três";
            }

            else if ((dezena == 3) && (unidade == 4))
            {
                dezenaPorExtenso = "trinta e quatro";
            }

            else if ((dezena == 3) && (unidade == 5))
            {
                dezenaPorExtenso = "trinta e cinco";
            }

            else if ((dezena == 3) && (unidade == 6))
            {
                dezenaPorExtenso = "trinta e seis";
            }

            else if ((dezena == 3) && (unidade == 7))
            {
                dezenaPorExtenso = "trinta e sete";
            }

            else if ((dezena == 3) && (unidade == 8))
            {
                dezenaPorExtenso = "trinta e oito";
            }

            else if ((dezena == 3) && (unidade == 9))
            {
                dezenaPorExtenso = "trinta e nove";
            }

            else if ((dezena == 4) && (unidade == 0))
            {
                dezenaPorExtenso = "quarenta";
            }

            else if ((dezena == 4) && (unidade == 1))
            {
                dezenaPorExtenso = "quarenta e um";
            }

            else if ((dezena == 4) && (unidade == 2))
            {
                dezenaPorExtenso = "quarenta e dois";
            }

            else if ((dezena == 4) && (unidade == 3))
            {
                dezenaPorExtenso = "quarenta e três";
            }

            else if ((dezena == 4) && (unidade == 4))
            {
                dezenaPorExtenso = "quarenta e quatro";
            }

            else if ((dezena == 4) && (unidade == 5))
            {
                dezenaPorExtenso = "quarenta e cinco";
            }

            else if ((dezena == 4) && (unidade == 6))
            {
                dezenaPorExtenso = "quarenta e seis";
            }

            else if ((dezena == 4) && (unidade == 7))
            {
                dezenaPorExtenso = "quarenta e sete";
            }

            else if ((dezena == 4) && (unidade == 8))
            {
                dezenaPorExtenso = "quarenta e oito";
            }

            else if ((dezena == 4) && (unidade == 9))
            {
                dezenaPorExtenso = "quarenta e nove";
            }

            else if ((dezena == 5) && (unidade == 0))
            {
                dezenaPorExtenso = "cinquenta";
            }

            else if ((dezena == 5) && (unidade == 1))
            {
                dezenaPorExtenso = "cinquenta e um";
            }

            else if ((dezena == 5) && (unidade == 2))
            {
                dezenaPorExtenso = "cinquenta e dois";
            }

            else if ((dezena == 5) && (unidade == 3))
            {
                dezenaPorExtenso = "cinquenta e três";
            }

            else if ((dezena == 5) && (unidade == 4))
            {
                dezenaPorExtenso = "cinquenta e quatro";
            }

            else if ((dezena == 5) && (unidade == 5))
            {
                dezenaPorExtenso = "cinquenta e cinco";
            }

            else if ((dezena == 5) && (unidade == 6))
            {
                dezenaPorExtenso = "cinquenta e seis";
            }

            else if ((dezena == 5) && (unidade == 7))
            {
                dezenaPorExtenso = "cinquenta e sete";
            }

            else if ((dezena == 5) && (unidade == 8))
            {
                dezenaPorExtenso = "cinquenta e oito";
            }

            else if ((dezena == 5) && (unidade == 9))
            {
                dezenaPorExtenso = "cinquenta e nove";
            }

            else if ((dezena == 6) && (unidade == 0))
            {
                dezenaPorExtenso = "sessenta";
            }

            else if ((dezena == 6) && (unidade == 1))
            {
                dezenaPorExtenso = "sessenta e um";
            }

            else if ((dezena == 6) && (unidade == 2))
            {
                dezenaPorExtenso = "sessenta e dois";
            }

            else if ((dezena == 6) && (unidade == 3))
            {
                dezenaPorExtenso = "sessenta e três";
            }

            else if ((dezena == 6) && (unidade == 4))
            {
                dezenaPorExtenso = "sessenta e quatro";
            }

            else if ((dezena == 6) && (unidade == 5))
            {
                dezenaPorExtenso = "sessenta e cinco";
            }

            else if ((dezena == 6) && (unidade == 6))
            {
                dezenaPorExtenso = "sessenta e seis";
            }

            else if ((dezena == 6) && (unidade == 7))
            {
                dezenaPorExtenso = "sessenta e sete";
            }

            else if ((dezena == 6) && (unidade == 8))
            {
                dezenaPorExtenso = "sessenta e oito";
            }

            else if ((dezena == 6) && (unidade == 9))
            {
                dezenaPorExtenso = "sessenta e nove";
            }

            else if ((dezena == 7) && (unidade == 0))
            {
                dezenaPorExtenso = "setenta";
            }

            else if ((dezena == 7) && (unidade == 1))
            {
                dezenaPorExtenso = "setenta e um";
            }

            else if ((dezena == 7) && (unidade == 2))
            {
                dezenaPorExtenso = "setenta e dois";
            }

            else if ((dezena == 7) && (unidade == 3))
            {
                dezenaPorExtenso = "setenta e três";
            }

            else if ((dezena == 7) && (unidade == 4))
            {
                dezenaPorExtenso = "setenta e quatro";
            }

            else if ((dezena == 7) && (unidade == 5))
            {
                dezenaPorExtenso = "setenta e cinco";
            }

            else if ((dezena == 7) && (unidade == 6))
            {
                dezenaPorExtenso = "setenta e seis";
            }

            else if ((dezena == 7) && (unidade == 7))
            {
                dezenaPorExtenso = "setenta e sete";
            }

            else if ((dezena == 7) && (unidade == 8))
            {
                dezenaPorExtenso = "setenta e oito";
            }

            else if ((dezena == 7) && (unidade == 9))
            {
                dezenaPorExtenso = "setenta e nove";
            }

            else if ((dezena == 8) && (unidade == 0))
            {
                dezenaPorExtenso = "oitenta";
            }

            else if ((dezena == 8) && (unidade == 1))
            {
                dezenaPorExtenso = "oitenta e um";
            }

            else if ((dezena == 8) && (unidade == 2))
            {
                dezenaPorExtenso = "oitenta e dois";
            }

            else if ((dezena == 8) && (unidade == 3))
            {
                dezenaPorExtenso = "oitenta e três";
            }

            else if ((dezena == 8) && (unidade == 4))
            {
                dezenaPorExtenso = "oitenta e quatro";
            }

            else if ((dezena == 8) && (unidade == 5))
            {
                dezenaPorExtenso = "oitenta e cinco";
            }

            else if ((dezena == 8) && (unidade == 6))
            {
                dezenaPorExtenso = "oitenta e seis";
            }

            else if ((dezena == 8) && (unidade == 7))
            {
                dezenaPorExtenso = "oitenta e sete";
            }

            else if ((dezena == 8) && (unidade == 8))
            {
                dezenaPorExtenso = "oitenta e oito";
            }

            else if ((dezena == 8) && (unidade == 9))
            {
                dezenaPorExtenso = "oitenta e nove";
            }

            else if ((dezena == 9) && (unidade == 0))
            {
                dezenaPorExtenso = "noventa";
            }

            else if ((dezena == 9) && (unidade == 1))
            {
                dezenaPorExtenso = "noventa e um";
            }

            else if ((dezena == 9) && (unidade == 2))
            {
                dezenaPorExtenso = "noventa e dois";
            }

            else if ((dezena == 9) && (unidade == 3))
            {
                dezenaPorExtenso = "noventa e três";
            }

            else if ((dezena == 9) && (unidade == 4))
            {
                dezenaPorExtenso = "noventa e quatro";
            }

            else if ((dezena == 9) && (unidade == 5))
            {
                dezenaPorExtenso = "noventa e cinco";
            }

            else if ((dezena == 9) && (unidade == 6))
            {
                dezenaPorExtenso = "noventa e seis";
            }

            else if ((dezena == 9) && (unidade == 7))
            {
                dezenaPorExtenso = "noventa e sete";
            }

            else if ((dezena == 9) && (unidade == 8))
            {
                dezenaPorExtenso = "noventa e oito";
            }

            else if ((dezena == 9) && (unidade == 9))
            {
                dezenaPorExtenso = "noventa e nove";
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
            string numeroSolicitadoString = NumeroSolicitado.ToString("N2").PadLeft(8, '0');
            int posicaoVirgulaDecimal = numeroSolicitadoString.IndexOf(",");
            int milhar = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 5, 1));
            int centena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 3, 1));
            int dezena = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 2, 1));
            int unidade = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal - 1, 1));
            int numeroDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 1, 1));
            int centesimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoVirgulaDecimal + 2, 1));

            if ((milhar > 0) && (centena == 0) && (dezena == 0) && (unidade == 0))
            {
                numeroCompletoPorExtenso = ObterUnidadeDeMilharPorExtenso();
            }

            else if (milhar > 0)
            {
                numeroCompletoPorExtenso = ObterUnidadeDeMilharPorExtenso() + " ";
            }

            if ((milhar == 0) && (centena == 1) && (dezena == 0) && (unidade == 0))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + "cem";
            }

            else if (centena == 1)
            {
                if ((dezena > 0) || (unidade > 0))
                {
                    numeroCompletoPorExtenso = numeroCompletoPorExtenso + "cento e ";
                }
            }

            else if (centena > 1)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterCentenaPorExtenso() + " e ";
            }

            if (dezena > 0)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterDezenaPorExtenso();
            }

            if ((dezena < 1) && (unidade > 0))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterUnidadePorExtenso();
            }

            if ((milhar > 0) || (centena > 0) || (dezena > 0) || (unidade > 1))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " inteiros";
            }

            else if ((milhar == 0) && (centena == 0) && (dezena == 0) && (unidade == 1))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + " inteiro";
            }

            if ((milhar > 0) || (centena > 0) || (dezena > 0) || (unidade > 0))
            {
                if ((numeroDecimal > 0) || (centesimal > 0))
                {
                    numeroCompletoPorExtenso = numeroCompletoPorExtenso + " e ";
                }
            }

            if (numeroDecimal > 0)
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterDecimalPorExtenso();
            }

            if ((numeroDecimal == 0) && (centesimal > 0))
            {
                numeroCompletoPorExtenso = numeroCompletoPorExtenso + ObterCentesimalPorExtenso();
            }

            return numeroCompletoPorExtenso;
        }
    }
}