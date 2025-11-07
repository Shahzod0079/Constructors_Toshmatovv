using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Toshmatovv.Classes
{

    public class Student
    {
        public string Firstname = "";

        public string Lastname = "";

        public string Surname = "";

        public bool Scholarship = false;

        public int Course = 4;

        public Student(string firstname, string lastname, string surname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Surname = surname;
        }

        public Student(string firstname, string lastname, string surname, bool scholarship)
            : this(firstname, lastname, surname)
        {
            this.Scholarship = scholarship;
        }

        public Student(string firstname, string lastname, string surname, bool scholarship, int course)
            : this(firstname, lastname, surname, scholarship)
        {
            this.Course = course;
        }

        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}