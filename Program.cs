using System;

namespace Diamond_Draw
{
    class Program
    {
        static void Main(string[] args)
        {
        //-----------first half of diamond---------------
            var stars=5;
        
        for (var i=0; i<=stars; i++){
             for(var lineNumber = i; lineNumber<=stars-1; lineNumber++){
                Console.Write(" ");
            }
            for(var j=i; j>=1; j--){
                //Console.Write(i);
                Console.Write("*");
                Console.Write(" ");  
                          
            }
           
            Console.WriteLine();
            
        }

        //-----------first half of diamond---------------\
        
        
        }
    }
}

//    *     4 spaces
//   * *    3 spaces
//  * * *   2 space
// * * * *  1 spaces
//* * * * * 0 spaces

//when lineNumber = stars, spaces = 0
//when lineNumber = 1, spaces = stars-1;
