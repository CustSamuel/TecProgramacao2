class Program
{
public delegate int OperacaoMatematica(int x, int y);

static void Main ()
    {
Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um segundo número inteiro: ");
int num2 = Convert.ToInt32(Console.ReadLine());

OperacaoMatematica soma = (x, y) => x + y;


int result = soma(num, num2);

Console.WriteLine(result);
    }



}

