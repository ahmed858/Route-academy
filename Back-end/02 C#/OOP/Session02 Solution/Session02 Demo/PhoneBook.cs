using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Demo
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;

        #endregion
        #region Property
        public int Size// read only property 
        {
            get { return size; }

        }
        #endregion
        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Methods

        // object member method
        public void addPerson(int position, string Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                if (position < size & position >= 0)
                {

                    names[position] = Name;
                    numbers[position] = Number;
                }
            }
        }
        #endregion
        #region  Encapsulation
        #region Getter/Setter
        //Getter
        public long getNumber(string Name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name.Equals(names[i]))
                        return numbers[i];
                }
            }
            return -1;
        }
        public void setNumber(string Name, long newNumber)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name.Equals(names[i]))
                    {
                        numbers[i] = newNumber; break;
                    }
                }
            }

        }
        #endregion
        #region Indexer
        // it is a Special Property 
        // 1- Named Always With KeyWord this
        // can Take Parameters
        public long this[string Name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name.Equals(names[i]))
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name.Equals(names[i]))
                        {
                            numbers[i] = value  ; break;
                        }
                    }
                }
            }
        }
     
        #endregion
        #endregion
    }
}
