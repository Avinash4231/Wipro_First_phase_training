using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public class IndexerExample
    {
        public static void run()
        {
            Employee e = new Employee(101, "Niti", "Trainer");
            //Console.WriteLine(e[2]);
            //e[2] = "preeti";
            //Console.WriteLine("After resetting the value");
            //Console.WriteLine(e[2]);

            e["Name"] = "kriti";
            e["Job"] = "Corporate Trainer";

            Console.WriteLine("After resetting the value");
            //Console.WriteLine(e[1]);
            //Console.WriteLine(e[2]);
            Console.WriteLine(e["Name"]);
            Console.WriteLine(e["Job"]);


        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public Employee(int id, string name, string job) {
            Id = id;
            Name = name;
            Job = job;
        }
        public Object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Id;
                }
                else if (index == 1)
                {
                    return Name;
                }
                else if (index == 2)
                {
                    return Job;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    Id = Convert.ToInt32(value);
                }
                else if (index == 1)
                {
                    Name = value.ToString();
                }
                else if (index == 2)
                {
                    Job = value.ToString();
                }
            }
        }

        //for string type
        public Object this[string name]
        {
            get
            {
                if (name.ToUpper() == "NAME")
                {
                    return Name;
                }
                else if (name.ToUpper() == "JOB")
                {
                    return Job;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (name.ToUpper() == "NAME")
                {
                    Name = value.ToString();
                }
                else if (name.ToUpper() == "JOB")
                {
                    Job = value.ToString();
                }
            }
        }
    }
}
