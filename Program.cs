using System;

namespace Fundamentals2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            static void Start()
            {
                Console.WriteLine("Please enter a valid integer");

                string input1 = Console.ReadLine();
                int i;

                try
                {
                    i = Int32.Parse(input1);
                    Second(i);
                }
                catch (Exception ex)
                {
                    Start();
                }
            }
            static void Second(int i)
            {
                Console.WriteLine("Please enter a valid secondary integer");

                int i1 = i;
                int i2;


                string input2 = Console.ReadLine();

                try
                {
                    i2= Int32.Parse(input2);
                    int addition;
                    int reduction;
                    Calculate(i1, i2, out addition, out reduction);
                    Print(addition, reduction);
                }
                catch (Exception ex)
                {
                    Second(i1);
                }

            }
            static void Calculate(int i1, int i2, out int addition, out int reduction)
            {
                addition = i1 + i2;
                reduction = i1 - i2;
            }
            static void Print(int addition, int reduction)
            {
                Console.WriteLine("The addition of the given integers results in " + addition + ", the reduction results in " + reduction + " ...");
            }

        }
    }
}
