using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Episode:Title
    {
        public List<int> episodes = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        
        public void Show()
        {
            Console.WriteLine("Choose a series\n");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(ShowName[i] + ratings[i] + "/5");
            }
            Console.ReadKey();
            ShowSelect();
        }
        public void ShowSelect()
        {
            //List<int> ratings = new List<int>() { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Select a Show");
            string choice = Console.ReadLine();
            if (choice == ShowName[0])
            {

            }
            else if (choice == ShowName[1])
            {

            }
            else if (choice == ShowName[2])
            {

            }
            else if (choice == ShowName[3])
            {

            }
            else if (choice == ShowName[4])
            {

            }
            else
            {
                Console.WriteLine("Invalid Choice");
                ShowSelect();
            }
        }

    }
}
