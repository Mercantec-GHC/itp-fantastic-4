using System.Net.WebSockets;

namespace Opgaver
{
    public class Variabler
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Variabler!");

            Int1();
            Double1();
            Strings1();
            Bool1();
            StringInterpolation();
            StringInterpolation2();
            Float1();
            Char1();
            Decimal1();
        }

        public static void Int1()
        {
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Lav en variabel af typen int og tildel den en værdi af ti!");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder! 
            int MyNumber = 10;
            Console.WriteLine(MyNumber);

        }

        public static void Double1()
        {
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("Lav en variabel af typen double og tildel den en værdi komma (decimal) værdi af 5 og en 1/4");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            double MyDouble = 5.25;
            Console.WriteLine(MyDouble);
        }

        public static void Strings1()
        {
            Console.WriteLine("Opgave 3: ");
            Console.WriteLine("Lav en variabel af typen string og tildel den en værdi - den skal indeholde teksten 'Hello, World' med et udråbstegn til sidst!");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            string MyString = "Hello, World!";
            Console.WriteLine(MyString);
        }

        public static void Bool1()
        {
            Console.WriteLine("Opgave 4: ");
            Console.WriteLine("Lav en variabel af typen bool og tildel den en sandhedsværdi (true/false).");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
            bool isReady = true;
            Console.WriteLine(isReady);
        }


        public static void StringInterpolation()
        {
            Console.WriteLine("Opgave 5: ");
            Console.WriteLine("Lav to string variabeler og udskriv dem ved brug af string interpolation.");
            Console.WriteLine("De skal være 'Hello, ' og 'World!'");
            // Lav opgaven herunder!
            string part1 = "Hello, ";
            string part2 = "World!";
            Console.WriteLine($"{part1}{part2}");
        }

        public static void StringInterpolation2()
        {
            Console.WriteLine("Opgave 5: ");
            Console.WriteLine("Her er fire forskellige strenge. Din opgave er at kombinere dem til én sætning ved brug af string interpolation!");
            Console.WriteLine("Strengene er: ");
            string del1 = "Hej";
            string del2 = "med";
            string del3 = "dig";
            string del4 = "!";
            Console.WriteLine($"del1: {del1}");
            Console.WriteLine($"del2: {del2}");
            Console.WriteLine($"del3: {del3}");
            Console.WriteLine($"del4: {del4}");
            Console.WriteLine("Kombiner dem nu til én sætning:");

            // Løsning med string interpolation
            
            Console.WriteLine($"{del1} {del2} {del3}{del4}");
        }

        public static void Float1()
        {
            Console.WriteLine("Opgave 6: ");
            Console.WriteLine("Lav en variabel af typen float og tildel den en værdi af 3 + 0.14");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!

            Console.WriteLine(3 + 0.14f);
        }

        public static void Char1()
        {
            Console.WriteLine("Opgave 7: ");
            Console.WriteLine("Lav en variabel af typen char og tildel den en værdi af det første bogstav i alfabetet (Det skal være stort!)");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
        }

        public static void Decimal1()
        {
            Console.WriteLine("Opgave 8: ");
            Console.WriteLine("Lav en variabel af typen decimal og tildel den en værdi af 100 og en halv");
            Console.WriteLine("Udskriv variablen til konsollen.");
            // Lav opgaven herunder!
        }
    }
}
