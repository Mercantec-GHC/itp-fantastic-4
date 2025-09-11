namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            //If1();
            //If2();

            //Switch1();
            //Ternary1();

            //MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            Console.Write("Indtast en alder: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age > 18 ? "Højere end 18" : (age < 18 ? "Lavere end 18" : "Præcis 18"));

        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.Write("Indtast et tal: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Lige" : "Ulige");
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.Write("Indtast en karakter (12, 10, 7, 4, 02, 00 eller -3): ");
            int grade = int.Parse(Console.ReadLine());
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.Write("Indtast et tal: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Lige" : "Ulige");
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            int score = 0;

            Console.WriteLine("Spørgsmål 1: Hvad er hovedstaden i Danmark?");
            string a1 = Console.ReadLine()?.Trim() ?? "";
            if (string.Equals(a1, "København", StringComparison.OrdinalIgnoreCase)) score++;

            Console.WriteLine("Spørgsmål 2: Hvor mange dage er der i en uge?");
            string a2 = Console.ReadLine()?.Trim() ?? "";
            if (a2 == "7") score++;

            Console.WriteLine("Spørgsmål 3: Hvilket år startede 2. verdenskrig? (1938, 1939, 1940)");
            string a3 = Console.ReadLine()?.Trim() ?? "";
            if (a3 == "1939") score++;

            Console.WriteLine($"\nDu fik {score} rigtige ud af 3!");

        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            // Lav opgaven herunder!
            Console.Write("Indtast en karakter: ");
            int karakter = int.Parse(Console.ReadLine());

            switch (karakter)
            {
                case 12: Console.WriteLine("Super flot!"); break;
                case 10: Console.WriteLine("Godt klaret!"); break;
                case 7: Console.WriteLine("Fint arbejde."); break;
                case 4: Console.WriteLine("Det er okay, men du kan gøre det bedre."); break;
                case 02: Console.WriteLine("Du bestod, men skal arbejde mere."); break;
                case 00: Console.WriteLine("Ikke bestået."); break;
                case -3: Console.WriteLine("Uacceptabelt. Du må prøve igen."); break;
                default: Console.WriteLine("Ukendt karakter."); break;
            }

            // Ekstra opgave: gennemsnit
            Console.WriteLine("\nIndtast flere karakterer adskilt med mellemrum:");
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0, count = 0;

            foreach (string s in input)
            {
                if (int.TryParse(s, out int k))
                {
                    sum += k;
                    count++;
                }
            }

            if (count > 0)
            {
                double gennemsnit = (double)sum / count;
                Console.WriteLine($"Gennemsnittet af dine karakterer er: {gennemsnit:F2}");
            }

        }
    }
}
