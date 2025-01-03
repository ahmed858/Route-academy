namespace Assignment_Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D();
            Point3D p2 = new Point3D();


            Console.WriteLine("Enter Point 1.");
            Console.Write("X:");
            p1.X = double.Parse(Console.ReadLine());
            Console.Write("Y:");
            p1.Y = double.Parse(Console.ReadLine());
            Console.Write("Z:");
            p1.Z = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Point 2.");
            Console.Write("X:");
            p2.X = double.Parse( Console.ReadLine());
            Console.Write("Y:");
            p2.Y= double.Parse(Console.ReadLine());
            Console.Write("Z:");
            p2.Z = double.Parse(Console.ReadLine());

            Point3D[] arr =
            {
                new Point3D(0,1,1),
                new Point3D(0,2,1),
                new Point3D(0,0,1),
                new Point3D(0,-1,1)

            };
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("Add(10, 5): " + Maths.Add(10, 5));
            Console.WriteLine("Subtract(10, 5): " + Maths.Subtract(10, 5));
            Console.WriteLine("Multiply(10, 5): " + Maths.Multiply(10, 5));
            Console.WriteLine("Divide(10, 5): " + Maths.Divide(10, 5));


        }







    }
}
