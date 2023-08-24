namespace InterfacesWithDefaultMethods
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            o.Insert();

            IDbFunctions oIDb;
            oIDb = o;

            oIDb.Select();  //def imp select called
        }

        static void Main()
        {
            Class1 o = new Class1();
            //o.Select();  //class1 select called -- can only be called this way if it is public

            IDbFunctions oIDb;
            oIDb = o;

            oIDb.Select(); //class1 select called
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()  //default implementation
        {
            Console.WriteLine("default implementation of select");
        }

    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("class1 display");
        }
        public void Delete()
        {
            Console.WriteLine("class1 Idbfunctions delete");
        }
        public void Insert()
        {
            Console.WriteLine("class1 Idbfunctions insert");
        }
        public void Update()
        {
            Console.WriteLine("class1 Idbfunctions update");
        }
        //public void Select()  //implement Select()
        //{
        //    Console.WriteLine("class1 Idbfunctions select");
        //}
        void IDbFunctions.Select()  //implement Select() EXPLICITLY
        {
            Console.WriteLine("class1 Idbfunctions select - EXPLICITLY");
        }
    }

}