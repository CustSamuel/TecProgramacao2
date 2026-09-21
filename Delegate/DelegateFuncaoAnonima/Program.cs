Console.WriteLine("Digite um número inteiro");
int num = Convert.ToInt32(Console.ReadLine());

//função anonima
Imprimir mostra = delegate (int valor)
{
    Console.WriteLine(valor);
};

//chamada da função por meio do delegate
mostra(num);

Console.ReadKey();
public delegate void Imprimir(int valor);
