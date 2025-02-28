using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewFunctionalities
{



    interface FulltimeEmployee
    {

        public void show()
        {
            Console.WriteLine("Full time show method :");
        }
    }

    //Base class
    public class Bonus
    {

        public virtual void diwalibonus()
        {
            Console.WriteLine("Diwali Bonus  :");
        }


    }
    // child class inheriting  Bonus clas
    public class ParttimeEmployee : Bonus, FulltimeEmployee
    {
        // Method overriding
        public void show()
        {
            Console.WriteLine("Part time show method :");
        }

        public override void diwalibonus()
        {
            Console.WriteLine("Diwali Bonus  :" + 1000);
        }
    }


    // Multilevel
    //child class it is also inheriting parttime employee (super class)
    public class InheritanceExample : ParttimeEmployee
    {

        public void show(int a)
        {
            Console.WriteLine("Main class show method :");
        }




        public static void run()
        {

            InheritanceExample example = new InheritanceExample();

            example.show();
            example.show(10);
            example.diwalibonus();


        }
    }
}
