int[] vet1 = new int[5];
int[] vet2 = new int[5];
String? valorDig;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite os valores do vetor 1: ");
    valorDig = Console.ReadLine();
    Int32.TryParse(valorDig, out vet1[i]);
    Console.WriteLine("Digite os valores do vetor 2: ");
    valorDig = Console.ReadLine();
    Int32.TryParse(valorDig, out vet2[i]);
}

Console.WriteLine("================== Operações ==================");

for(int i = 0;i < 5;i++)
{
    Console.WriteLine((i+1) +" Elementos, Soma: "+ (vet1[i] + vet2[i]) +" Diferença"+ (vet1[i] - vet2[i]) +" Produto"+ (vet1[i] * vet2[i]) +" Divisão: "+ (vet1[i] / vet2[i]));
}