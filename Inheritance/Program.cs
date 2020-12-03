using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifiersInInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            // obj also contain all members of Object class



        }
    }
    public class ParentClass
    {
        public int a;
    }
    public class DerivedClass : ParentClass
    {
        public int b;
    }

    // second Example===============================================================

    public class ParentClass2
    {
        public int i;
        private int j;
        protected int k;
        internal int l;
        protected internal int m;

    }
    public class DerivedClass2 : ParentClass2
    {
        void DoNothing()
        {
            this.i++;
            //this.j++; private not allowed
            this.k++;
            this.l++;//in same assebbly
            this.m++;
        }
    }
    public class DerivedClass3 : AccessSpecifiers.ParentClass {

        void DoNothing()
        {
            this.i++;
            this.k++;
            //this.j++;
            //this.l++; not in same assembly
            this.m++;


        }


        }
}
