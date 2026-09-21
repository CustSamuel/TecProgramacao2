using System.Globalization;
using System.Security.Cryptography.X509Certificates;
var participacao1 = new Participacao("João", "Palestra de C#", 8, new DateTime(2024, 6, 1));
var participacao2 = new Participacao("Maria", "Workshop de ASP.NET", 12, new DateTime(2024, 6, 5));
var participacao3 = new Participacao("Pedro", "Curso de Entity Framework", 6, new DateTime(2024, 6, 10));
var participacao4 = new Participacao("Ana", "Seminário de Blazor", 10, new DateTime(2024, 6, 15));
    
var registroAcademico = new RegistroAcademico();
registroAcademico.ParticipacaoRegistrada += new MostrarParticipantes().Mostrar;
registroAcademico.ParticipacaoRegistrada += VerificarCargaHoraria.Verificar;

registroAcademico.RegistrarParticipacao(participacao1);
registroAcademico.RegistrarParticipacao(participacao2);
registroAcademico.RegistrarParticipacao(participacao3);
registroAcademico.RegistrarParticipacao(participacao4);

Console.WriteLine("Todos os participantes:");

Console.ReadKey();

public class Participacao : EventArgs
{
    public Participacao() { } 

    public Participacao(string aluno, string evento, int cargaHoraria, DateTime dataEvento)
    {
        Aluno = aluno;
        Evento = evento;
        CargaHoraria = cargaHoraria;
        DataEvento = dataEvento;
    }

    public string Aluno { get; set; }
    public string Evento { get; set; }
    public int CargaHoraria { get; set; }
    public DateTime DataEvento { get; set; }
   
}

public class RegistroAcademico
{
    public event EventHandler<Participacao>? ParticipacaoRegistrada;
    public void RegistrarParticipacao(Participacao p) 
    {
        TodosParticipantes.Add(p);
        if (ParticipacaoRegistrada != null)
        {
            ParticipacaoRegistrada(this, p);
            //PatrticipacaoRegistrada.Invoke(this, p);
        }
    }
    public void Participantes()
    {
        foreach (var participante in TodosParticipantes)
        {
            Console.WriteLine($"Participação \n Aluno: {participante.Aluno}, \n Evento: {participante.Evento}, \n Carga Horária: {participante.CargaHoraria}, \n Data do Evento: {participante.DataEvento}");
        }
    }
    public List <Participacao> TodosParticipantes { get; set; } = new List<Participacao>();
}

public class MostrarParticipantes
{
    public void Mostrar(Object? sender, Participacao p)
    {
        Console.WriteLine($"Participação \n Aluno: {p.Aluno}, \n Evento: {p.Evento}, \n Carga Horária: {p.CargaHoraria}, \n Data do Evento: {p.DataEvento}");
    }
}

public class VerificarCargaHoraria
{
    public static void Verificar(Object? sender, Participacao p)
    {
        if (p.CargaHoraria > 10)
        {
            Console.WriteLine("Carga horária relevante.");
        }
    }
}