using OOP_Introduction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    class Instructor : OOP_Introduction.Person
    {
        public string InsNumber;

        public Instructor() 
        {
            InsNumber = "I1234";
        }

        public Instructor(string INumber, string Isal, string ftName, string ltName) : base(ltName)
        {
            InsNumber = INumber;
        }

        new public string getName()
        {
            return InsNumber + " " + base.getName();
        }
    }
}
