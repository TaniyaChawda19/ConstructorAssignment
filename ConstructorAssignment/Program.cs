using System.Globalization;

namespace ConstructorAssignment
{

    class Person
    {
        string fname;
        string lname;
        string email;
        DateTime dob;

         public Person(string fname,string lname,string email,DateTime dob)
        {
            this.fname = fname; 
            this.lname = lname; 
            this.email = email;
            this.dob = dob;
        }

        public void show()
        {
            Console.WriteLine("First name : " + fname);
            Console.WriteLine("Last name : "+ lname);
            Console.WriteLine("Email : "+email);
            Console.WriteLine("Date of Birth : " + dob);
        }
    }
    internal class Question1
    {
        static void Main(string[] args)
        {
            var ob = new Person("Taniya", "Chawda", "chawda@gmail.com", new DateTime(2008,04,12));
            ob.show();
        }
    }

    class Building
    {
        string type;
        string capacity;
        string dimension;
        string dateofcompletion;
        

        public Building(string type,string capacity,string dimension,string dateofcompletion)
        {
            this.type = type;
            this.capacity = capacity;  
            this.dimension = dimension;
                this.dateofcompletion = dateofcompletion; 

        }


        public void show()
        {
            if(type=="villa" && dimension.Contains('X')==false)
            {
                Console.WriteLine("Provide Correct Input");
            }
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Capacity : " + capacity);
            Console.WriteLine("Dimension : " + dimension);
            Console.WriteLine("Date of Completion : " + dateofcompletion);
            Console.WriteLine(" ");
        }
    }

    public class ques2
    {
        static void Main(string[] args)
        {
            var ob = new Building("flat", "3BHK", "2", "12/12/12");
            var ob1 = new Building("villa", "2BHK", "40X30", "1/1/2001");
            ob.show();
            ob1.show();

        }
    }



    class Shapes
    {
        public double Area(double r)
        {
            return 3.14 * r * r;
        }
        public int Area(int a, int b)
        {
            return a * b;
        }

        public int Area(int a)
        {
            return a * a;
        }
        public double Area(int a, int b, int c)
        {
            var sp = (a + b + c) / 2;
            return (double)(Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c)));
        }
    }

    class ques3
    {
        static void Main(string[] args)
        {
            var ob = new Shapes();
            Console.WriteLine("Area of circle with radius 2.5 : " + ob.Area(2.5));
            Console.WriteLine("Area of Square with side 3 : " + ob.Area(3));
            Console.WriteLine("Area of Rectangle with lenght=10 and breadth=15: " + ob.Area(10, 15));
            Console.WriteLine("Area of triangle with sides 3,4 and 5 : " + ob.Area(3, 4, 5));

        }
    }
}