namespace MVC_Class_Object_Methods.Models
{
    public class Std
    {
        public string name;
        public int age;
        //constructor

        public Std(string a, int b)
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
