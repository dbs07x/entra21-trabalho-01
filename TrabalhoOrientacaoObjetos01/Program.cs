using TrabalhoOrientacaoObjetos01.Questao01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

Console.WriteLine(@"1 - Executar Numero
2 - Executar Calendário
3 - Executar Relógio
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    ExecutarNumero executarNumero = new ExecutarNumero();
    executarNumero.Executar();
}
else if (menu == 2)
{
    ExecutarCalendario executarCalendario = new ExecutarCalendario();
    executarCalendario.Executar();
}
else if (menu == 3)
{
    ExecutarRelogio executarRelogio = new ExecutarRelogio();
    executarRelogio.Executar();
}