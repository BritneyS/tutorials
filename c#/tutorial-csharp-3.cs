//tutorial-csharp-3.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void sayHi()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            sayHi();
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
        static void SayHi()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            SayHi();
            SayHi();
            SayHi();
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
        static void Print(int x) 
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Print(42);
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
        static void Func(int x)
        {
            Console.WriteLine(x*2);
        }
        static void Main(string[] args)
        {
            Func(5);
  
            Func(12);

            Func(42);
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
        static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(8, 6));
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
        static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int res = Sum(11, 42);
            Console.WriteLine(res);
        }
    }
}

//---------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static int Pow(int x, int y=2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(6));

            Console.WriteLine(Pow(3, 4));
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
        static int Area(int h, int w)
        {
            return h * w;
        }
        static void Main(string[] args)
        {
            int res = Area(w: 5, h: 8);
            Console.WriteLine(res);
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
        static void Sqr(int x)
        {
            x = x * x;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            
            Console.WriteLine(a);
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
        static void Sqr(ref int x)
        {
            x = x * x;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(ref a);
            
            Console.WriteLine(a);
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
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            Console.WriteLine(a+" "+b);
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
        static void Print(int a) {
            Console.WriteLine("Value: " + a);
        }
        static void Print(double a) {
            Console.WriteLine("Value: " + a);
        }
        static void Print(string label, double a) {
            Console.WriteLine(label + a);
        }
        static void Main(string[] args)
        {
            Print(11);
            Print(4.13);
            Print("Average: ", 7.57);
        }
    }
}

//----------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static int Fact(int num) {
            if (num == 1) {
                return 1;
            }
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(6));
        }
    }
}

//----------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
  class Program
  {
    static void DrawPyramid(int n)
    {
      for (int i=1; i<=n; i++)
      {
        for (int j=i; j<=n; j++)
        {
          Console.Write("  ");
        }
        for (int k=1; k<=2*i-1; k++)
        {
          Console.Write("*"+" ");
        }
        Console.WriteLine();
      }
    }
    static void Main(string[] args)
    {
      DrawPyramid(5);
    }
  }
}








