using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 8)
            {
                if (x % 2 !=0){
                    Console.WriteLine("XOXOXOXO");
                    x++;
                }
                else{
                    Console.WriteLine("OXOXOXOX");
                    x++;
                }
                
            }        
        }
    }
}
