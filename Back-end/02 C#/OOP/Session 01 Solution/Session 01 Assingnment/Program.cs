namespace Session_01_Assingnment
{
    internal class Program
    {
        #region Enums
        enum WeekDays
        {
            Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday

        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public enum Permessions
        {
            Read, write, Delete, Execute
        }

        enum PrimaryColors
        {
            Red, Green, Blue
        }

        #endregion




        static void Main(string[] args)
        {
            #region Q01
            //foreach (var day in Enum.GetValues(typeof(WeekDays))) Console.WriteLine(day);
            #endregion

            #region Q02
            //Person[] persons = new Person[3];


            //persons[0] = new Person("ahmed", 25);
            //persons[1] = new Person("zezo", 27);
            //persons[2] = new Person("ahmed", 35);


            //Console.WriteLine("Details of all persons:");
            //foreach (var person in persons) Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            #endregion



            #region Q03


            //Console.WriteLine("Enter the name of a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //Season season;
            //if (Enum.TryParse(input, true, out season) == true)
            //{
            //Console.WriteLine(season);
            //    string monthRange = season switch
            //    {
            //        Season.Spring => "March to May",
            //        Season.Summer => "June to August",
            //        Season.Autumn => "September to November",
            //        Season.Winter => "December to February",
            //        _ => "Unknown Season"
            //    };
            //    Console.WriteLine($"The months for {season} are: {monthRange}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion

            #region Q04

            #endregion


            #region Q05
            Console.WriteLine("Enter Color:");
            string color = Console.ReadLine();

            PrimaryColors primaryColors;

            if (Enum.TryParse(color, true, out primaryColors) == true)
            {

                Console.WriteLine($"Primary color");
            }
            else
            {
                Console.WriteLine("it is not primary");
            }
            #endregion


            #region Q06  
            Console.WriteLine("Enter the coordinates of the first point (X Y):");
            string[] firstInput = Console.ReadLine().Split();
            Point point1 = new Point(double.Parse(firstInput[0]), double.Parse(firstInput[1]));

            Console.WriteLine("Enter the coordinates of the second point (X Y):");
            string[] secondInput = Console.ReadLine().Split();
            Point point2 = new Point(double.Parse(secondInput[0]), double.Parse(secondInput[1]));

            double distance = point1.DistanceTo(point2);

            Console.WriteLine($"The distance between the two points is: {distance:F2}");

            #endregion

            #region Q07
            // Array to store details of 3 persons
            Person[] persons = new Person[3];

            // Input details for 3 persons
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);
            }

            // Find the oldest person
            Person oldest = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            // Display the oldest person's details
            Console.WriteLine($"\nThe oldest person is {oldest.Name} with age {oldest.Age}.");

            #endregion
        }

    }
}
