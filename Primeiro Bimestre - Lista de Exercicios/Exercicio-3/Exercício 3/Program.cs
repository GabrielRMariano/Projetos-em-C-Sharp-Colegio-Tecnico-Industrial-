int n = 0;
string? ns;

Console.WriteLine("Digite o valor de N: ");
ns = Console.ReadLine();    
Int32.TryParse(ns, out n);

double[] valores = new double[n];
double soma = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite números para fazermos uma média: ");
    ns = Console.ReadLine();
    double.TryParse(ns, out valores[i]);
    soma += valores[i];
}

Console.WriteLine("Média dos valores: " + soma/n);