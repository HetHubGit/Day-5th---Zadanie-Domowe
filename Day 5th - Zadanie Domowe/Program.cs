internal class Program
{
    private static void Main(string[] args)
    {
        //Zadanie Domowe
        var number = 433422009;

        String numberInSring = number.ToString();
        char[] numbers = numberInSring.ToArray();
        
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        foreach (char singular in digits)
        {
            var count = 0;
            foreach (char c in numbers)
            {
                if (singular == c) count++;
            }
            Console.WriteLine(singular + " => " + count);
        }

    }
}