//tutorial-csharp-2.cs

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
            int x = 8;
            int y = 3;
            
            if (x > y)
            { 
                Console.WriteLine("x is greater than y");
            }
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
        static void Main(string[] args)
        {
            int a=7, b=7;
            if (a == b) {
                Console.WriteLine("Equal");
            }
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
            int mark = 85;
            
            if (mark < 50) 
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("You passed.");
            }
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
        static void Main(string[] args)
        {
            int mark = 100;
            
            if (mark >= 50) {
                Console.WriteLine("You passed.");
                if (mark == 100) {
                    Console.WriteLine("Perfect!");
                }
            }
            else {
                Console.WriteLine("You failed.");
            }
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
            int age = 17;
            if (age > 14) {
                if(age > 18) {
                    Console.WriteLine("Adult");
                }
                else {
                    Console.WriteLine("Teenager");
                }
            }
            else {
                if (age > 0) {
                    Console.WriteLine("Child");
                }
                else {
                    Console.WriteLine("Something's wrong");
                }
            }
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
            int x = 33;
            
            if (x == 8) {
                Console.WriteLine("Value of x is 8");
            }
            else if (x == 18) {
                Console.WriteLine("Value of x is 18");
            }
            else if (x == 33) {
                Console.WriteLine("Value of x is 33");
            }
            else {
                Console.WriteLine("No match");
            }
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
            int num = 3;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }
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
            int age = 88;
            switch (age) {
                case 16:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }
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
            int num = 1;
            while(num < 6) 
            {
                Console.WriteLine(num);
                num++;
            }
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
            int num = 1;
            while(num < 6) 
            {
                Console.WriteLine(num);
                num+=2;
            }
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
        static void Main(string[] args)
        {
            int num = 0;
            while(++num < 6) 
                Console.WriteLine(num);
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
            for (int x = 10; x < 15; x++)
            {
                Console.WriteLine("Value of x: {0}", x);
            }
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
            for (int x = 0; x < 10; x+=3)
            {
                Console.WriteLine(x);
            }
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
            for (int x = 10; x > 0; x-=2)
            {
                Console.WriteLine(x);
            }
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
            int x = 10;
            for ( ; x > 0; x -= 3)
            {
                Console.WriteLine(x);
            }
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
            int x = 10;
            for ( ; x > 0 ; )
            {
                Console.WriteLine(x);
                x -= 3;
            }
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
        static void Main(string[] args)
        {
            int a = 0;
            do {
                Console.WriteLine(a);
                a++;
            } while(a < 5);
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
            int x = 42;
            do {
                Console.WriteLine(x);
                x++;
            } while(x < 10);
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
            int num = 0;
            while (num < 20)
            {
                if (num == 5)
                    break;

                Console.WriteLine(num);
                num++;
            }
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
            for (int i = 0; i < 10; i++) {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
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
        static void Main(string[] args)
        {
            int age = 42;
            double money = 540;
            if(age > 18 && money > 100) {
                Console.WriteLine("Welcome");
            }
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
            int age = 42;
            int grade = 75;
            if(age > 16 && age < 80 && grade > 50) 
                Console.WriteLine("Hey there");
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
            int age = 18;
            int score = 85;
            if (age > 20 || score > 50) {
                Console.WriteLine("Welcome");
            }
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
        static void Main(string[] args)
        {
            int age = 8;
            if ( !(age > 16) ) {
                Console.Write("Your age is less than 16");
            }
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
            int age = 42;
            string msg;
            if(age >= 18)
                msg = "Welcome";
            else
                msg = "Sorry";

            Console.WriteLine(msg);
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
            int age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome" : "Sorry";
            Console.WriteLine(msg);
        }
    }
}















