using System;

try
{

    Console.WriteLine("Informe o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = dividendo / divisor;
    Console.WriteLine($"O resultado da divisão foi: {result}");

}

catch (FormatException)
{
    Console.WriteLine("Digite valores inteiros");
}
catch(OverflowException)
{
    Console.WriteLine ("Digite valores entre 1 e 99999");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Divisão por zero inválida");
}
catch(Exception ex)
{
    Console.WriteLine("Problema na divisão" + ex.Message);
}
finally
{
    Console.WriteLine("Finalizado!!!!!!!");
}

A.ProcessaA();

class A
{
    public static void ProcessaA()
    {
        B.ProcessaB();
    }
}

class B
{
    public static void ProcessaB()
    {
        C.ProcessaC();
    }
}

class C
{
    public static void ProcessaC()
    {
        throw new NotImplementedException(
            "Método não foi implementado"
        );
    }
}