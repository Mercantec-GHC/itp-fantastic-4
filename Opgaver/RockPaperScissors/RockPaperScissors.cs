using System;
namespace Opgaver;

public enum Choice
{
    Sten = 1,   // Rock :3
    Saks = 2,   // Scissors ;>
    Papir = 3   // Paper ^_^
}

public class RockPaperScissors
{
    private static Random rnd = new Random(); // mutual random

    public static void Run()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Velkommen til Sten, Saks, Papir!");
        Console.WriteLine("Spil mod computeren. Først til 3 sejre vinder :3\n");

        int playerScore = 0;
        int computerScore = 0;

        while (playerScore < 3 && computerScore < 3)
        {
            int result = Game();

            if (result == 1) playerScore++;
            else if (result == 2) computerScore++;

            Console.WriteLine($"\nStilling: Spiller 1 = {playerScore}, Computer = {computerScore}\n");
        }

        if (playerScore == 3)
            Console.WriteLine("Du vandt hele spillet! :D");
        else
            Console.WriteLine("Computeren vandt hele spillet! >:)");
    }

    public static int Game()
    {
        Choice player = GetPlayerChoice(1); // players choice from 1 to 3 as a rock scissors paper accordingly

       
        Choice computer = (Choice)rnd.Next(1, 4); // pcs choice from 1 to 3 as a rock scissors paper accordingly
        Console.WriteLine($"Computeren valgte: {computer}");

        return CompareResults(player, computer); // 0 = draw, 1 = player wins, 2 = computer wins
    }

    public static Choice GetPlayerChoice(int PlayerNumber)
    {
        while (true)
        {
            Console.Write($"Spiller {PlayerNumber}, vælg (1=Sten, 2=Saks, 3=Papir): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 3)
            {
                return (Choice)choice;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Prøv igen :(");
            }
        }
    }
    public static int CompareResults(Choice player, Choice computer) // 0 = draw, 1 = player wins, 2 = computer wins
    {
        Console.WriteLine($"\nSpiller 1 valgte: {player}");
        Console.WriteLine($"Computeren valgte: {computer}\n");

        if (player == computer)
        {
            Console.WriteLine("Uafgjort! :|");
            return 0;
        }
        else if ((player == Choice.Sten && computer == Choice.Saks) ||
                 (player == Choice.Saks && computer == Choice.Papir) ||
                 (player == Choice.Papir && computer == Choice.Sten))
        {
            Console.WriteLine("Spiller 1 vinder runden! :D");
            return 1;
        }
        else
        {
            Console.WriteLine("Computeren vinder runden! >:)");
            return 2;
        }
    }
}
