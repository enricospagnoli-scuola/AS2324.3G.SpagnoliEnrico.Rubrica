using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enrico Spagnoli, 3G, Rubrica");
        int scelta = 0, pos = 0, cont = 0;
        int[] simpatie = new int[100];
        int[] anniNascita = new int[100];
        string[] nomi = new string[100];
        string[] cognomi = new string[100];
        string[] nicknames = new string[100];
        string[] emails = new string[100];
        do
        {
            Console.WriteLine("Inserire una scelta tra le seguenti:");
            Console.WriteLine("1) Inserimento completo di un nominativo");
            Console.WriteLine("2) Elenco dei nominativi inseriti");
            Console.WriteLine("3) Ricerca di un nominativo in base al nickname");
            Console.WriteLine("9) Esci");
            Console.Write("Scelta: ");
            scelta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (scelta)
            {
                case 1:
                    cont++;
                    Console.Write("Inserire il nome: ");
                    nomi[pos] = Console.ReadLine();
                    Console.Write("Inserire il cognome: ");
                    cognomi[pos] = Console.ReadLine();
                    Console.Write("Inserire il nickname: ");
                    nicknames[pos] = Console.ReadLine();
                    Console.Write("Inserire l'email: ");
                    emails[pos] = Console.ReadLine();
                    Console.Write("Inserire l'anno di nascita: ");
                    anniNascita[pos] = Convert.ToInt32(Console.ReadLine());
                    while (anniNascita[pos] < 1899 || anniNascita[pos] > 2024)
                    {
                        Console.Write("Inserire un anno valido (1900-2024): ");
                        anniNascita[pos] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("Inserire il grado di simpatia (1-5): ");
                    simpatie[pos] = Convert.ToInt32(Console.ReadLine());
                    while (simpatie[pos] < 1 || simpatie[pos] > 5)
                    {
                        Console.Write("Inserire un valore da 1 a 5: ");
                        simpatie[pos] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    pos = 0;
                    Console.WriteLine("Elenco nominativi:");
                    do
                    {
                        Console.WriteLine($"Persona numero {pos + 1}:");
                        Console.WriteLine($"Nome: {nomi[pos]}");
                        Console.WriteLine($"Cognome: {cognomi[pos]}");
                        Console.WriteLine($"Nickname: {nicknames[pos]}");
                        Console.WriteLine($"Email: {emails[pos]}");
                        Console.WriteLine($"Anno di nascita: {anniNascita[pos]}");
                        Console.WriteLine($"Simpatia: {simpatie[pos]}");
                        Console.WriteLine("");
                        pos++;
                    } while (pos < cont);
                    break;
                case 3:
                    Console.Write("Inserire il nickname che si desidera cercare: ");
                    string ricerca = Console.ReadLine();
                    bool verifica = false;
                    for (int y = 0; y < cont; y++)
                    {
                        if (ricerca == nicknames[y])
                        {
                            verifica = true;
                            Console.WriteLine($"Persona/e trovata/e:");
                            Console.WriteLine($"Nome: {nomi[y]}");
                            Console.WriteLine($"Cognome: {cognomi[y]}");
                            Console.WriteLine($"Nickname: {nicknames[y]}");
                            Console.WriteLine($"Email: {emails[y]}");
                            Console.WriteLine($"Anno di nascita: {anniNascita[y]}");
                            Console.WriteLine($"Simpatia: {simpatie[y]}");
                            Console.WriteLine("");
                        }
                    }
                    if (verifica == false)
                    {
                        Console.WriteLine("Non sono state trovate persone.");
                    }
                    Console.WriteLine("");
                    break;
                case 9:
                    Console.WriteLine("Programma terminato.");
                    break;
                default:
                    Console.WriteLine("Inserisci una scelta valida.");
                    break;
            }
            pos++;
        } while (scelta != 9);
    }
}