namespace Opgaver
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Arrays, List og Dictionary!");

            // Opgaverne herunder går igennem ting vi skal kunne med arrays, list og dictionary
            // Da I ikke har lært omkring loops og metoder endnu, er det ikke nødvendigt at bruge dem her
            // I må dog gerne bruge loops og metoder i opgaverne herunder

            //Array1();
            Array2();
          Array3();
          //List1();
            List2();
            List3();
            List4();
            List5();
            Dict1();
            Dict2();
            MiniProjektKlasseliste();
            MiniProjektIndkøbsliste();
        }

        public static void Array1()
        {
            Console.WriteLine("Opgave 1 (Array):");
            Console.WriteLine(
                "Lav et program som gemmer 5 fornavne som brugeren indtaster i et array."
            );
            // Lav opgaven herunder!
            string[] navne = new string[5];
            for (int i = 0; i < navne.Length; i++)
            {
                Console.Write($"Insert nickname or surname {i + 1}: ");
                navne[i] = Console.ReadLine() ?? "";
            }
        }

        public static void Array2()
        {
            Console.WriteLine("Opgave 2 (Array):");
            Console.WriteLine(
                "Lav et program som gemmer 5 tal i et array og udskriver det største tal."
            );
            // Lav opgaven herunder!
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Indtast tal #{i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        break; // выходим из while, если ввод корректный
                    }
                    Console.WriteLine("Forkert input! Prøv igen.");
                }
            }

        
        }

        public static void Array3()
        {
            Console.WriteLine("Opgave 3 (Array):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 bynavne i et array 
                og udskriver dem alle i omvendt rækkefølge."
            );
            // Lav opgaven herunder!
            string[] cityname = new string[5];
            for (int i = 0; i < cityname.Length; i++)
            {
                Console.Write($"Insert city name (please) {i + 1}: ");
                cityname[i] = Console.ReadLine() ?? "";
            }
        }

        public static void List1()
        {
            Console.WriteLine("Opgave 1 (List):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 fornavne 
                som brugeren indtaster i en liste."
            );
            // Lav opgaven herunder!
            List<string> name = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Insert nickname or surname {i + 1}: ");
                name.Add(Console.ReadLine() ?? "");
            }
        }

        public static void List2()
        {
            Console.WriteLine("Opgave 2 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren kan blive ved med at indtaste 
                navne indtil de skriver 'stop'. Udskriv alle navnene til sidst."
            );
            // Lav opgaven herunder!
            List<string> names = new List<string>();
            string input;

            Console.WriteLine("\nType names (write 'stop' when you're done):");

            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                names.Add(input);
                Console.WriteLine($"{input} got recruited to the cringe army");
            }

            Console.WriteLine("\nFinal squad roster:");
            Random rng = new Random();
            string[] comments =
            {
        "defo a simp",
        "main character ahh vibes",
        "think theyre special",
        "walking red flag",
        "side quest merchant",
        "built like patch notes"
    };

            foreach (string name in names)
            {
                string comment = comments[rng.Next(comments.Length)];
                Console.WriteLine($"- {name} ({comment})");
            }

            Console.WriteLine("\nProgram says: this list looks like a Discord mod meeting.");
        }

        

        public static void List3()
        {
            Console.WriteLine("Opgave 3 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster 5 tal i en liste 
                og programmet udskriver gennemsnittet."
            );
            // Lav opgaven herunder!
            List<int> numbers = new List<int>();

            Console.WriteLine("\nDrop 5 numbers (we finna cook them into an average):");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Number {i}: ");
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);

                // roast every input
                if (n == 0)
                    Console.WriteLine("bro typed 0... peak laziness");
                else if (n < 0)
                    Console.WriteLine("negative? bro is literally in debt");
                else if (n > 100)
                    Console.WriteLine("ok flexer, chill with the big numbers");
                else
                    Console.WriteLine($"{n}? mid, but we’ll allow it");
            }

            double avg = numbers.Average();

            Console.WriteLine("\nFinal result:");
            Console.WriteLine($"The average of your goofy numbers is {avg}");

            if (avg < 10)
                Console.WriteLine("lowkey that’s a weak average, do better");
            else if (avg > 50)
                Console.WriteLine("this average is built like a final boss");
            else
                Console.WriteLine("your average is… aggressively mid");
        }

        public static void List4()
        {
            Console.WriteLine("Opgave 4 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster navne på ting de skal købe, 
                og kan fjerne ting fra listen igen. Udskriv listen til sidst."
            );
            // Lav opgaven herunder!
        }

        public static void List5()
        {
            Console.WriteLine("Opgave 5 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster navne på sine venner 
                i en liste og programmet udskriver hvor mange navne der starter med 'A'."
            );
            // Lav opgaven herunder!
        }

        public static void Dict1()
        {
            Console.WriteLine("Opgave 1 (Dictionary):");
            Console.WriteLine(
                @"Lav et program hvor du gemmer navne og alder på 3 personer 
                i en dictionary og udskriver dem alle."
            );
            // Lav opgaven herunder!
            // Husk syntaxen for Dictionary<type, type> navn = new Dictionary<type, type>();
        }

        public static void Dict2()
        {
            Console.WriteLine("Opgave 2 (Dictionary):");
            Console.WriteLine(
                @"Lav et program hvor brugeren kan indtaste et navn 
                og få alderen på personen ud fra dictionaryen fra før."
            );
            // Lav opgaven herunder!
            var people = new Dictionary<string, int>()
    {
        {"Anna", 20},
        {"Peter", 25},
        {"Maria", 30},
        {"Lukas", 18}
    };

            Console.Write("Indtast et navn: ");
            string name = Console.ReadLine();

            if (people.ContainsKey(name))
            {
                Console.WriteLine($"{name} er {people[name]} år gammel.");
            }
            else
            {
                Console.WriteLine($"Navnet '{name}' findes ikke i dictionaryen.");
            }
        }

        public static void MiniProjektKlasseliste()
        {
            Console.WriteLine("\nMini-projekt: Klasseliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster navnene på alle elever i en klasse (fx 5 navne)."
            );
            Console.WriteLine(
                @"Gem navnene i en liste og udskriv hele klasselisten 
                  i konsollen."
            );
            // Lav opgaven herunder!
        }

        public static void MiniProjektIndkøbsliste()
        {
            Console.WriteLine("\nMini-projekt: Indkøbsliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                @"Lav et program, hvor brugeren indtaster navnet på tre ting og deres pris, 
                de skal købe i supermarkedet."
            );
            Console.WriteLine(
                @"Gem tingene i et key-value par med navn og pris, 
                og udskriv en indkøbsliste med total pris til brugeren."
            );
            // Lav opgaven herunder!
        }
    }
}
