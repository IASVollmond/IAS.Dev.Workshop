using System.ComponentModel;

namespace kundenverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kunden = new List<string>() { "Herr Urhan", "Herr Klostermann", "Frau Wiegert", "Frau Wecht" };

            Console.WriteLine("*******************");
            Console.WriteLine("~Kundenverwaltung~");
            Console.WriteLine("*******************");
            Console.WriteLine("");

            bool hilfesvar = true;
            while (hilfesvar)
            {
                Console.WriteLine("Hauptmenü");

                Console.WriteLine("Bitte geben Sie die Nummer des Menüpunkts ein, denn Sie benutzen möchten");
                Console.WriteLine("1. Liste Kunden");
                Console.WriteLine("2. Kunden hinzufügen");
                Console.WriteLine("3. Kunden löschen");
                Console.WriteLine("4. Programm beenden");
                Console.WriteLine();


                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        KundenAnzeigen(kunden);
                        break;

                    case "2":
                        Hinzufuegen(kunden);
                        break;

                    case "3":
                        Loeschen(kunden);
                        break;

                    case "4":
                        Console.WriteLine("\nDas Programm wird beendet");
                        hilfesvar = false;
                        break;

                    default:
                        Console.WriteLine("\nUngültige Eingabe. Bitte nur Angaben zwischen 1-4 eingeben");
                        break;
                }
                Console.WriteLine("");
            }
        }
        static void KundenAnzeigen(List<string> meinekunden)
        {
            Console.WriteLine("\nKundenliste");
            for (int i = 0; i < meinekunden.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {meinekunden[i]}");
            }
        }
        static void Hinzufuegen(List<string> meinekunden)
        {
            Console.WriteLine("\nHinzufügen");
            Console.WriteLine("\nBitte geben Sie einen den Namen des Kunden ein, den Sie hinzufügen möchten.");
            string nameneu = Console.ReadLine();
            meinekunden.Add(nameneu);
            Console.WriteLine($"{nameneu} wurde der Liste hinzugefügt");
        }
        static void Loeschen(List<string> meinekunden)
        {
            Console.WriteLine("Geben Sie den Namen des Kunden an, der aus der Liste entfernt werden soll");
            string entfernen = Console.ReadLine();
            if (meinekunden.Contains(entfernen))
            {
                meinekunden.Remove(entfernen);
                Console.WriteLine($"{entfernen} wurde aus der Liste entfernt");
            }

            else
            {
                Console.WriteLine($"Der Kunde ist nicht in der Liste vohanden");
            }
        }
    }
}
