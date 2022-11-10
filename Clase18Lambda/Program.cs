using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase18Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ///Ejemplo 
            //(num1, num2) => num1 + num2; ejemplo lambda
            //n => n * n;

            List<int> list = new List<int>();
            list.Max(i => i);

            //customers.Where(c => c.City == "London");//todo los customers que tengan loondon
        }
    }
}
