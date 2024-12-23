namespace Session02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                HireDate d = new HireDate(23, 1, 2000);
                Employee e = new Employee(1, "ahmed", SecurityLevelEnum.DBA, 3999, d, "M");
                Console.WriteLine(e);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
