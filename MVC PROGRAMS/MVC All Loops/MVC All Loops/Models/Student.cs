namespace MVC_All_Loops.Models
{
    public class Student
    {

        public string name;
        public int age;
        //constructor

        public Student(string a, int b)
        {
            name = a;
            age = b;
        }
        //creating property named Name and Age
        public string Name
        {

            get
            {
                return name;

            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

    }
}
