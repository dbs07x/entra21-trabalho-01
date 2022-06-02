using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExecutarNumero
    {
        public void Executar()
        {
            Numero numero = new Numero();
            Console.Write("Digite um número: ");
            numero.NumeroSolicitado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Exibir decimal por extenso: " + numero.ObterDecimalPorExtenso());
        }
    }
}
