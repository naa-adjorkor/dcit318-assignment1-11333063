namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Equilateral");
            else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles");
            else
                Console.WriteLine("Scalene");
        }
    }
}
