

namespace Pizzabaeckerei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzaSalami = new Pizza("Pizza Salami", 40, 12.50, true, "Salami");
            pizzaSalami.Rabatt(25);
            pizzaSalami.Weitwurf();
            Console.Read();
        }

        public class Pizza
        {
            public string Name { get; set; }
            public int Durchmesser { get; set; }
            public double Preis { get; set; }
            public bool Gluten { get; set; }
            public string Belag { get; set; }
            public double Masse { get; set; } = 0.35;

            public Pizza(string name, int durchmesser, double preis, bool gluten, string belag)
            {
                Name = name;
                Durchmesser = durchmesser;
                Preis = preis;
                Gluten = gluten;
                Belag = belag;
            }

            public void Rabatt(int prozent)
            {
                double rabattPreis = Preis * (1 - prozent / 100.0);
                if (rabattPreis < 0)
                    Console.WriteLine("Da haben Sie aber einen komischen Betrag eingegeben");

                else
                    Console.WriteLine($"{Name} mit {prozent}% Rabatt: {rabattPreis:F2} Eugen");
            }

            public void Weitwurf()
            {
                Console.WriteLine("Bitte geben Sie in Newton an, wie fest Sie werfen werden");
                double wurfkraftNewton = double.Parse(Console.ReadLine());
                const double g = 9.81;
                const double winkelGrad = 45;

                double v0 = wurfkraftNewton / Masse * 0.1;

                double luftwiderstandsFaktor = 1 - (Durchmesser / 100.0) * 0.3;
                v0 *= luftwiderstandsFaktor;

                double winkelRad = winkelGrad * Math.PI / 180.0;
                double weite = (v0 * v0 * Math.Sin(2 * winkelRad)) / g;

                Console.WriteLine($"{Name} fliegt los!");
                Console.WriteLine($"Geschwindigkeit: {v0:F2} m/s");
                Console.WriteLine($"Weite: {weite:F2} m");
            }
        }
    }
}
