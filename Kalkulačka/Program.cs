using System;

internal class Program
{
    static void Main()
    {
        Kalkulacka kalkulacka = new Kalkulacka(); 
        double prvniCislo = 0;

        // Načtení prvního čísla z konzole
        Console.WriteLine("Zadej první číslo:");
        prvniCislo = NactiDesetinneCisloZKonzole();

        kalkulacka.Pricti(prvniCislo);

        // Načtení operátoru z konzole
        Console.WriteLine("Zadej operátor (+, -, *, /, ^):");
        string operatorZnak = NactiOperatorZKonzole();

        if (!kalkulacka.JePlatnyOperator(operatorZnak[0]))
        {
            Console.WriteLine($"Zadaný operátor '{operatorZnak}' není platný.");
            return;
        }

        double druheCislo = 0;
        while (true)
        {
            // Načtení druhého čísla z konzole
            Console.WriteLine("Zadej druhé číslo:");
            druheCislo = NactiDesetinneCisloZKonzole();

            // Provádění operace v kalkulačce
            switch (operatorZnak)
            {
                case "+":
                    kalkulacka.Pricti(druheCislo);
                    break;
                case "-":
                    kalkulacka.Odecti(druheCislo);
                    break;
                case "*":
                    kalkulacka.Vynasob(druheCislo);
                    break;
                case "^":
                    kalkulacka.Mocni(druheCislo);
                    break;
                case "/":
                    kalkulacka.Vydel(druheCislo);
                    break;
            }

            double vysledek = kalkulacka.VratAktualniVysledek();

            // Vypsání výsledku
            Console.WriteLine($"Výsledek: {vysledek}");

            prvniCislo = vysledek;

            // Načtení dalšího operátoru z konzole
            Console.WriteLine("Zadej další operátor (+, -, *, /, ^):");
            operatorZnak = NactiOperatorZKonzole();
        }
    }

    // Metoda pro načtení desetinného čísla z konzole
public static double NactiDesetinneCisloZKonzole()
{
    double cislo;
    string vstup = Console.ReadLine(); // Přečte vstup z konzole

    // Kontrola, zda uživatel zadal "X" pro ukončení programu
    if (vstup == "X")
    {
        Environment.Exit(0); // Ukončí aplikaci s kódem 0
    }

    while (!double.TryParse(vstup, out cislo))
    {
        Console.WriteLine("Neplatný vstup. Zadej prosím platné číslo:");
        vstup = Console.ReadLine(); // Přečte další vstup z konzole

        // Kontrola, zda uživatel zadal "X" pro ukončení programu
        if (vstup == "X")
        {
            Environment.Exit(0); // Ukončí aplikaci 
        }
    }

    return cislo;
}

    // Metoda pro načtení operátoru z konzole
    public static string NactiOperatorZKonzole()
    {
        string operatorZnak;
        while (true)
        {
            operatorZnak = Console.ReadLine();
            if (operatorZnak == "+" || operatorZnak == "-" || operatorZnak == "*" || operatorZnak == "/" || operatorZnak == "^")
            {
                return operatorZnak;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadej prosím platný operátor (+, -, *, /, ^):");
            }
        }
    }
}
