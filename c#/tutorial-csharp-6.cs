//tutorial-csharp-6.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Dog
        {
            public Dog() {
                Console.WriteLine("Constructor");
            }
            ~Dog() {
                Console.WriteLine("Destructor");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}

//----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Cat {
            public static int count=0;
            public Cat() {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
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
        class Dog
        {
            public static void Bark() {
                Console.WriteLine("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog.Bark();
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
        class MathClass {
            public const int ONE = 1;
        }
        static void Main(string[] args)
        {
            Console.Write(MathClass.ONE);
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
            Console.WriteLine(Math.Pow(2, 3));
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
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            
            Console.WriteLine(DateTime.DaysInMonth(2016, 2));
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
        static void Main(string[] args)
        {
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);
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
        class Clients {
            private string[] names = new string[10];
            public string this[int index] {
                get {
                    return names[index];
                }
                set {
                    names[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            
            Console.WriteLine(c[1]);
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
        class Box {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w) {
                Height = h;
                Width = w;
            }
            public static Box operator+(Box a, Box b) {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
            }
        }
        static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;
            
            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);
        }
    }
}





