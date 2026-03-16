double[] salarios = new double[5];
String? valorDig;
double aumento=0;

for (int i = 0; i < 5; i++)
{
    do
    {
        Console.WriteLine("Digite o salário da " + (i + 1) + " pessoa: ");
        valorDig = Console.ReadLine();
        double.TryParse(valorDig, out salarios[i]);
        if (salarios[i] <= 0)
        {
            Console.WriteLine("Digite um salário válido");
        }
    } while (salarios[i] <= 0);
    if (salarios[i] < 1000)
    {
        aumento = (10 * salarios[i])/100;
        salarios[i] += aumento;
        Console.WriteLine("Seu salário teve um aumento! agora você recebe: " + salarios[i]);
    }
}

Console.WriteLine("\n================================ Tabela de Salários ================================"); // essa aqui foi inspirada em vc vito

for (int p = 0; p < 5; p++)
{
    Console.WriteLine((p+1) +" Salário: " + salarios[p] + "R$");
}

