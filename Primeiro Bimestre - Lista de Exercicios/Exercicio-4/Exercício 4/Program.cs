int qtdeAlunos;
String? valorDig;

Console.WriteLine("Digite a quantidade de alunos: ");
valorDig = Console.ReadLine();
Int32.TryParse(valorDig, out qtdeAlunos);

double[] notasG1 = new double[qtdeAlunos];
double[] notasG2 = new double[qtdeAlunos];
double[] medias = new double[qtdeAlunos];

for (int i = 0; i < qtdeAlunos ; i++)
{
    do
    {
        Console.WriteLine("Digite as notas G1 do aluno "+ (i+1) +": ");
        valorDig = Console.ReadLine();  
        double.TryParse(valorDig, out notasG1[i]);
        if (notasG1[i] < 0 || notasG1[i] > 10)
        {
            Console.WriteLine("Nota inválida por favor digite uma nota válida");
        }
    } while (notasG1[i]<0 || notasG1[i]>10);
    do
    {
        Console.WriteLine("Digite as notas G2 do aluno " + (i+1) + ": ");
        valorDig = Console.ReadLine();
        double.TryParse(valorDig, out notasG2[i]);
        if (notasG2[i] < 0 || notasG2[i] > 10)
        {
            Console.WriteLine("Nota inválida por favor digite uma nota válida");
        }
    } while (notasG2[i] < 0 || notasG2[i] > 10);

    medias[i] = (notasG1[i] + notasG2[i])/2;
}

Console.WriteLine("============================== Notas/Médias ==============================");

for (int i = 0; i < qtdeAlunos; i++)
{
    Console.WriteLine("Número do Aluno: "+ (i+1) +" Nota G1: "+ notasG1[i] +" Nota G2: "+ notasG2[i] +" Média: "+ medias[i]);
}
