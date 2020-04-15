using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment3
{
    class MyconstraintGenericClass<T> where T : class
    {
        private T value;

        MyconstraintGenericClass()
        {
            Console.WriteLine("MyconstraintGenericClass");
        }
        public void Set(T value)
        {
            this.value = value;
        }
        public T Get()
        {
            return value;
        }
    }
}
