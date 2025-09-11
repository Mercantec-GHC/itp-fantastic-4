namespace Opgaver
{
    public class BinaryConverter
    {
        // Konverterer en binær streng (fx "10101010") til et heltal (fx 170)
        public static int BinaryToDecimal(string binary)
        {
            // TODO: Implementér konvertering fra binær til decimal uden indbyggede konverteringsfunktioner
            return 0;
        }

        // Konverterer et heltal (fx 170) til en binær streng (fx "10101010")
        public static string DecimalToBinary(int number)
        {
            // TODO: Implementér konvertering fra decimal til binær uden indbyggede konverteringsfunktioner
            return "";
        }

        // Konverterer en binær talgruppe (fx "10111011.01001011.10101010.01010101") til decimaler (fx "187.75.170.85")
        public static string BinaryGroupToDecimal(string binaryGroup)
        {
            // TODO: Split binærgruppen op og brug BinaryToDecimal på hver del
            return "";
        }

        // Konverterer en decimal talgruppe (fx "187.75.170.85") til binær (fx "10111011.01001011.10101010.01010101")
        public static string DecimalGroupToBinary(string decimalGroup)
        {
            // TODO: Split decimalgruppen op og brug DecimalToBinary på hver del
            return "";
        }

        // Brugermenu til at teste konverteringerne
        public static void Run()
        {
            // TODO: Lav en simpel menu, hvor brugeren kan vælge retning og indtaste tal
            Console.WriteLine("Velkommen til binær-decimal konverteringsprogrammet!");
        }
    }
}
