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

        public string ObterDecimalPorExtenso()
        {
            var decimalPorExtenso = "";
            string numeroSolicitadoString = NumeroSolicitado.ToString().Substring(2, 4);

            return decimalPorExtenso;
        }

    }
}
