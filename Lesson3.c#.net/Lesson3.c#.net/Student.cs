using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.c_.net
{
    public class Student
    {

        public readonly string id;
        public const int MAX_LENGTH = 20;
        private string FirstName;
        public Student(string id) { this.id = id; }


        public string firstName
        {
            get { return FirstName; }
            set
            {
                if (value.Length < MAX_LENGTH) // בדיקה על הערך החדש
                    FirstName = value;
                else
                    throw new Exception("This is too long FirstName");
            }
        }
        private string LastName;

        public string lestName
        {
            get { return LastName; }
            set
            {
                if (value.Length < MAX_LENGTH)
                    LastName = value;
                else 
                    throw new Exception("this is too long FirstName");

            }
        }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public double Avg { get; set; }



    }
}
