namespace Lab5Charp
{
    using System;

    /* 

    Початок Першого та Другого завдання

    */

    class Person
    {
        protected string Name;
        protected int age;
        protected int Salary;

        public Person()
        {
            this.Name = "NoNe";
            this.age = 0;
            this.Salary = 0;
            Console.WriteLine("Create Person!");
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
            this.Salary = 0;
            Console.WriteLine("Create Person!");
        }
        public Person(string name, int age, int salary)
        {
            this.Name = name;
            this.age = age;
            this.Salary = salary;
            Console.WriteLine("Create Person!");
        }

        ~Person()
        {
            Console.WriteLine("Delete Person!");
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + this.Name + ", Age: " + this.Age + ", Salary: " + this.Salary);
        }

        public int Age
        {
            get { return age; }
        }
    }

    class Student : Person
    {
        private string Faculty;

        public Student(string name, int age) : base(name, age, 0)
        {
            this.Faculty = "NoNe";
            Console.WriteLine("Create Student!");
        }
        public Student(string name, int age, int salary) : base(name, age, salary)
        {
            this.Faculty = "NoNe";
            Console.WriteLine("Create Student!");
        }
        public Student(string name, int age, int salary, string faculty) : base(name, age, salary)
        {
            this.Faculty = faculty;
            Console.WriteLine("Create Student!");
        }
        ~Student()
        {
            Console.WriteLine("Delete Student!");
        }

        public override void Show()
        {
            Console.WriteLine("Student: " + this.Name + ", Age: " + this.Age + ", Faculty: " + this.Faculty);
        }
    }

    class Teacher : Person
    {
        protected string Subject;
        protected int Experience;

        public Teacher(string name, int age, int salary) : base(name, age, salary)
        {
            this.Subject = "NoNe";
            this.Experience = -1;
            Console.WriteLine("Create Teacher!");
        }

        public Teacher(string name, int age, int salary, string subject) : base(name, age, salary)
        {
            this.Subject = subject;
            this.Experience = -1;
            Console.WriteLine("Create Teacher!");
        }
        public Teacher(string name, int age, int salary, string subject, int experience) : base(name, age, salary)
        {
            this.Subject = subject;
            this.Experience = experience;
            Console.WriteLine("Create Teacher!");
        }
        ~Teacher()
        {
            Console.WriteLine("Delete Teacher!");
        }
        public override void Show()
        {
            Console.WriteLine("Teacher: " + this.Name + ", Age: " + this.Age + ", Subject: " + this.Subject + ", Experience: " + this.Experience + " years, Salary: " + this.Salary);
        }
    }

    class HeadOfDepartment : Teacher
    {
        private string Department;
        public HeadOfDepartment(string name, int age, int salary, string subject, int experience) : base(name, age, salary, subject, experience)
        {
            this.Department = "NoNe";
        }
        public HeadOfDepartment(string name, int age, int salary, string subject, int experience, string department) : base(name, age, salary, subject, experience)
        {
            this.Department = department;
        }
        ~HeadOfDepartment()
        {
            Console.WriteLine("Delete HeadOfDepartment!");
        }

        public override void Show()
        {
            Console.WriteLine("Head of Department: " + this.Name + ", Age: " + this.Age + ", Subject: " + this.Subject + ", Experience: " + this.Experience + " years, Department: " + this.Department + ", Salary: " + this.Salary);
        }
    }

    /* 

    Кінець Першого та Другого завдання

    */

    /*
    Початок Третього 
    */

    abstract class Figure
    {
        abstract public void Show();
        abstract public double Perimeter();

        abstract public double Area();
    }

    class Rectangle : Figure
    {
        protected double width;
        protected double height;

        public Rectangle(double width , double height){
            this.width = width;
            this.height = height;
        }

        public override double Perimeter()
        {
            return 2 * this.width + 2 * this.height;
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public override void Show()
        {
            Console.WriteLine("\nWidth:" + this.width + "\nHeight:" + this.height + "\nPerimeter:" + this.Perimeter() + "\nArea:" + this.Area());
        }

    }

    class Circle : Figure
    {

        protected double radius;

        public Circle(double radius){
            this.radius = radius;
        }


        public override double Perimeter()
        {
            return this.radius * 2 * Math.PI;
        }
        public override double Area()
        {
            return this.radius * this.radius * Math.PI;
        }
        public override void Show()
        {
            Console.WriteLine("Radius:" + this.radius + "\nPerimetr:" + this.Perimeter() + "\nArea:" + this.Area());
        }
    }

    class Triangle : Figure
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;

        public Triangle(double sideA,double sideB,double sideC){
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Perimeter()
        {
            return this.sideA+this.sideB+this.sideC;
        }
        public override double Area()
        {
            double s = this.Perimeter();
            return Math.Sqrt((s-this.sideA)*(s-this.sideB)*(s-this.sideC));
        }
        public override void Show()
        {
            Console.WriteLine("Side A:"+this.sideA+"\nSide B:"+this.sideB+"\nSide C:"+this.sideC+"\nPerimetr:"+this.Perimeter()+"\nArea:"+this.Area());
        }
    }


    /*
    Кінець третього
    */
    internal class Program
    {

        static void Main(string[] args)
        {
            void task1()
            {
                Person[] people = new Person[]{
                    new Student("Andrey", 19, 45000 ,"FMI"),
                    new Student("Max Vershtapen",19),
                    new Student("Maria", 22, 2000),
                    new Teacher("Petro", 45, 25000, "Mathematics", 20),
                    new Teacher("Grey",40,40000),
                    new Teacher("Yora",32,15000,"Library Python", 5),
                    new Teacher("Olena", 38, 27000, "Programming", 15),
                    new HeadOfDepartment("Serhiy", 50, 35000, "Computer Science", 25, "IT Department")
                };

                Console.WriteLine("Data before sorting:");

                foreach (var person in people)
                {
                    person.Show();
                }

                for (int i = 0; i < people.Length - 1; i++)
                {
                    for (int j = 0; j < people.Length - i - 1; j++)
                    {
                        if (people[j].Age > people[j + 1].Age)
                        {
                            Person temp = people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("\nData after sorting by age:");
                foreach (var person in people)
                {
                    person.Show();
                }

            }
            void task2()
            {
                Figure[] figures = new Figure[]
        {
            new Rectangle(4, 5),
            new Circle(3),
            new Triangle(3, 4, 5)
        };

        foreach (var figure in figures)
        {
            figure.Show();
            Console.WriteLine();
        }

            }
            void choose_task()
            {
                Console.Write("1.Persons\n2.Figures\n");
                int answer = Convert.ToInt16(System.Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        {
                            task1();
                            Console.Write("\n\n\n");
                            choose_task();
                            break;
                        }
                    case 2:
                        {
                            task2();
                            Console.Write("\n\n\n");
                            choose_task();
                            break;
                        }
                    case 3:
                    {
                        break;
                    }
                    default:
                        {
                            choose_task();
                            break;
                        }
                }
            }
            choose_task();


        }

    }
}