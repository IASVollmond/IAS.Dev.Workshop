using System.ComponentModel;

namespace kundenverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kunden = new List<string>() { "Kaya Urhan", "Rene Klostermann", "Dagmar Wiegert", "Frank Bormann" };
            List<string> aenderungen = new List<string>(File.ReadAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Änderungsliste.txt"));
            File.WriteAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Kundenliste.txt", kunden);
            File.WriteAllText(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Änderungsliste.txt", "");

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
                        Hinzufuegen(kunden, aenderungen);  
                        File.WriteAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Kundenliste.txt", kunden);
                        File.WriteAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Änderungsliste.txt", aenderungen);
                        break;

                    case "3":
                        Loeschen(kunden, aenderungen); 
                        File.WriteAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Kundenliste.txt", kunden);
                        File.WriteAllLines(@"C:\Projekte\IAS.Dev.Workshop\Kundenverwaltung\Änderungsliste.txt", aenderungen);  
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

        static void Hinzufuegen(List<string> meinekunden, List<string> aenderungen)
        {
            Console.WriteLine("\nHinzufügen");
            Console.WriteLine("\nBitte geben Sie einen den Namen des Kunden ein, den Sie hinzufügen möchten.");
            string nameneu = Console.ReadLine();
            meinekunden.Add(nameneu);

            string eintrag = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] HINZUGEFÜGT: {nameneu}";
            aenderungen.Add(eintrag);

            Console.WriteLine($"{nameneu} wurde der Liste hinzugefügt");
        }

        static void Loeschen(List<string> meinekunden, List<string> aenderungen)
        {
            List<string> vornamen = new();
            List<string> nachnamen = new();

            foreach (string kunde in meinekunden)
            {
                string[] teile = kunde.Split(' ');
                if (teile.Length >= 2)
                {
                    vornamen.Add(teile[0]);
                    nachnamen.Add(teile[1]);
                }
            }

            Console.WriteLine("Geben Sie den Namen des Kunden an, der aus der Liste entfernt werden soll");
            string entfernen = Console.ReadLine();
            bool gefunden = false;

            for (int i = 0; i < meinekunden.Count; i++)
            {
                if (vornamen[i].Equals(entfernen, StringComparison.OrdinalIgnoreCase) ||
                    nachnamen[i].Equals(entfernen, StringComparison.OrdinalIgnoreCase))
                {
                    string entfernterKunde = meinekunden[i];
                    meinekunden.RemoveAt(i);
                    string eintrag = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] GELÖSCHT: {entfernterKunde}";
                    aenderungen.Add(eintrag);

                    Console.WriteLine($"{entfernterKunde} wurde aus der Liste entfernt.");
                    gefunden = true;
                    break;
                }
            }

            if (!gefunden)
            {
                Console.WriteLine("Der Kunde ist nicht in der Liste vorhanden.");
            }
        }
    }
}