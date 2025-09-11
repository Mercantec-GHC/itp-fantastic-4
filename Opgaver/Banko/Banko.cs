namespace Opgaver
{
    public static class Banko
    {
        public static void Run()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);
            Console.WriteLine(randomNumber);
        }
    }
}
