namespace azbiapp2
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("******");
            Console.WriteLine("-Azubi Hub-");
            Console.WriteLine("******");
            Console.WriteLine("Hauptmenü");
            Console.WriteLine("");

            Console.WriteLine("1.Liste Azubist");
            Console.WriteLine("2. Azubi Hinzufügen");
            Console.WriteLine("3. Azubi Anmelden");
            Console.WriteLine("4.Azubi Abmelden");
            Console.WriteLine("5.Countdown bis IHK Abgabe ");
            Console.WriteLine("");

            Console.WriteLine("Bitte wählen sie einen Menüpunkt aus");
            Console.WriteLine("");

            string eingabe = Console.ReadLine();
            if (eingabe == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Liste Azubi");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Azubi Hinzufügen");
            }
            else if (eingabe == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("Azubi Anmelden");
            }
            else if (eingabe == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Azubi Abmelden");
            }
            else if (eingabe == "5")
            {
                Console.WriteLine("");
                Console.WriteLine("Countdown bis IHK abgabe");
            }

            else
                Console.WriteLine("ungültige eingabe, bitte nur zahlen von 1 bis 5");
            
            Console.ReadLine();




        }
    }
}
