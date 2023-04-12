using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_example_with_multiple__methods
{
    class gatisir
    {
        public string designation;
        public float salary;
        public int id;
        public void getdata(string designation, float salary, int id)
        {
            this.designation = designation;
            this.salary = salary;
            this.id = id;
        }
        public void displaydata()
        {
            Console.WriteLine("designation is " + designation);
            Console.WriteLine("salary is " + salary);
            Console.WriteLine("id is " + id);
        }
        class khansir : gatisir
        {
            public string post;
            public float tankhwa;
            public int time;
            public void getadat(string post, int tankhwa, int time)
            {
                this.post = post;
                this.time = time;
                this.tankhwa = tankhwa;
            }
            public void displaydat()
            {
                Console.WriteLine("post is " + post);
                Console.WriteLine("time is " + time);
                Console.WriteLine("tankhwa is " + tankhwa);

            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                khansir k1 = new khansir();
                k1.getdata("boss", 60000, 24);
                k1.getadat("asisstant profesor", 56789, 9);
                k1.displaydata();
                k1.displaydat();
                Console.ReadKey();
            }
        }
    }
} 