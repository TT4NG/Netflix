using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Menu
    {
        public void Open()
        {
            int choice;
            Console.WriteLine("Welcome to Netflix!\n\nPlease Select an Option:\n1 - Movies\n2 - Shows\n3 - View All\n4 - Genre");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid Input");
                Open();
            }
            else if (choice == 1)
            {
                Title Title = new Title();
                Title.MovieList();
                Open();

            }
            else if (choice == 2)
            {
                Title Title = new Title();
                Title.ShowList();
                Open();
            }
            else if (choice == 3)
            {
                View view = new View();
                view.All();
                Open();
            }
        }
    }
}
