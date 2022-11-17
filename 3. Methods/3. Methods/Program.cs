namespace Methods
{

    public class Program
	{
        static void Main(string[] args)
        {
            

        }

        static void userParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
        
        static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }
        }
    }
}