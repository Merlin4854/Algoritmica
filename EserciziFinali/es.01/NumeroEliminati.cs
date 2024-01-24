using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci i numeri separati da uno spazio:");
        string input = Console.ReadLine();

        // Converti l'input dell'utente in un array di interi
        int[] numeri = input.Split(' ').Select(int.Parse).ToArray();

        int risultato = MinEliminazioniPerUguali(numeri);
        Console.WriteLine($"Numero minimo di eliminazioni: {risultato}");
    }

    static int MinEliminazioniPerUguali(int[] numeri)
    {
        // Utilizza un dizionario per contare quante volte ogni numero compare nell'array
        Dictionary<int, int> conteggioNumeri = new Dictionary<int, int>();

        foreach (int numero in numeri)
        {
            if (conteggioNumeri.ContainsKey(numero))
            {
                conteggioNumeri[numero]++;
            }
            else
            {
                conteggioNumeri[numero] = 1;
            }
        }

        // Trova il numero massimo di occorrenze di un singolo numero
        int massimoOccorrenze = conteggioNumeri.Values.Max();

        // Calcola il numero minimo di eliminazioni necessarie
        int eliminazioniNecessarie = numeri.Length - massimoOccorrenze;

        return eliminazioniNecessarie;
    }
}
