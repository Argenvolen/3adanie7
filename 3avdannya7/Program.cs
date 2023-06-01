namespace _3avdannya7
{
    internal class Program
    {
        enum ConversionOption
        {
            InchesToCm,
            CmToInches
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Виберiть опцiю конвертацiї:");
            Console.WriteLine("0. Дюйми в сантиметри");
            Console.WriteLine("1. Сантиметри в дюйми");
            Console.Write("Ваш вибiр: ");

            string choice = Console.ReadLine();

            if (Enum.TryParse(choice, out ConversionOption conversionOption))
            {
                double input;

                switch (conversionOption)
                {
                    case ConversionOption.InchesToCm:
                        Console.Write("Введiть значення в дюймах: ");
                        string inputString = Console.ReadLine();

                        if (double.TryParse(inputString, out input))
                        {
                            double result = input * 2.54;
                            Console.WriteLine($"{input} дюймiв = {result} сантиметрiв");
                        }
                        else
                        {
                            Console.WriteLine("Некоректне значення!");
                        }
                        break;

                    case ConversionOption.CmToInches:
                        Console.Write("Введiть значення в сантиметрах: ");
                        inputString = Console.ReadLine();

                        if (double.TryParse(inputString, out input))
                        {
                            double result = input / 2.54;
                            Console.WriteLine($"{input} сантиметрiв = {result} дюймiв");
                        }
                        else
                        {
                            Console.WriteLine("Некоректне значення!");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некоректний вибiр!");
            }

            Console.ReadLine();
        }
    }
}
  