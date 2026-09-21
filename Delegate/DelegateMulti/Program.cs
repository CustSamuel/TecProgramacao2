//associando os métodos ao delegate
DelegateCalculadora calc = Calculadora.Somar;
calc += Calculadora.Multiplicar;

//executando soma e multiplicação
calc(20, 30);

//retirando a associação com o método multiplicar
calc -= Calculadora.Multiplicar;

//Agr q tiramos a multiplicação, só irá somar 
calc(20, 30);

Console.ReadKey();

public class Calculadora
{
    public static void Somar(float x, float y)
    {
        Console.WriteLine($"Soma = {x + y}");
    }

    public static void Multiplicar(float x, float y)
    {
        Console.WriteLine($"Multiplicação = {x * y}");
    }
}//fim da classe

//declaração delegate
public delegate void DelegateCalculadora(float x, float y);