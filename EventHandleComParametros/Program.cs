using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Usando evento OnCriarPedido");
var pedido = new Pedido();

//Passo 4 - Inscrever os assinantes
pedido.OnCriarPedido += Email.DispararEmail;
pedido.OnCriarPedido += SMS.DispararSMS;
pedido.CriarPedido();



Console.ReadKey();

//Classe declaração dos parametros
public class PedidoEventArgs : EventArgs
{
    public string Email { get; set; }
    public string Celular { get; set; }
}
//CLASSE PUBLICADORA DO EVENTO

public class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;
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
    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs {
                Email = "cliente@example.com",
                Celular = "123456789"
            });
        }
    }

    public int Codigo { get; set; }
    public DateTime DataVenda { get; set; }
    public double Valor { get; set; }
}

//Classes assinantes
public class Email
{
    public static void DispararEmail(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Email enviado para {e.Email}!");
    }
}

public class SMS
{
    public static void DispararSMS(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"SMS enviado para {e.Celular}!");
    }
}

public delegate void PedidoEvento();