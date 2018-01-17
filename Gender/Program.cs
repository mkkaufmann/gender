using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender
{
    class Program
    {
        class Person
        {
            private bool isMale;
            private string name;
            private int age;
            private double income;
            private bool isBadAtCS;

            public Person(bool _isMale, string _name, int _age, double _income, bool _isBadAtCS)
            {
                isMale = _isMale;
                name = _name;
                age = _age;
                income = _income;
                isBadAtCS = _isBadAtCS;
            }
            public double Income
            {
                get
                {
                    return income;
                }
                set
                {
                    if (value > 0)
                    {
                        income = value;
                    }
                    else
                    {
                        Console.WriteLine("no negative salaries");
                    }
                }
            }
            public bool IsMale
            {
                get
                {
                    return isMale;
                }
                set
                {
                    isMale = value;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value.ToString().Split().All(i => Double.IsNaN((double)int.Parse(i))))
                    {
                        name = value;
                    }
                    else
                    {
                        Console.WriteLine("no garbopls");
                    }
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("no negative ages");
                    }
                }
            }
            public bool IsBadAtCS
            {
                get
                {
                    return isBadAtCS;
                }
                set
                {
                    isBadAtCS = value;
                }
            }
        }
        class Student : Person
        {
            private double gpa;
            private string favoriteSubject;
            public double Gpa
            {
                get
                {
                    return gpa;
                }
                set
                {
                    if (value > 0)
                    {
                        gpa = value;
                    }
                    else
                    {
                        Console.WriteLine("no negative salaries");
                    }
                }
            }
            public string FavoriteSubject
            {
                get
                {
                    return favoriteSubject;
                }
                set
                {
                    if (value != "Biology")
                    {
                        favoriteSubject = value;
                    }
                    else
                    {
                        Console.WriteLine("nobody likes biology");
                    }
                }
            }
            public Student(bool _isMale, string _name, int _age, double _income, bool _isBadAtCS, double _gpa, string _favoriteSubject) : base(_isMale, _name, _age, _income, _isBadAtCS)
            {
                gpa = _gpa;
                favoriteSubject = _favoriteSubject;
            }
        }
        class Employee :Person
        {
            private double salary;
            private string position;

            public double Salary
            {
                get
                {
                    return salary;
                }
                set
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                    else
                    {
                        Console.WriteLine("no negative salaries");
                    }
                }
            }
            public string Position
            {
                get
                {
                    return position;
                }
                set
                {
                    if (value.ToString().Split().All(i => Double.IsNaN((double)int.Parse(i))))
                    {
                        position = value;
                    }
                    else
                    {
                        Console.WriteLine("what garbo has numbers in their name");
                    }
                }
            }

            public Employee(bool _isMale, string _name, int _age, double _income, bool _isBadAtCS, double _salary, string _position) : base(_isMale, _name, _age, _income, _isBadAtCS)
            {
                salary = _salary;
                position = _position;
            }
        }
        static void Main(string[] args)
        {

            Person dude_man = new Person(true, "dude man", 25, 50000, true);
            Person dude_lady = new Person(false, "dude lady", 22, 0, true);
            Person haxoor_man = new Person(true, "haxoor_man", 12, 500000000, false);

            Student poor_dude = new Student(true, "poor man", 19, 0, true, 2.5, "Math");
            Student rich_mans = new Student(true, "rich_mans", 23, 300000, true, 0.5, "Slacking off");

            Employee dis_wamen = new Employee(false, "dis wamen", 35, 70000, true, 70000, "Head of Diversity");
            Employee richard = new Employee(true, "richard", 67, 30000, true, 30000, "Sir Richard, Butler of Huthering Weights");

        }
    }
}
