double[] salarios = new double[10];
String? valorDig;


for (int i = 0; i < 10; i++)
{
    do
    {
        Console.WriteLine("Digite o valor do " + (i + 1) + " salário:");
        valorDig = Console.ReadLine();
        double.TryParse(valorDig, out salarios[i]);
        if (salarios[i] <= 0)
        {
            Console.WriteLine("Por favor digite um salário válido");
        }
    } while (salarios[i] <= 0);
}

double maiorSal = salarios[0];

for (int t=0; t < 10; t++)
{
    if (salarios[t] > maiorSal)
    {
        maiorSal = salarios[t];
    }
}

Console.WriteLine("O maior salário foi de " + maiorSal + "R$");