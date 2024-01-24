using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci le altezze delle candele separandole con uno spazio:");
        string input = Console.ReadLine();
        
        // Converti l'input dell'utente in un array di interi
        int[] altezzeCandele = input.Split(' ').Select(int.Parse).ToArray();

        int risultato = ContaCandelePiuAlte(altezzeCandele);
        Console.WriteLine($"Candele più alte: {risultato}");
    }

    static int ContaCandelePiuAlte(int[] altezzeCandele)
    {
        // Trova l'altezza massima tra le candele
        int altezzaMassima = altezzeCandele.Max();

        // Conta quante candele hanno l'altezza massima
        int conteggioCandelePiuAlte = altezzeCandele.Count(h => h == altezzaMassima);

        return conteggioCandelePiuAlte;
    }
}
