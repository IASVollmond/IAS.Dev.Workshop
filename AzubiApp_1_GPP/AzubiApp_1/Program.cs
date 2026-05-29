using System.ComponentModel;

namespace azubiapp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> azubis = new List<string>() {"Lion", "Tim", "Giulio Pio", "Zheko"}; 

            Console.WriteLine("*******************");
            Console.WriteLine("~Azubi Hub~");
            Console.WriteLine("*******************");
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Hauptmenü");

                Console.WriteLine("Bitte geben Sie die Nummer des Menüpunkts ein, denn Sie benutzen möchten");
                Console.WriteLine("1. Liste Azubis");
                Console.WriteLine("2. Azubi hinzufügen");
                Console.WriteLine("3. ");
                Console.WriteLine("4. Azubi abmelden");
                Console.WriteLine("5. Countdown bis IHK Abgabe");
                Console.WriteLine();


                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        AzubisAnzeigen(azubis);
                        break;

                    case "2":
                        Hinzufuegen(azubis); 
                        break;

                    case "3":
                        Console.WriteLine("\nAnmelden");
                        break;

                    case "4":
                        Console.WriteLine("\nAbmelden");
                        break;

                    case "5":
                        Console.WriteLine("\nCountdown");
                        CountdownPruefung();
                        break;

                    default:
                        Console.WriteLine("\nUngültige Eingabe. Bitte nur Angaben zwischen 1-5 eingeben");
                        break;
                }
                Console.WriteLine("");
            }
        }
        static void AzubisAnzeigen(List<string> meineazubis)
        {
            Console.WriteLine("\nAzubiliste");
            for (int i = 0; i < meineazubis.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {meineazubis[i]}");
            }
        }
        static void Hinzufuegen(List<string> meineazubis)
        {
            Console.WriteLine("\nHinzufügen");
            Console.WriteLine("\nBitte geben Sie einen den Namen des Azubis ein, den Sie hinzufügen möchten.");
            string nameneu = Console.ReadLine();
            meineazubis.Add(nameneu);
            Console.WriteLine($"{nameneu} wurde der Liste hinzugefügt");
        }
        static void CountdownPruefung()
        {
            DateTime datumPruefung = DateTime.Parse("24.02.2027");
            DateTime aktuellesDatum = DateTime.Now;
            TimeSpan countdown = datumPruefung - aktuellesDatum;
            Console.WriteLine($"Du hast noch {countdown.Days} Tage, {countdown.Hours} Stunden, {countdown.Minutes} Minuten und" +
                $" {countdown.Seconds} Sekunden bis zur Zwischenprüfung am {datumPruefung:dd.MM.yyyy}");










            /*DateTime jetzt = DateTime.Now;

            TimeSpan verbleibend = zieldatum - jetzt;

            if (verbleibend.TotalSeconds <= 0)
            {
                Console.WriteLine("Das Datum liegt in der Vergangenheit!");
                return;
            }
            Console.WriteLine($"Countdown bis {zieldatum:dd.MM.yyyy}");
            Console.WriteLine($"  Tage:    {verbleibend.Days}");
            Console.WriteLine($"  Stunden: {verbleibend.Hours}");
            Console.WriteLine($"  Minuten: {verbleibend.Minutes}");
            Console.WriteLine($"  Sekunden:{verbleibend.Seconds}");*/
        }
    }
}
