using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class SimpleGeniric<T>
    {
        private T[] values; // T 타입의 배열
        private int index;

        public SimpleGeniric(int len)
        {
            // Constructor
            values = new T[len]; // 배열길이 선언
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (T item in args)
            {
                values[index++] = item;
            }
        }
        
        public void Print()
        {
            foreach (T item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeniric<Int32> ginteger = new SimpleGeniric<int>(10);
            SimpleGeniric<Double> gDouble = new SimpleGeniric<double>(10);

            ginteger.Add(1, 2);
            ginteger.Add(1, 2, 3, 4, 5, 6, 7);
            ginteger.Add(10);

            gDouble.Add(10.0, 12.4, 37.5);
            ginteger.Print();
            gDouble.Print();
        }
    }
}
