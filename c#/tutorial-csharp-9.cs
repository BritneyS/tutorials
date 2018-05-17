//tutorial-csharp-9.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
        }
    }
}

//Generic class (stack/array)

class Stack<T> {
  int index=0;
  T[] innerArray = new T[100];
  public void Push(T item) {
    innerArray[index++] = item; 
  }
  public T Pop() {
    return innerArray[--index]; 
  }
  public T Get(int k) { return innerArray[k]; }
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
        class Stack<T> {
            int index=0;
            T[] innerArray = new T[100];
            public void Push(T item) {
                innerArray[index++] = item; 
            }
            public T Pop() {
                return innerArray[--index]; 
            }
            public T Get(int k) { return innerArray[k]; }
        }
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);
            
            Console.WriteLine(intStack.Get(1));
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
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Pink");
            colors.Add("Blue");
            
            foreach (var color in colors) {
                Console.WriteLine(color);
            }
        }
    }
}

/*
Collections

Commonly used generic collection types include:
Dictionary<TKey, TValue> represents a collection of key/value pairs that are organized based on the key.
List<T> represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.
Queue<T> represents a first in, first out (FIFO) collection of objects.
Stack<T> represents a last in, first out (LIFO) collection of objects.
*/