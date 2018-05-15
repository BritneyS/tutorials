//tutorial-csharp-7.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Animal {
            public int Legs {get; set;}
            public int Age {get; set;}
        }
        class Dog : Animal {
            public Dog() {
                Legs = 4;
            }
            public void Bark() {
                Console.Write("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);
            
            d.Bark();
        }
    }
}

//-----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person {
            public void Speak() {
                Console.WriteLine("Hi there");
            }
        }
        class Student : Person {
            int number;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Speak();
        }
    }
}

//------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
        }
    }
}

//-----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Name = "Bob"; //error
        }
    }
}

//-----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        sealed class Animal {
            //some code
        }
        class Dog : Animal { } //Error
        
        static void Main(string[] args)
        {
            
        }
    }
}

//------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Animal {
            public Animal() {
                Console.WriteLine("Animal created");
            }
            ~Animal() {
                Console.WriteLine("Animal deleted");
            }
        }
        class Dog: Animal {
            public Dog() {
                Console.WriteLine("Dog created");
            }
            ~Dog() {
                Console.WriteLine("Dog deleted");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}

//-----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Shape {
            public virtual void Draw() {
                Console.Write("Base Draw");
            }
        }
        class Circle : Shape {
            public override void Draw() {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
        }
    }
}

//--------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        abstract class Shape {
            public abstract void Draw();
        }
        class Circle : Shape {
            public override void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
        }
    }
}

//------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        public interface IShape {
            void Draw();
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
        }
    }
}

//-------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
        }
    }
}

//------

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hi");
        }
    }
}