using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Movie:Title
    {
        public void Movies()
        {
            Console.WriteLine("Welcome to Movie Selection\n");
            for (int i = 0; i < MovieName.Count; i++)
            {
                Console.WriteLine(MovieName[i] + ": " + Runtime[i] + ": " + ratings[i] + "/5");
            }
            Console.ReadKey();
            MovieSelect();
        }
        public void MovieSelect()
        {
            Console.WriteLine("Select a Film");
            string choice = Console.ReadLine();
            if (choice == MovieName[0])
            {
                Console.WriteLine("Runtime: ");
            }
            else if (choice == MovieName[1])
            {
                Console.WriteLine("Runtime: ");
            }
            else if (choice == MovieName[2])
            {
                Console.WriteLine("Runtime: ");
            }
            else if (choice == MovieName[3])
            {
                Console.WriteLine("Runtime: ");
            }
            else if (choice == MovieName[4])
            {
                Console.WriteLine("Runtime: ");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                MovieSelect();
            }
        }
    }
}
