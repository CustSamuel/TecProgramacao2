Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
//Action é um delegate pré-definido do c# portanto não requer uma declaração. Recebe até 16 parâmetros e nao tem retorno.

//definição do action
Action<int> dobrar = x=> Console.WriteLine(x * 2);
//uso
dobrar(num);