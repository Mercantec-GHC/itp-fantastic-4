using System;

namespace Opgaver.Indputs
{
    public static class Indputs
    {
        public static void String1()
        {
            Console.WriteLine("Lav et program som gemmer et input som en string og skriver strengen ud i konsollen");
            Console.WriteLine("Indtast en streng:");
            string input = Console.ReadLine() ?? "";
            Console.WriteLine(input);
        }

        public static void Int1()
        {
            Console.WriteLine("Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen");
            Console.WriteLine("Indtast et tal:");
            string input = Console.ReadLine() ?? "0";
            int number = int.Parse(input);
            Console.WriteLine(number);
        }

        public static void Double1()
        {
            Console.WriteLine("Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen");
            Console.WriteLine("Indtast et decimaltal:");
            string input = Console.ReadLine() ?? "0";
            double number = double.Parse(input);
            Console.WriteLine(number);
        }

        public static void Bool1()
        {
            Console.WriteLine("Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen");
            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            string input = Console.ReadLine() ?? "false";
            bool value = bool.Parse(input);
            Console.WriteLine(value);
        }
    }
}
