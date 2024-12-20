using Common;
namespace Session_01_Demo
{
    enum Grades
    {
        //Labels
        A, B, C, D,F
    }
    enum Gender
    {
        Male,Female
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region What is access modifiers


            //TypeA obj = new TypeA();
            ////obj.x // invalid
            ////obj.y // invalid
            //obj.z = 10;

            #endregion

            #region Enum
            Grades grades = new Grades();

            #endregion

            #region Struct
            Point p1 = new Point();
            // Declare for object from "point" struct 



            // CLR will allocate 8 byte unitiallized at stack

            //Console.WriteLine(p1);
            #endregion

            #region What is OOP

            #endregion

            #region Encapsulation
            // تغليف الداتا لحمايتها 
            Employee emp = new Employee(12, "ahmed", 20000);
            //emp.Id = 10;
            //Console.WriteLine(emp);

            emp.setName("zezo");
            emp.GetName();


            emp.Salary = 1000;
            Console.Write( emp.Salary);

            #endregion

            #region Indexers

            #endregion
        }
    }
}
