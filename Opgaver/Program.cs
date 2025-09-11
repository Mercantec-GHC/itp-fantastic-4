namespace Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, GF2!");
            Console.WriteLine("Velkommen til opgaverne!");
            Help();
            bool run = true;
            while (run)
            {
                string valg = Console.ReadLine() ?? "?";

                switch (valg)
                {
                    case "1":
                        Variabler.Run();
                        break;
                    case "2":
                        Inputs.Run();
                        break;
                    case "3":
                        ControlFlow.Run();
                        break;
                    case "4":
                        Loops.Run();
                        break;
                    case "5":
                        Arrays.Run();
                        break;
                    case "6":
                        Methods.Run();
                        break;
                    case "7":
                        Classes.Run();
                        break;
                    case "8":
                        RockPaperScissors.Run();
                        break;
                    case "9":
                        BinaryConverter.Run();
                        break;
                    case "10":
                        Banko.Run();
                        break;
                    case "!":
                        run = false;
                        Console.WriteLine("Programmet afsluttes. Tak for denne gang!");
                        break;
                    case "?":
                        Help();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt opgavesæt!");

                        break;
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Indtast et opgavesæt: ; for listen af opgavesæt skriv '?'");
            }
        }

        public static void Help()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Vælg et opgavesæt:");
            Console.WriteLine("1: Variabler");
            Console.WriteLine("2: Inputs");
            Console.WriteLine("3: Control Flow, If, Else, Switch og Ternary operator");
            Console.WriteLine("4: Loops");
            Console.WriteLine("5: Arrays, List og Dictionary");
            Console.WriteLine("6: Methods");
            Console.WriteLine("7: Classes");
            Console.WriteLine("8: Sten, Saks, Papir projektet");
            Console.WriteLine("9: Binær/Decimal konvertering");
            Console.WriteLine("10: Banko!");
            Console.WriteLine("!: Afslut");
            Console.WriteLine("?: For overblik over opgaverne");
            Console.Write("Indtast dit valg: ");
        }
    }
}
