using System;

namespace Diamond_Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines would you like your diamond to have?");
            int n = int.Parse(Console.ReadLine());

            //first half of the diamond

            //number of times it will print a line
            for (int i=1; i<=n; i++ ){
                //adds the space in between *
                for (int j=0; j<(n-i); j++)
                    Console.Write(" ");
                    //writes the * n amount of times
                    for(int j=1; j<=i; j++)
                    Console.Write("*");
                   
                    for (int k=1; k<i; k++)
                    Console.Write("*");
                    Console.WriteLine();                
            }
            // second half of the diamond - goes in reverse.
             
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
 
            Console.WriteLine();
        }
    }
}
