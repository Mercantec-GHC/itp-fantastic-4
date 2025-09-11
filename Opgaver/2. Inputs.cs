using System.Globalization;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Insert your text: ");
            // хвост от прошлых вводов (если был, дебаггинг такой немножко)
            string inserturtext = Console.ReadLine();
            Console.WriteLine($"omg u just said: {inserturtext} !!!! :D");
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            Console.Write("insert yo number : ");
            int n = int.Parse(Console.ReadLine());   // читаю целое число (если введёшь не число — наёбнётся)
            Console.WriteLine($"Whoah u just typed : {n}");
        }


        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            // Lav opgaven herunder!
            Console.Write("Enter a decimal number: ");
            string s = Console.ReadLine();
            double x = double.Parse(s.Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.WriteLine($"You just typed: {x}");
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            Console.WriteLine("Make a program that reads a boolean and prints it");
            Console.Write("Type true or false: ");
            bool value = bool.Parse(Console.ReadLine()); // ожидается ввод true или false, иначе наёбнётся
            Console.WriteLine($"You typed: {value}");
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("=====MEME PROFILE GENERATOR!!YOOOO====");
            Console.Write("enter ur nickname or name dummy!");
            string name = Console.ReadLine();

            Console.Write("enter ur age! (if u lie i will find u)");
            int age = int.Parse(Console.ReadLine());

            Console.Write("r u a student? (yes/no)");
            bool isStudent = bool.Parse(Console.ReadLine().ToLower() == "yes" ? "true" : "false");

            Console.Write("fav emoji bro");
            string emoji = Console.ReadLine();

            Console.WriteLine("cringe level from 1 to 100");

            Console.WriteLine("1 being not cringe at all, 100 being so cringe u make me want to kms");
            int cringeLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("=====YOUR CRINGE PROFILE=====");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Student: {isStudent}");
            Console.WriteLine($"Favorite Emoji: {emoji}");
            Console.WriteLine($"Cringe Level: {cringeLevel}/100");
            Console.WriteLine("=====THANKS FOR USING MY CRINGE PROFILE GENERATOR!!=====");


        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde)).");
            // Lav opgaven herunder!
            Console.Write("Enter weight in kg: ");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter height in meters with dot cuz comma aint working and u get ur shit buggy : ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bmi = weight / (height * height);

            // вывод с 1 знаком после запятой
            Console.WriteLine($"Your BMI: {bmi:F1}");


            string cat =
                bmi < 18.5 ? "Underweight" :
                bmi < 25.0 ? "Normal weight" :
                bmi < 30.0 ? "Overweight" :
                             "Obesity";
            Console.WriteLine($"Category: {cat}");
        }
    }
}
