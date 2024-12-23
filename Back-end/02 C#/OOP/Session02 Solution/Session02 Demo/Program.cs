    namespace Session02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            PhoneBook note =new PhoneBook(3);
            note.addPerson(0, "ahmed", 0123567);
            note.addPerson(1, "mo7sen", 98765); ;
            note.addPerson(2, "zezo", 9765); ;
            //note.setNumber("zezo", 9999);
            //Console.WriteLine(note.getNumber("zezo"));
            note["zezo"] = 99999992;
            Console.WriteLine(note["zezo"]);

            #endregion
            #region Class

            #endregion
            #region Inheritance
            #endregion
            #region Relationships Between Classes
            #endregion
            #region Access Modifiers (Private Protected - Protected - Internal Protected)
            #endregion
            #region Class Vs Struct
            #endregion
            #region PolMorphism
            #endregion
        }
    }
}
