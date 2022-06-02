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
            int posicaoUnidadeDecimal = posicaoVirgulaDecimal + 2;
            int posicaoDezenaDecimal = posicaoVirgulaDecimal + 1;
            int unidadeDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoUnidadeDecimal));
            int dezenaDecimal = Convert.ToInt32(numeroSolicitadoString.Substring(posicaoDezenaDecimal, posicaoDezenaDecimal)); //<<<<<<<<<<<< Verificar

            if ((unidadeDecimal == 0) && (dezenaDecimal == 0))
            {
                //?
            }

            else if ((unidadeDecimal == 1) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "um";
            }

            else if ((unidadeDecimal == 2) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "dois";
            }

            else if ((unidadeDecimal == 3) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "três";
            }

            else if ((unidadeDecimal == 4) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "quatro";
            }

            else if ((unidadeDecimal == 5) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "cinco";
            }

            else if ((unidadeDecimal == 6) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "seis";
            }

            else if ((unidadeDecimal == 7) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "sete";
            }

            else if ((unidadeDecimal == 8) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "oito";
            }

            else if ((unidadeDecimal == 9) && (dezenaDecimal == 0))
            {
                decimalPorExtenso = "nove";
            }

            return decimalPorExtenso;
        }
    }
}
