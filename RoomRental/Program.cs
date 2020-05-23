using System;

namespace RoomRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Rental[] vect = new Rental[10];

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rental #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Rental(name, email);
            }
            Console.WriteLine();

            Console.WriteLine("Busy rooms: ");
            for(int i=0; i < vect.Length; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i].Name}, {vect[i].Email}");
                }
            }
        }
    }
}
