using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s = true;
            double num = 0;
            while (s)
            {
                Console.Write("Gim'me a num: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("NO.");
                    continue;
                }
                /*try
                {
                    num = double.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("SHIT code: " + ex.Message);
                    continue;
                }*/
                Console.WriteLine("Numah".PadRight(10) + "Square".PadRight(10) + "Cubed".PadRight(10));
                Console.WriteLine("#####".PadRight(10) + "######".PadRight(10) + "#####".PadRight(10));
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine( 
                                     (i + 1).ToString().PadRight(10) +
                                     (Math.Pow(i + 1, 2)).ToString().PadRight(10) +
                                     (Math.Pow(i + 1, 3)).ToString().PadRight(10)
                                     );
                }
                Console.Write("Continue (y/n)?: ");
                s = (Console.ReadLine() == "y")? true: false;
            }
        }
    }
}
