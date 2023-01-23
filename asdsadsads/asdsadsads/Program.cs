
using System;
using System.Collections.Generic;

class Building
{
    // A dictionary to store the rooms and their availability
    private Dictionary<string, bool> rooms = new Dictionary<string, bool>();

    public Building()
    {
        // Initialize the rooms and their availability
        rooms.Add("Room 1", true);
        rooms.Add("Room 2", true);
        rooms.Add("Room 3", true);
        rooms.Add("Room 4", true);
    }

    public void ReserveRoom(string room)
    {
    if (rooms[room] == true)
        {
            rooms[room] = false;
            Console.WriteLine("Room reserved successfully!");
        }
        else
        {
            Console.WriteLine("Sorry, that room is not available.");
        }
    }

    public void CheckAvailability()
    {
        foreach (KeyValuePair<string, bool> entry in rooms)
        {
            Console.WriteLine("{0} is {1}", entry.Key, entry.Value ? "available" : "not available");
        }
    }
}

class RoomReservation
{
    static void Main(string[] args)
    {
        // Create an instance of the Building class
        Building building = new Building();

        // Continuously prompt the user for input
        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Reserve a room");
            Console.WriteLine("2. Check room availability");
            Console.WriteLine("3. Exit");

            // Get the user's choice
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Reserve a room
                Console.WriteLine("Which room would you like to reserve?");
                string room = Console.ReadLine();
                building.ReserveRoom(room);
            }
            else if (choice == 2)
            {
                // Check room availability
                building.CheckAvailability();
            }
            else if (choice == 3)
            {
                // Exit the program
                break;
            }
            else
            {
                // Invalid choice
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}

