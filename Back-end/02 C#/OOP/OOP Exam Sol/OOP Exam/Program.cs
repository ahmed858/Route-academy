using OOP_Exam.Abstract_Classes;
using OOP_Exam.Classes;
using OOP_Exam.Interfaces;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Type of exam (1 For Final | 2 For Practical)");
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Time of exam (30 min to 180 min)");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Number of exam ");
            int NumOfQues = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                // final Exam  
                FinalExam exam = new FinalExam() { Time = time, NumberOfQuestion = NumOfQues };
                for (int i = 0; i < NumOfQues; i++)
                {
                    Console.WriteLine("Please Enter the Type of Question (1 For MCQ | 2 For True Or Flase)");
                    int qType = int.Parse(Console.ReadLine());

                    if (qType == 1)
                    {
                        MCQ_Question mcq = new MCQ_Question();
                        Console.WriteLine(mcq.Header);


                        Console.WriteLine("Please Enter Question Body");
                        mcq.Body = Console.ReadLine().ToString();

                        Console.WriteLine("Please Enter Number of answers");
                        int ansNum= int.Parse(Console.ReadLine());
                        Answer[] answers = new Answer[ansNum];

                        for (int j = 0; j < ansNum; j++)
                        {
                            
                            Console.WriteLine($"Please Enter Answer number  {i}");
                            answers[i].AnswerText = Console.ReadLine();

                        }
                        mcq.AnswerList = answers;


                    }
                    Console.WriteLine("Please Enter the Time of exam (30 min to 180 min)");

                    Console.WriteLine("Please Enter the Number of exam ");
                }
            }
            else
            {
               

            }


        }
    }
}
