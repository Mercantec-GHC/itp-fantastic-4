using System;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
            Loop6();
            Loop7();
            Loop8();
            Loop9();
            Loop10();
            BankeBøf();
            MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Summen af tallene fra 1 til 100 er: {sum}");
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn:");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast et tal:");
            int tal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine(navn);
            }
        }

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            int tal = Convert.ToInt32(Console.ReadLine());
            for (int i = tal; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            string navn = "DitNavn"; // Erstat "DitNavn" med dit faktiske navn
            foreach (char c in navn)
            {
                Console.WriteLine(c);
            }
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast en tekst:");
            string tekst = Console.ReadLine();
            int count = 0;
            foreach (char c in tekst)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine($"Bogstavet 'a' optræder {count} gange i teksten.");
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            for (int i = 1; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indtast et tal:");
                int tal = Convert.ToInt32(Console.ReadLine());
                sum += tal;
            }
            Console.WriteLine($"Summen af de indtastede tal er: {sum}");
        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            int hemmeligtTal = 7; // Du kan ændre dette til et andet tal mellem 1 og 10
            int gæt = 0;
            while (gæt != hemmeligtTal)
            {
                Console.WriteLine("Gæt et tal mellem 1 og 10:");
                gæt = Convert.ToInt32(Console.ReadLine());
                if (gæt < hemmeligtTal)
                {
                    Console.WriteLine("For lavt, prøv igen.");
                }
                else if (gæt > hemmeligtTal)
                {
                    Console.WriteLine("For højt, prøv igen.");
                }
                else
                {
                    Console.WriteLine("Tillykke! Du gættede det rigtige tal.");
                }
            }
        }
        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BankeBøf");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Banke");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bøf");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast det første tal:");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast det andet tal:");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vælg en regneart (+, -, * eller /):");
            string regneart = Console.ReadLine();
            double resultat = 0;
            switch (regneart)
            {
                case "+":
                    resultat = tal1 + tal2;
                    break;
                case "-":
                    resultat = tal1 - tal2;
                    break;
                case "*":
                    resultat = tal1 * tal2;
                    break;
                case "/":
                    if (tal2 != 0)
                    {
                        resultat = tal1 / tal2;
                    }
                    break;
            }
            Console.WriteLine($"Resultatet er: {resultat}");
        }
    }
}