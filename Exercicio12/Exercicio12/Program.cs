using Exercicio12;
using System;
using System.Globalization;

namespace Vetor_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] rooms = new Quartos[10];

            for (int i = 0; i < rooms.Length; i++)
            {
                Console.Write($"[ {i} ] ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");

            Console.Write("How many students will reserve rooms? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                rooms[roomNumber] = new Quartos { Name = name, Email = email, Rooms = roomNumber };

                Console.Clear();
                Console.WriteLine("Status visual dos quartos:");
                
                for (int a = 0; a < 10; a++)
                {
                    
                    if (rooms[a] != null)
                    {
                        Console.Write("[ X ] "); // Ocupado
                    }
                    else
                    {
                        Console.Write($"[ {a} ] "); // Livre
                    }
                }
                Console.WriteLine();
                
                Console.WriteLine("-----------------------------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }

        }
    }
}