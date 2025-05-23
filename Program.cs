﻿using System;


List<Produkt> produkter = new List<Produkt>();

Console.WriteLine("Hvor mange filmer eller bøker vil du legge til?");
int antall = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < antall; i++)
{
    Console.WriteLine($"\nLegg inn informasjon for produkt {i + 1}:");

    Console.Write("Er det en bok eller film? (skriv 'bok' eller 'film'): ");
    string type = Console.ReadLine()?.ToLower() ?? string.Empty;

    Console.Write("Tittel: ");
    string tittel = Console.ReadLine() ?? string.Empty;

    Console.Write("År: ");
    Console.Write("Beskrivelse: ");
    string beskrivelse = Console.ReadLine() ?? string.Empty;

    Console.Write("Forfatter/Regissør: ");
    string skaper = Console.ReadLine() ?? string.Empty;

    Console.Write("Hvem spilte med / hovedperson(er): ");
    string hovedpersoner = Console.ReadLine() ?? string.Empty;

    string år = Console.ReadLine();
    Produkt p = new Produkt(type, tittel, år, beskrivelse, skaper, hovedpersoner);
    produkter.Add(p);
}

Console.WriteLine("\n Her er produktene du skrev inn:\n");

foreach (var p in produkter)
{
    p.VisInfo();
}

class Produkt
{
     string Type;
     string Tittel;
     string År;
     string Beskrivelse;
     string Skaper; 
     string Hovedpersoner;

    public Produkt(string type, string tittel, string år, string beskrivelse, string skaper, string hovedpersoner)
    {
        Type = type;
        Tittel = tittel;
        År = år;
        Beskrivelse = beskrivelse;
        Skaper = skaper;
        Hovedpersoner = hovedpersoner;
    }

    public void VisInfo()
    {
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Tittel: {Tittel}");
        Console.WriteLine($"År: {År}");
        Console.WriteLine($"Beskrivelse: {Beskrivelse}");
        Console.WriteLine($"Skaper: {Skaper}");
        Console.WriteLine($"Hovedpersoner: {Hovedpersoner}");
        Console.WriteLine("----------------------------");
    }
}
