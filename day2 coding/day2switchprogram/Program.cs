using System;

class Program
{
    static void Main(string[] args)
    {
        int totalAmount = 0;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nPlease select a menu item:");
            Console.WriteLine("1 - Pizza (Rs 100)");
            Console.WriteLine("2 - Burger (Rs 50)");
            Console.WriteLine("3 - Pasta (Rs 200)");
            Console.WriteLine("4 - Exit");

            Console.Write("Enter your choice: ");
            int choice=Convert.ToInt32(Console.ReadLine());;


                int quantity = 0;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Pizza.");
                        quantity = GetQuantity();
                        totalAmount += 100 * quantity;
                        Console.WriteLine($"You added {quantity} Pizza(s).");
                        break;
                    case 2:
                        Console.WriteLine("You selected Burger.");
                        quantity = GetQuantity();
                        totalAmount += 50 * quantity;
                        Console.WriteLine($"You added {quantity} Burger(s).");
                        break;
                    case 3:
                        Console.WriteLine("You selected Pasta.");
                        quantity = GetQuantity();
                        totalAmount += 200 * quantity;
                        Console.WriteLine($"You added {quantity} Pasta(s).");
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine($"Your total so far is: Rs {totalAmount}");
                }
            
        }

        Console.WriteLine($"Thank you for using the program. Your final total is: Rs {totalAmount}");
    }

    static int GetQuantity()
    {
      Console.WriteLine("tell me the number of quantity");
        int quantity = Convert.ToInt32(Console.ReadLine());

        
        return quantity;
    }
}
