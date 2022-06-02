using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Objetivo: Dado a entrada de uma data deverá escrever a mesma por extenso.
//● Classe: Calendário
//○ Propriedades:
//■ Data: DateTime
//○ Métodos:
//■ ObterMesPorExtenso
//■ ObterDiaPorExtenso
//■ ObterAnoPorExtenso
//■ ObterDataCompletaPorExtenso

//● Cenários de teste unitários:
//○ Cenário 01: Validar todos os meses por extenso;
//○ Cenário 02: Validar todos os dias por extenso;
//○ Cenário 03: Validar todos os anos a partir de 1970 até 2030 por extenso;
//○ Cenário 04: validar doze datas, sendo uma data por mês.
//● Classe principal: ExecutarCalendario

//○ Conter método executar, instanciando objeto da classe citada acima,
//permitindo o usuário escolher qual dos métodos citados acima ele deseja
//executar.

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
            Calendario executarCalendario = new Calendario();
            Console.Write("Digite a data: ");
            executarCalendario.Data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"A data é: {executarCalendario.Data.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"O dia é: {executarCalendario.ObterDiaPorExtenso()}");
            Console.WriteLine($"O mês é: {executarCalendario.ObterMesPorExtenso()}");
            Console.WriteLine($"O milhar é: {executarCalendario.Data.ToString("dd/MM/yyyy").Substring(6, 1)}");
            Console.WriteLine($"O ano é: {executarCalendario.ObterAnoPorExtenso()}");
        }
        
    }
}
