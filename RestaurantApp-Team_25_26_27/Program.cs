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

    new Restaurant { Name = "MonkeyPig", Type = "Suki", Rating = 4.7 },
    new Restaurant { Name = "JaiAndi", Type = "Dessert", Rating = 4.2 },
    new Restaurant { Name = "chikGadoow", Type = "Japanese", Rating = 4.8 },
    new Restaurant { Name = "PigBin", Type = "Drink", Rating = 4.8 },
    new Restaurant { Name = "Mala JIng", Type = "Chinese Food", Rating = 4.5 },
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
            // รายการร้านอาหารที่สามารถเลือกได้
            List<Restaurant> availableRestaurants = new List<Restaurant>
    {
        new Restaurant { Name = "Open The doorrrr", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MonkeyPig", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "JaiAndi", Type = "Dessert", Rating = 4.2 },
        new Restaurant { Name = "chikGadoow", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "PigBin", Type = "Drink", Rating = 4.8 },
        new Restaurant { Name = "Mala JIng", Type = "Chinese Food", Rating = 4.5 }
    };


            Console.WriteLine("\n===== Add Restaurant =====");
            Console.WriteLine("Select Restaurant:");


            // แสดงรายการร้านอาหาร
            for (int i = 0; i < availableRestaurants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableRestaurants[i].Name} | " +
                    $"{availableRestaurants[i].Type} | Rating: {availableRestaurants[i].Rating}");
            }


            Console.WriteLine("0. Back to Menu");
            Console.Write("Select Restaurant: ");


            int choice;


            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid Selection!");
                return;
            }


            if (choice == 0)
            {
                return;
            }


            if (choice < 1 || choice > availableRestaurants.Count)
            {
                Console.WriteLine("Invalid Selection!");
                return;
            }


            // เลือกร้านอาหารและเพิ่มเข้า List
            Restaurant selectedRestaurant = availableRestaurants[choice - 1];


            restaurants.Add(selectedRestaurant);


            Console.WriteLine("\nRestaurant added successfully!");
            Console.WriteLine("Name: " + selectedRestaurant.Name);
            Console.WriteLine("Type: " + selectedRestaurant.Type);
            Console.WriteLine("Rating: " + selectedRestaurant.Rating);
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("\n=== Restaurants Rating 4.5 Up ===");

            foreach (var r in restaurants)
            {
                if (r.Rating >= 4.5)
                {
                    Console.WriteLine($"Name: {r.Name}");
                    Console.WriteLine($"Type: {r.Type}");
                    Console.WriteLine($"Rating: {r.Rating:F1}");
                    Console.WriteLine("----------------------");
                }
            }
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