using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Gpa
        {
            get { return _gpa; }
            set
            {
                if (0 <= value && value <= 4)
                {
                    _gpa = value;
                }
                else
                {
                    //TODO exception or custom error?
                }//end else
            }//end set
        }//end Gpa

        //ctors
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        public Student() { }

        //methods
        public override string ToString()
        {
            return string.Format("Student: {0}, {1} \nID: {2} \nGPA: {3:f1}\n", LastName, FirstName, Id, Gpa);
        }
    }
}
