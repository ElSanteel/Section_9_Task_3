using System;
namespace program;
public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Print()
    {
        System.Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
//--------------------------------------------------------
public class Student : Person
{
    public int Year;
    public float GPA;
    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Year = year;
        GPA = gpa;
    }
    public override void Print()
    {
        Console.WriteLine
            ($"Name: {Name}, Age: {Age}, Gpa: {GPA}");
    }
}
// --------------------------------------------------------
public class Staff : Person
{
    public double Salary;
    public int JoinYear;

    public Staff(string name, int age, double Asalary, int Ajoinyear) : base(name, age)
    {
        Salary = Asalary;
        JoinYear = Ajoinyear;
    }

    public override void Print()
    {
        Console.WriteLine($"My name is {Name}, my age is {Age}, and my salary is {Salary}");
    }
}
// --------------------------------------------------------
public class Database
{
    private int _currIndex;
    public Person[] People = new Person[50];
    public void AddStudent(Student student)
    {
        People[_currIndex++] = student;
    }
    public void AddStaff(Staff staff)
    {
        People[_currIndex++] = staff;
    }
    public void AddPerson(Person person)
    {
        People[_currIndex++] = person;
    }
    public void PrintAll()
    {
        for (var i = 0; i <= _currIndex; i++)
        {
            People[i].Print();
        }

    }

}
public class Program
{
    public static void Main()
    {
        var database = new Database();
        while (true)
        {
            Console.WriteLine("Choose one of the following: (1) Student (2) Staff (3) Person (4) Print ALL People");
            var op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Age: ");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Year: ");
                var year = Convert.ToInt32(Console.ReadLine());
                Console.Write("gpa: ");
                var gpa = Convert.ToSingle(Console.ReadLine());
                var student = new Student(name, age, year, gpa);
                database.AddStudent(student);
            }
            else if (op == 2)
            {
                Console.Write("Name of the employee: ");
                var name_2 = Console.ReadLine();
                Console.Write("Age of the employee: ");
                var age_2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salary of the employee: ");
                var salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("JoinYear of the employee: ");
                var joinYear = Convert.ToInt32(Console.ReadLine());
                var staff = new Staff(name_2, age_2, salary, joinYear);
                database.AddStaff(staff);
            }
            else if (op == 3)
            {
                Console.Write("Name of the person: ");
                var name_3 = Console.ReadLine();
                Console.Write("Age of the person: ");
                var age_3 = Convert.ToInt32(Console.ReadLine());
                var person = new Person(name_3, age_3);
                database.AddPerson(person);
            }
            else if (op == 4)
            {
                database.PrintAll();
            }
            else
            {
                return;
            }
        }
    }
}
