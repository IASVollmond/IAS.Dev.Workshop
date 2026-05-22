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
                Console.WriteLine("3. Azubi anmelden");
                Console.WriteLine("4. Azubi abmelden");
                Console.WriteLine("5. Countdown bis IHK Abgabe");
                Console.WriteLine();


                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    AzubisAnzeigen(azubis);
                }

                else if (eingabe == "2")
                {
                    Hinzufügen(azubis);
                }

                else if (eingabe == "3")
                {
                    Console.WriteLine("\nAnmelden");
                }

                else if (eingabe == "4")
                {
                    Console.WriteLine("\nAbmelden");
                }

                else if (eingabe == "5")
                {
                    Console.WriteLine("\nCountdown");
                }

                else
                {
                    Console.WriteLine("\nUngültige Eingabe. Bitte nur Angaben zwischen 1-5 eingeben");
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
        static void Hinzufügen(List<string> meineazubis)
        {
            Console.WriteLine("\nHinzufügen");
            Console.WriteLine("\nBitte geben Sie einen den Namen des Azubis ein, den Sie hinzufügen möchten.");
            string nameneu = Console.ReadLine();
            meineazubis.Add(nameneu);
            Console.WriteLine($"{nameneu} wurde der Liste hinzugefügt");
        }
    }
}
