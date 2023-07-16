using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Desktop01.Model
{
    public class User
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BitmapImage Image { get; set; }  

        public string  DateOfBirth{ get; set; }
        

        public string Department { get; set; }

        public string AcademicAdvisor { get; set; }

        public double GPA { get; set; }

        public String ImagePath
        {
            get { return $"/Model/Images/{Image}"; }
        }

        public User(int age, string firstName, string lastName, string dateOfBirth,BitmapImage  image,string department,string academicAdvosor , double gpa )
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
            Department = department;
            AcademicAdvisor = academicAdvosor;
            GPA = gpa;
        }

        public User()
        {
        }

    }


}
