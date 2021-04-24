using System;

namespace ws_mid3
{
    class Program
    {
        static void Main(string[] args)
        {
            char word;
            word = char.Parse(Console.ReadLine());
            int width, heigth, floor;
            width = int.Parse(Console.ReadLine());
            heigth = int.Parse(Console.ReadLine());
            floor = int.Parse(Console.ReadLine());
            int i, j, k,l,m,n;
          /*  for (j = 0; j < heigth; j++) { 
            for (i = 0; i < width; i++)
            {
                Console.Write(word);
            }
            Console.WriteLine();
            }*/
            for (k = 1; k <= floor; k++)
            {
                for (j = 0; j < heigth; j++)
                {
                    for (i = 0; i < width*k; i++)
                    {
                        Console.Write(word);
                    }
                    Console.WriteLine();
                }
            }
        }
      
    }
}
