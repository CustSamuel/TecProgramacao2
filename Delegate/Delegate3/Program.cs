List<string> nomes = new List<string>();

nomes.Add("Maria");
nomes.Add("Joaqui");
nomes.Add("João");
nomes.Add("Paulo");
nomes.Add("Carla");

//Nas expressões lambda nao é necessário a declaração do delegate, pois está embutido nela.

var resultado = nomes.Find(nome => nome.Equals("Paulo"));
Console.WriteLine(resultado);


Console.ReadKey();

