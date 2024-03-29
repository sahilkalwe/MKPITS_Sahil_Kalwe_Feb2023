﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_level_inheritance_with_methods
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class Employee : Person
    {
        int salary;
        String designation;

        public void getEmployeeData(int salary, String designation)
        {
            // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("designation : " + designation);

        }
    }

    public class ParttimeEmployee : Employee
    {
        int no_of_hours;
        public void getParttimeEmployeeData(int no_of_hours)
        {
            // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.no_of_hours = no_of_hours;

        }
        public void displayparttimeEmployeeData()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("no of hours : " + no_of_hours);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            ParttimeEmployee p1 = new ParttimeEmployee();//creating object of child class\

            p1.getPersonData("arifa", "nagpur");
            p1.getEmployeeData(111, "manager");
            p1.getParttimeEmployeeData(5);
            p1.displayPersonData();
            p1.displayEmployeeData();
            p1.displayparttimeEmployeeData();

        }
    }

}

