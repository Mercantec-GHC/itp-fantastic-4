using System;
using System.Collections.Specialized;

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
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            string input = Console.ReadLine();

            int number = int.Parse(input);
            if (number < 18)
            {
                Console.WriteLine("Tallet er mindre end 18");
            }
            else if (number > 18)
            {
                Console.WriteLine("Tallet er større end 18");
            }
            else
            {
                Console.WriteLine("Tallet er 18");
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("Lige");
                    break;
                case 1:
                    Console.WriteLine("Ulige");
                    break;
                default:
                    Console.WriteLine("Det gik noget galt!!");
                    break;
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            string result = (number % 2 == 0) ? "Lige" : "Ulige";
            Console.WriteLine(result);
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
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine("Programmet skal herefter give feedback baseret på karakteren.");
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
            Console.WriteLine("Indtast karakter (12, 10, 7, 4, 02, 00 eller -3):");
            string input = Console.ReadLine() ?? "0";
            int karakter = int.Parse(input);
            string feedback;
            switch (karakter)
            {
                case 12:
                    feedback = "Super flot!";
                    break;
                case 10:
                    feedback = "Godt klaret";
                    break;
                case 7:
                    feedback = "Du kan gøre det bedre";
                    break;
                case 4:
                    feedback = "Du skal øve dig mere";
                    break;
                case 2:
                    feedback = "Du skal virkelig øve dig mere";
                    break;
                case 0:
                    feedback = "Du dumpede desværre";
                    break;
                case -3:
                    feedback = "Du dumper helt sikkert";
                    break;
                default:
                    feedback = "Ugyldig karakter";
                    break;
                    
            }
            Console.WriteLine($"Feedback: {feedback}");
        }
    }
}
