Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
//Predicate é um delegate pré-definido do c# portanto não requer uma declaração. Recebe até 1 parâmetro e retorna um booleano.
//se num é par ou ímpar
//definição do action
Predicate<int> VerificarPredicate = n => n % 2 == 0;

    if (VerificarPredicate(num))
{
    Console.WriteLine($"O número {num} é par");
}
else
{
    Console.WriteLine($"O número {num} é impar");
}

//uso