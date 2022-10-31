using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    public class add : calc
    {
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition of two numbers");
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}
