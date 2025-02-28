using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Services;

namespace ConsoleApp1
{
    [AddMetaData("test")]
    internal class Program
    {
        //[WebMethod]

        [Obsolete("This method will get permanently deleted on 5th feb 2025")]
        public static void Add(int a, int b)
        {
            Console.WriteLine("The result is " + (a + b));
        }
        [AddMetaData("This is a new method")]
        public static int Add(int[] number)
        {
            int r = 0;
            foreach (int i in number)
            {
                r += i;
            }
            Console.WriteLine("The result is " + r);

            return r;
        }

        static void Main(string[] args)
        {
            //Add(20, 4);
            //Add(new int[] { 4, 5, 6 });

            //Employee employee = new Employee(); //compile time
            //employee.PrintEmployee();

            //Reflection - to inspect the library at run time and grab all the details from it
            //int i = 42;
            //Type type=i.GetType();
            //Console.WriteLine(type.FullName);


            //Let's say we want to fetch all the properties, methods, and constructor of a employee

            //Below is to print the metadata of any class or assembly providing the absolute 
            //String path = @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll";
            //Assembly assembly = Assembly.LoadFile(path);

            //Assembly assembly = Assembly.LoadFile(Assembly.GetExecutingAssembly().Location);

            //Type[] types= assembly.GetTypes();
            //Type type1 = Type.GetType("ConsoleApp1.Employee");

            //foreach (Type type1 in types)
            //{
            //    if (type1 != null)
            //    {
            //        Console.WriteLine(type1.FullName);
            //        Console.WriteLine(type1.Name);
            //        GetMethods(type1);
            //        Console.WriteLine("***************Properties**************");
            //        GetProperties(type1);
            //        Console.WriteLine("***************Constructors**************");
            //        GetConstructors(type1);
            //    }
            //}

            Type type1 = Type.GetType("ConsoleApp1.Employee");
            if (type1 != null)
            {
                MethodInfo mi = type1.GetMethod("PrintEmployee");
                if (mi != null)
                {
                    //Employee emp=new Employee() //this was at compile time
                    Object typeins=Activator.CreateInstance(type1);

                    Object[] param=new object[2];
                    param[0] = "Preeti";
                    param[1] = 23;
                    //emp.printemployee(name, age);
                    mi.Invoke(typeins, param);

                    //emp.printemployee();
                    //mi.Invoke(typeins, null);
                }
            }


        }
        public static void GetMethods(Type type)
        {
           MethodInfo[] mi= type.GetMethods();
            foreach (MethodInfo mi2 in mi)
            {
                Console.WriteLine($"Method name : {mi2.Name} Return Type : {mi2.ReturnType}");
            }
        }
        public static void GetProperties(Type type)
        {
            PropertyInfo[] mi = type.GetProperties();
            foreach (PropertyInfo mi2 in mi)
            {
                Console.WriteLine($"Method name : {mi2.Name} Return Type : {mi2.PropertyType}");
            }
        }
        public static void GetConstructors(Type type)
        {
            ConstructorInfo[] mi = type.GetConstructors();
            foreach (ConstructorInfo mi2 in mi)
            {
                Console.WriteLine($"Method name : {mi2.Name} Return Type : {mi2.IsPublic}");
            }
        }
    }
}
