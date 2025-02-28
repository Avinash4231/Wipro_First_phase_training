using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{


    public class OddNumberException : Exception
    {

        public override string Message
        {
            get
            {
                return " Divisor cannot be an ODD Number";

            }


        }

        public override string HelpLink
        {
            get
            {
                return "get some info from https://github.com";

            }
        }

        public class AgeNotFound : Exception
        {

            public override string Message
            {
                get
                {
                    return " Age should be greater than 18";

                }


            }

            public override string HelpLink
            {
                get
                {
                    return "go through the official document regarding age  https://github.com";

                }
            }




        }
        internal class ExceptionHandling
        {
            public static void run()
            {

                /* try
                  {
                      Console.WriteLine("Enter First number :");
                      int a = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Enter Second number :");
                      int b = Convert.ToInt32(Console.ReadLine()); ;

                         Console.WriteLine("Enter your Age :");
                         int age = Convert.ToInt32(Console.ReadLine()); ;

                         int result;


                      Console.WriteLine("A vaule is :" + a);
                      Console.WriteLine("B vaule is :" + b);

                     if(a<0)
                     {
                         throw new DivideByZeroException();
                         Console.WriteLine("Second no you entered cannot be zero");
                     }

                      result = a / b;
                      Console.WriteLine("The result is : " + result);


                  }

                  catch (DivideByZeroException ex)
                  {
                      Console.WriteLine("The exception has occured :" + ex.Message);
                  }
                  catch (FormatException ex1)
                  {

                      Console.WriteLine("Enter only Integer number :");


                  }

                  finally 
                  {

                      Console.WriteLine("it's over :" );

                      // used when you want to close the resouces

                  }


                  Console.ReadKey();*/


                /*Custom defined exception  Agenotfound , oddnumberexception , patternmatching ,  */

                try
                {
                    Console.WriteLine("Enter First number :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number :");
                    int b = Convert.ToInt32(Console.ReadLine()); ;

                    Console.WriteLine("Enter You age in numbers :");
                    int age = Convert.ToInt32(Console.ReadLine()); ;
                    int result;


                    Console.WriteLine("A vaule is :" + a);
                    Console.WriteLine("B vaule is :" + b);

                    if (b % 2 > 0)
                    {

                        throw new OddNumberException();


                    }
                    result = a / b;
                    Console.WriteLine(result);

                    if (age < 18)
                    {
                        throw new AgeNotFound();
                    }

                }

                catch (OddNumberException o)
                {

                    Console.WriteLine("Message is  : " + o.Message);
                    Console.WriteLine("HelpLink :" + o.HelpLink);

                }
                catch (AgeNotFound a)
                {

                    Console.WriteLine("Message is  : " + a.Message);
                    Console.WriteLine("HelpLink :" + a.HelpLink);

                }



            }
        }

    }
}