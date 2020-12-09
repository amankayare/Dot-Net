using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //i = null; // not allowed becoz 'i' is value type
            int? j = 10;// ? make it nullable -> C# syntax | internally compiler converts it into Nullable<int> i = 10; here Nullable is Class 
            j = null; // null is allowed now -> memmory to nullable is allocated t HEaP

            int k = 0;
            k = (int)i;
            Console.WriteLine(k);

            Console.WriteLine(j);
            Console.ReadLine();

            int o = 0;
            if (j != null)
                o = (int)j;
            else
                j = 0;


            if (j.HasValue)
                o = j.Value;
            else
                o = 0;

            o = j.GetValueOrDefault(); //if j is null then o = 0 otherwise o = value of j
            o = j.GetValueOrDefault(10); // if j is null then o = 10 otherwise o = value of j
            o = j ?? 10; // null coalescing operator -> if j is null then o = 10 otherwise o = value of j

            // Generally nullable type is used with database nullable field
        }
    }
}
