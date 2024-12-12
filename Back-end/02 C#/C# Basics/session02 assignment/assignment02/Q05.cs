using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    public class Q05
    {
		//Write C# program that Assigning one value type 
		//variable to another and modifying the value of one variable and mention what will happen
		public static void solve()
		{

			int x = 10;
			int y = 60;
			Console.WriteLine("y = " + y);
			y = x;
			Console.WriteLine("after asignment y = " + y);

		}
	}
}
