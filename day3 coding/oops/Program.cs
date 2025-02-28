public class Program
{
   static int c;
  public static void input(int a,int b){
    c=a+b;
    Console.WriteLine(c);
  }
  public static void Main(string[] args){
    Program.input(20,30);
    Console.WriteLine(Program.c);
  }
}