using NewFunctionalities;

namespace SealedClassExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //OldService tmp = new OldService();
            //tmp.Test1();
            //tmp.Test2();
            //tmp.Test3();
            //tmp.Test4(100);

            //string word = "C# is a powerful language";

            // int wordcount = word.GetWordCouted();
            //Console.WriteLine(wordcount);

            //string s = "03-feb-2025";
            //DateTime date;

            //if(DateTime.TryParse(s, out date))
            //{
            //    Console.WriteLine(date);
            //}
            //Console.WriteLine("It's done");

            //Circle c = new Circle(10);
            //DisplayArea(c);
            //Rectangle re = new Rectangle(20, 30);
            //DisplayArea(re);

            //IndexerExample.run();
            //MoreExample.run();
            //DelegateExample.run();
            InheritanceExample.run();

        }
        public static void DisplayArea(Shape shape)
        {
            /* if (shape is Circle c) // it is new version where we intialize circle to c variable
             {
                 //Circle c = (Circle)shape;  //it is older version. it is casting

                 Console.WriteLine("Area of Circle is " + c.Radius * c.Radius);
             }
             if (shape is Rectangle)
             {
                 Rectangle r = (Rectangle)shape;

                 Console.WriteLine("Area of Rectangle is " + r.Length * r.Breadth);
             }*/
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine("Area of Circle is " + c.Radius * c.Radius);
                    break;
                case Rectangle r when r.Length==r.Breadth:
                    Console.WriteLine("Area of square is " + r.Length * r.Breadth);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is " + r.Length * r.Breadth);
                    break;
                case null:
                    Console.WriteLine("It's null.");
                    break;
                default:
                    Console.WriteLine("Unknown type.");
                    break;
            }


            }
        }
}