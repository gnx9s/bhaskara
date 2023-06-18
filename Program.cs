double x1, x2;

mensagem("-- Cálculo de Bhaskara --", ConsoleColor.DarkYellow);

mensagem("Digite qual será o valor de (A)... ", ConsoleColor.White);
double valorA = Convert.ToDouble(Console.ReadLine());

mensagem("Digite qual será o valor de (B)... ", ConsoleColor.White);
double valorB = Convert.ToDouble(Console.ReadLine());

mensagem("Digite qual será o valor de (C)... ", ConsoleColor.White);
double valorC = Convert.ToDouble(Console.ReadLine());

if (valorA <= 0)
{
    mensagem("A equação descrita não equivale à uma equação do segundo grau!", ConsoleColor.DarkRed);
    mensagem($"O Valor inserido para (A) foi {valorA} ", ConsoleColor.DarkRed);;
    return;
}

else 
{
    double resultadoDelta = Math.Sqrt((valorB * valorB) - (4 * valorA * valorC));
        if (resultadoDelta <= 0)
        {
            mensagem($"Como o valor de delta é ({resultadoDelta}), a equação não possui valores reais. ", ConsoleColor.DarkRed);
            return;
        }

        else 
        {
            x1 = (-valorB + (resultadoDelta)) / (2 * valorA);
            x2 = (-valorB - (resultadoDelta)) / (2 * valorA);

            mensagem($"Os possíveis resultados da sua equação são x1 = {x1}/ x2 = {x2}", ConsoleColor.Green);
        }
}


void mensagem(string mensagem, ConsoleColor corTexto)
{
    Console.ForegroundColor = corTexto;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}
