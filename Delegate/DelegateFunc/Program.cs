Console.WriteLine("Digite um número inteiro: ");
var num = Convert.ToDouble(Console.ReadLine());
//Func é um delegate pré-definido do c# portanto não requer uma declaração. Recebe até 16 parâmetros e retorna um valor de qualquer tipo.

//Definição na lista o último argumento é o retorno
Func<double, double> RaizQuadrada = Math.Sqrt;

var result  = RaizQuadrada(num);

Console.WriteLine(result);