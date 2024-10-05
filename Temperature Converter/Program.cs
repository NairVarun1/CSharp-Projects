using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the temperature in Kelvin: ");
        float temp = Convert.ToSingle(Console.ReadLine());

        if (temp < 0)
        {
            Console.WriteLine("Enter a valid temperature !");
        }
        else
        {
            Console.WriteLine("Which operation do you want to perform ?");
            Console.WriteLine("Enter 1 to convert to Celcius");
            Console.WriteLine("Enter 2 to convert to Farenheit");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine("The temperature in Kelvin is " + temp + "K");
                    float celsius = (float)(temp - 273.15);
                    Console.WriteLine("The temperature in Celsius is " + celsius + " C");
                    break;

                case "2":
                    Console.WriteLine("The temperature in Kelvin is " + temp + "K");
                    float farenheit = (float)(((temp - 273.15) * 9 / 5) + 32);
                    Console.WriteLine("The temperatue in Farenheit is " + farenheit + " F");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation !!");
                    break;
            }
        }
    }
}