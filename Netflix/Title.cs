using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Title
    {
        public List<string> MovieName = new List<string>() { "Transformers", "Eye In The Sky", "Lobster", "Cabin in The Woods", "Some Adam Sandler Shclock" };
        public List<string> Runtime = new List<string>() { "1hr", "1hr20min", "1hr30min", "1hr45min", "2hr" };
        public List<string> ShowName = new List<string>() { "Seinfeld", "Family Guy", "LOST", "Heroes", "How I Met Your Mother" };
        public List<int> ratings = new List<int>() { 0, 1, 2, 3 , 4 , 5 };
        
        public void MovieList()
        {
            Movie movie = new Movie();
            movie.Movies();
        }
        public void ShowList()
        {
            Episode ep = new Episode();
            ep.Show();
        }
        public void View()
        {
            View view = new View();
            view.All();
        }
        public void Genre()
        {
            int choice;
            Console.WriteLine("Choose types of Genres to View\n1- Action\n2-Comedy\n3-Romance\n4-Scifi\n5-All");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("invalid selection");
                Genre();
            }
            if (choice == 1)
            {
                Console.WriteLine();
            }
            if (choice == 2)
            {
                Console.WriteLine();
            }
            if (choice == 3)
            {
                Console.WriteLine();
            }
            if (choice == 4)
            {
                Console.WriteLine();
            }
            if (choice == 5)
            {
                View();
            }
        }
    }
}
