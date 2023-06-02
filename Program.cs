double x1, x2;

Console.WriteLine("-- Cálculo de Bhaskara --");

Console.WriteLine("Digite qual será o valor de (A)... ");
double valorA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite qual será o valor de (B)... ");
double valorB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite qual será o valor de (C)... ");
double valorC = Convert.ToDouble(Console.ReadLine());

if (valorA <= 0)
{
    Console.WriteLine("A equação descrita não equivale à uma equação do segundo grau! ");
    Console.WriteLine($"O Valor inserido para (A) foi {valorA} ");
    return;
}

else 
{
    double resultadoDelta = Math.Sqrt((valorB * valorB) - (4 * valorA * valorC));
        if (resultadoDelta <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Como o valor de delta é ({resultadoDelta}), a equação não possui valores reais. ");
            Console.ResetColor();
            return;
        }

        else 
        {
            x1 = (-valorB + (resultadoDelta)) / (2 * valorA);
            x2 = (-valorB - (resultadoDelta)) / (2 * valorA);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Os possíveis resultados da sua equação são x1 = {x1}/ x2 = {x2}");
            Console.ResetColor();
            Console.WriteLine("");
        }
}
