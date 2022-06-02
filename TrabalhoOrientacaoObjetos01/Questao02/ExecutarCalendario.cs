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
            string opcao = "true";
            while (opcao == "true")
            {
                Console.Write(@"Menu
1 - Obter o dia por extenso
2 - Obter o mês por extenso
3 - Obter o ano por extenso
4 - Obter a data cómpleta por extenso
5 - Sair

Escolha uma das opções do menu: ");
                var escolhaUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                if (escolhaUsuario == 1)
                {
                    Console.WriteLine($"O dia por extenso é: {executarCalendario.ObterDiaPorExtenso()}");
                }
                else if (escolhaUsuario == 2)
                {
                    Console.WriteLine($"O mês por extenso é: {executarCalendario.ObterMesPorExtenso()}");
                }
                else if (escolhaUsuario == 3)
                {
                    Console.WriteLine($"O ano por extenso é: {executarCalendario.ObterAnoPorExtenso()}");
                }
                else if (escolhaUsuario == 4)
                {
                    Console.WriteLine($"A data completa por extenso é: {executarCalendario.ObterDataCompletaPorExtenso()}");
                }
                else
                {
                    break;
                }
                Console.Write("\n");
            }
        }

    }
}
