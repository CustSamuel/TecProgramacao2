Console.WriteLine("Usando evento OnCriarPedido");
var pedido = new Pedido();

//Passo 4 - Inscrever os assinantes
pedido.OnCriarPedido += Email.DispararEmail;
pedido.OnCriarPedido += SMS.DispararSMS;
pedido.CriarPedido();



Console.ReadKey();
//CLASSE PUBLICADORA DO EVENTO

public class Pedido
{
    public event PedidoEvento? OnCriarPedido;
    public Pedido(int codigo, DateTime data, double valor)
    {
        Codigo = codigo;
        DataVenda = data;
        Valor = valor;
    }

    public Pedido()
    {
    }

    //Passo 3: Disparar o evento
    public  void CriarPedido()
    {
        Console.WriteLine("Pedido criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }

    public int Codigo { get; set; }
    public DateTime DataVenda { get; set; }
    public double Valor {  get; set; }
}

//Classes assinantes
    public class Email()
{
    public static void DispararEmail()
    {
        Console.WriteLine("Email enviado!");
    }
}

public class SMS()
{
    public static void DispararSMS()
    {
        Console.WriteLine("SMS enviado!");
    }
}

public delegate void PedidoEvento();