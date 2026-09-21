//passo 3 - utilização
// algumas formas de declaração de uso

MeuDelegate del1 = new MeuDelegate(MeuMetodo);
MeuDelegate del2 = MeuMetodo;
MeuDelegate del3 = (msg)=> Console.WriteLine(msg);


//Uso efetivo 
del1.Invoke("Mensagem 1");
del2("Mensagem 2");
del3("Mensagem 3");


Console.ReadKey();

//Passo 2 - Declaração do método
static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}

//Passo 1 - Declaração do Delegate
public delegate void MeuDelegate(string msg);
