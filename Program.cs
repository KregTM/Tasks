using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NENVISHU GLASNIE: ");
            string userInput = Console.ReadLine();

            Glasnie(userInput);
        }

        static void Glasnie(string stringData)
        {
            string glasnie = "aAeEiIoOuUyY";
            string result = "";
            for (int i = 0; i < stringData.Length; i++)
            {
                if (!glasnie.Contains(stringData[i]))
                {
                    result = result + stringData[i];
                }
            }
             Console.WriteLine("Welcome to the club, " + result);
        }  
    }
}
