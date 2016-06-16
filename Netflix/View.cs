using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class View:Title
    {
        public void All()
        {
            Console.WriteLine("Shows\n");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(ShowName[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Movies\n");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(MovieName[i]);
            }
            Console.ReadKey();
        }
    }
}
