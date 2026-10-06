using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Agenda agendaPessoal = new Agenda();

        agendaPessoal.CadastrarEvento("Aniversário do Polenta", new DateTime(2024, 12, 14));
        agendaPessoal.CadastrarEvento("Reunião de Trabalho", new DateTime(2024, 03, 20));

        agendaPessoal.MostrarAgenda();

        // Adicionando uma pausa para evitar que o console feche imediatamente
        Console.WriteLine("\nPressione qualquer tecla para fechar o programa.");
        Console.ReadKey();
    }
}

class Agenda
{
    private List<Evento> eventos = new List<Evento>();

    public void CadastrarEvento(string nome, DateTime data)
    {
        Evento evento = new Evento(nome, data);
        eventos.Add(evento);
        Console.WriteLine($"Evento agendado para {nome} na data {data.ToShortDateString()}.");
    }

    public void MostrarAgenda()
    {
        Console.WriteLine("\nAgenda:");
        foreach (Evento evento in eventos)
        {
            Console.WriteLine($"{evento.Nome} - {evento.Data.ToShortDateString()}");
        }
        Console.WriteLine("\n");
    }
}

class Evento
{
    public string Nome { get; }
    public DateTime Data { get; }

    public Evento(string nome, DateTime data)
    {
        Nome = nome;
        Data = data;
    }
}
