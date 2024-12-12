namespace Session03_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fractions & discards
            //float x = 322.33f;
            //double y= 678.23;
            //decimal z = 4567.87M;
            ////discard=> just for readability
            //long number = 10_000_000_000;
            #endregion

            #region implicit casting & explicet casting
            //int x = 8;
            //long y = x;


            #region explicet casting
            #region example 01
            //long z = 645;
            //z = 534232345643323;
            ////defensive code

            //int num = z.GetType() == typeof(int) ? (int)z : 1893;
            ////checked
            ////{
            ////    int xx = (int)z;
            ////    unchecked
            ////    {

            ////        Console.WriteLine(xx);
            ////    }

            ////}
            #endregion
            #region example 02
            //int x = 5;
            //double y = x;// implict casting



            //double x = 5.6;
            //int y = (int)x;
            //Console.WriteLine(y);// 5
            #endregion


            #endregion




            #endregion

            #region Try Parse
            //string str = "ahmed";
            //int x;
            //bool Flag  = int.TryParse(str, out x);
            //Console.WriteLine(Flag);
            //Console.WriteLine(x);

            #endregion

            #region opertors
            #region unary operator
            //int x = 10;
            //Console.WriteLine(++x);//11
            //Console.WriteLine(x++);//11 -_-
            //Console.WriteLine(x);//12 incremented after print 

            //Console.WriteLine(--x);//11
            //Console.WriteLine(x--);//11 -_-
            //// postfix: print then increment
            //// prefix:  increment then print 


            #endregion

            #endregion

            #region opertors pariorty
            /*
             * 1- unary prefix
             * 2- round braces ()
             * 3- * / %
             * 4- + - 
             */

            #endregion
            #region string formatting
            int x = 10, y = 20;
            string str = "eqation : " + x + " + " + y + " = " + (x + y);
            Console.WriteLine(str);
            str = String.Format("eqation: {0} + {1} = {2}", x, y, (x + y));
            Console.WriteLine(str);

            // $ String interpolation [manuplation oprator]
            str = $"eqation: {x} + {y} = {x + y}";
            #endregion
        }
    }
}
