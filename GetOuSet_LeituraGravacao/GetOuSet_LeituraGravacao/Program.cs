


var produto = new Produto("VERA", 10.50, 1000);
var produto1 = new Produto("VILMA", 15.00, 2000);
Console.WriteLine($"Nome: {produto.Nome} - Preco: {produto.Preco}");
Console.WriteLine($"Desconto: {produto.Desconto} - Preco: {produto.PrecoTotal}");
produto.exibirEstoque();

class Produto
{
    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public void exibirEstoque()
    {
        Console.WriteLine($"Estoque: {_estoque}");
    }

    private string _nome;

    public string Nome
    {
        get
        {
            return _nome.ToLower();
        }

        set { _nome=value; }
    }

    private double _preco;
    public double Preco {
        get 
        {
            return _preco;
        }
        set 
        {
            if(_preco < 5)
            {
                _preco = 5;
            }
            else
            {
                _preco = value;
            }
        } 
    }

    //Atributo de leitura
    private double _desconto = 0.05;
    public double Desconto {
    get { return _desconto; }
    }

    //Atributo de gravação
    private int _estoque;
    public int Estoque 
    {
        set { _estoque = value; }
    }

    //Como não modifica o atributo, ñ é necessário declarar o private
    public double PrecoTotal
    {
        get
        {
            return Preco - (Preco * Desconto);
        }
    }
    
}