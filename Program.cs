using System;

namespace Diamond_Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars=5;
        
        for (var i=1; i<=stars; i++){
            Console.Write("x");
            for(var j=0; j<=5; j++){
                Console.Write(" ");
            }
        }
        
        }
    }
}
