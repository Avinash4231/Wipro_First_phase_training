class MemoryExample
    {
         public static void Main(string[] args)
         {
        
            Password a=new Password("Password123");
            a.setPassword("345");
            Console.WriteLine(a.getPassword());
         }
    }
    public class Password
    {
        private readonly string P;
        public Password(string pass)
        {
           P=pass;
        }
        public string getPassword()
        {
           return P;
        }
        public void setPassword(string newpass)
        {
          Console.WriteLine("Password cannot be modified..");
          
        }
    }