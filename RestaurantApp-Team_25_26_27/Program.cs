using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_25_26_27
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant { Name = "Open The doorrrr", Type = "Fast Food", Rating = 4.2 },
            new Restaurant { Name = "Mo", Type = "Suki", Rating = 4.7 },
            new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("Not completed");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("\nNo restaurants yet.");
                return;
            }

            int maxIdx = 0;
            int minIdx = 0;

            for (int i = 1; i < restaurants.Count; i++)
            {
                if (restaurants[i].Rating > restaurants[maxIdx].Rating) maxIdx = i;
                if (restaurants[i].Rating < restaurants[minIdx].Rating) minIdx = i;
            }

            Console.WriteLine("\n--- Summary ---");
            Console.WriteLine($"Highest: {restaurants[maxIdx].Name} ({restaurants[maxIdx].Type}) - {restaurants[maxIdx].Rating:F1}");
            Console.WriteLine($"Lowest : {restaurants[minIdx].Name} ({restaurants[minIdx].Type}) - {restaurants[minIdx].Rating:F1}");
        }
    }
}