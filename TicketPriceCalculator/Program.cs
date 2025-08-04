namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int price = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"Ticket price: GHC {price}");
        }
    }
}
