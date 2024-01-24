using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci le posizioni dei due gatti e del topo separati da uno spazio:");
        string input = Console.ReadLine();
        
        // Converti l'input dell'utente in un array di interi
        int[] posizioni = Array.ConvertAll(input.Split(' '), int.Parse);

        int posizioneGattoA = posizioni[0];
        int posizioneGattoB = posizioni[1];
        int posizioneTopo = posizioni[2];

        string risultato = TrovaGattoVincente(posizioneGattoA, posizioneGattoB, posizioneTopo);
        Console.WriteLine(risultato);
    }

    static string TrovaGattoVincente(int posizioneGattoA, int posizioneGattoB, int posizioneTopo)
    {
        int distanzaGattoA = Math.Abs(posizioneTopo - posizioneGattoA);
        int distanzaGattoB = Math.Abs(posizioneTopo - posizioneGattoB);

        if (distanzaGattoA < distanzaGattoB)
        {
            return "Cat A";
        }
        else if (distanzaGattoB < distanzaGattoA)
        {
            return "Cat B";
        }
        else
        {
            return "Mouse C";
        }
    }
}
