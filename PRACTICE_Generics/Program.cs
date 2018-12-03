using System;
using System.Collections.Generic;

namespace PRACTICE_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RandomObjects<object>> MyRandomList = new List<RandomObjects<object>>()
            {
                new RandomObjects<object>(),
                new RandomObjects<object>(5),
                new RandomObjects<object>(true)
            };
            
            Console.ReadLine();
        }
    } 

    class RandomObjects<T>
    {
        public T obj { get; set; }

        public RandomObjects()
        {

        }

        public RandomObjects(T _obj)
        {
            this.obj = _obj;

            Console.WriteLine(this.obj);
        }
    }
}
