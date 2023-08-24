namespace InheritanceExamples2
{
    internal class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            o.Display1();
            o.Display1("vik");

            o.Display2();
            o.Display3();
        }

        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            //o.Display2(); //non virtual - will depend on how the reference is declared
            o.Display3();  //virtual - will depend on how memory is allocated

            Console.WriteLine();

            o = new DerivedClass();
            //o.Display2(); //non virtual - will depend on how the reference is declared
            o.Display3();  //virtual - will depend on how memory is allocated


            Console.WriteLine();
            o = new SubDerivedClass();
            //o.Display2(); //non virtual - will depend on how the reference is declared
            o.Display3();  //virtual - will depend on how memory is allocated

            Console.WriteLine();
            o = new SubSubDerivedClass();
            //o.Display2(); //non virtual - will depend on how the reference is declared
            o.Display3();  //virtual - will depend on how memory is allocated


        }

    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }
    }

    public class DerivedClass : BaseClass
    {
        //overload the base class method
        public void Display1(string s)
        {
            Console.WriteLine("derived display1" + s);
        }

        //hide the base class method
        public new void Display2()
        {
            Console.WriteLine("derived display2");
        }
        //override the base class method
        public override void Display3()
        {
            Console.WriteLine("derived display3");
        }

    }
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subderived display3");
        }

    }

    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("subsubderived display3");
        }

    }
}
