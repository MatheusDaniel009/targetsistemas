using System.Runtime.Intrinsics.X86;

Console.WriteLine("1");
Console.WriteLine("o valor da SOMA vai ser 14");
Console.ReadKey();
Console.Clear();

Console.WriteLine("2");
int N, N1 = 1, N2 = 0, N3 = 0; 

Console.Write("diguite um numero: ");
N = int.Parse(Console.ReadLine());
while(N != N3 && N > N3)
{
    N1 = N1 + N2;
    N3 = N1 + N2;
    N2 = N1 + N2;
}

if (N3 == N)
{
    Console.WriteLine("este numero faz parte da sequencia Fibonacci ");
}
else
{
    Console.WriteLine("este numero não faz parte da sequencia Fibonacci");
}

Console.ReadKey();
Console.Clear();
Console.WriteLine("3");
Console.WriteLine("a) 1, 3, 5, 7, 9");
Console.WriteLine("b) 2, 4, 8, 16, 32, 64, 128");
Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, 49");
Console.WriteLine("d) 4, 16, 36, 64, 100");
Console.WriteLine("e) 1, 1, 2, 3, 5, 8, 13");
Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, 20");

Console.ReadKey();
Console.Clear();
Console.WriteLine("4");
Console.WriteLine("Quando os veículos se cruzarem na rodovia, o carro estará mais próximo de Ribeirão Preto");
Console.WriteLine("O carro percorre a distância de Ribeirão Preto até o ponto de encontro em:");
Console.WriteLine("d = vt");
Console.WriteLine("d = 110(50/110)");
Console.WriteLine("d = 50 km");
Console.WriteLine("Já o caminhão percorre a mesma distância, mas leva mais tempo devido aos pedágios. Supondo que cada pedágio acrescente 5 minutos ao tempo de viagem do caminhão, temos:");
Console.WriteLine("d = vt");
Console.WriteLine("d = 80(50/80 + 25/60 + 25/60)");
Console.WriteLine("d = 45 km");

Console.ReadKey();
Console.Clear();
Console.WriteLine("5");
Console.Write("Digite uma string: ");
string minhaString = Console.ReadLine();
char[] caracteres = minhaString.ToCharArray();
int tamanho = caracteres.Length;
for (int i = 0; i < tamanho / 2; i++)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[tamanho - i - 1];
    caracteres[tamanho - i - 1] = temp;
}
string stringInvertida = new string(caracteres);
Console.WriteLine("A string invertida é: " + stringInvertida);
    

