//tutorial-csharp-5.cs

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
            int[ ] b = {11, 45, 62, 70, 88};

            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);
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
            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(a[k]);
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
            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            foreach (int k in a) {
                Console.WriteLine(k);
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
            int[ ] arr = {11, 35, 62, 555, 989};
            int sum = 0; 
            
            foreach (int x in arr) {
                sum += x;
                Console.WriteLine(x);
            }
            Console.WriteLine(sum);
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
            int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; 
            for (int k = 0; k < 3; k++) { //rows
                for (int j = 0; j < 2; j++) { //columns
                    Console.Write(someNums[k, j]+" ");
                }
                Console.WriteLine();
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
            int[ ][ ] jaggedArr = new int[ ][ ] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int x = jaggedArr[2][1];
            Console.WriteLine(x);
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
            int[ ] arr = {2, 4, 7};
            
            Console.WriteLine(arr.Length); 
            
            Console.WriteLine(arr.Rank); 
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
            int[ ] arr = {2, 4, 7};
            for(int k=0; k<arr.Length; k++) {
                Console.WriteLine(arr[k]);
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
            int[ ] arr = { 2, 4, 7, 1};
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
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
        static void Main(string[] args)
        {
            string a = "some text";
            Console.WriteLine(a.Length);
            //Outputs 9

            Console.WriteLine(a.IndexOf('t'));
            //Outputs 5

             a = a.Insert(0, "This is ");
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);
            //Outputs "I am some text"

            if(a.Contains("some"))
                Console.WriteLine("found");
            //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a);
            //Outputs "am"
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
            string a = "some text";
            Console.WriteLine(a[2]);
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
            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".")+1);
            
            Console.WriteLine(text);
        }
    }
}







