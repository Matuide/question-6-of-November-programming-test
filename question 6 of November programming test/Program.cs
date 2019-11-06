using System;

namespace question_6_of_November_programming_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            Console.WriteLine("Enter a whole number:  ");
             Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2;
            Console.WriteLine("Enter a whole number:  ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Temp1 = Number1;
            int Temp2 = Number2;
            while (Temp1 != Temp2)
            {
                if (Temp1 > Temp2)
                {
                    Temp1 = Temp1 - Temp2;
                }
                else
                {
                    Temp2 = Temp2 - Temp1;
                }
            }
            int Result = Temp1;
            Console.WriteLine(Convert.ToString( Result)+ " is the GCF of "+ Number1+ " and "+ Number2);
        }
        
    }
}
