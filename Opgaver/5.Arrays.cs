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

            Array1();
            Array2();
            Array3();
            List1();
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
        }

        public static void Array2()
        {
            Console.WriteLine("Opgave 2 (Array):");
            Console.WriteLine(
                "Lav et program som gemmer 5 tal i et array og udskriver det største tal."
            );
            // Lav opgaven herunder!
        }

        public static void Array3()
        {
            Console.WriteLine("Opgave 3 (Array):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 bynavne i et array 
                og udskriver dem alle i omvendt rækkefølge."
            );
            // Lav opgaven herunder!
        }

        public static void List1()
        {
            Console.WriteLine("Opgave 1 (List):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 fornavne 
                som brugeren indtaster i en liste."
            );
            // Lav opgaven herunder!
            List<string> navne = new List<string>();
        }

        public static void List2()
        {
            Console.WriteLine("Opgave 2 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren kan blive ved med at indtaste 
                navne indtil de skriver 'stop'. Udskriv alle navnene til sidst."
            );
            // Lav opgaven herunder!
        }

        public static void List3()
        {
            Console.WriteLine("Opgave 3 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster 5 tal i en liste 
                og programmet udskriver gennemsnittet."
            );
            // Lav opgaven herunder!
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
