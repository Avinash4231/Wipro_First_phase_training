using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class MoreExample
    {
        public static void run()
        {
            //    Console.WriteLine(calculateaddition(20, 12));
            //    Console.WriteLine(calculatesubtraction(20, 12));

            WeekDays weekDays = WeekDays.Sunday;
            Console.WriteLine(GetyourDay(weekDays));
        }
        /*static int calculateaddition(int a, int b)
        {
            return a+b;
        }
        static int calculatesubtraction(int a, int b)
        {
            return a - b;
        }*/
        static int calculateaddition(int a, int b)
        {
            int Add() => a + b;
            return Add();
        }
        static int calculatesubtraction(int a, int b)
        {
            int subNumbers(int x, int y)
            {
                if (x > y && x>0 && y > 0)
                {
                    return x - y;
                }else if (y > x)
                {
                    return y - x;
                }
                return 0;
            }

            // Call the local function inside the method
            return subNumbers(a, b);
        }
        //compile time null safety
        static string GetyouLuck(int day) => day switch
        {
            1 => "Good Luck",
            2 => "Bad Luck",
            _ => "can't exit"
        };
        static string GetyourDay(WeekDays day) => day switch
        {
            WeekDays.Monday => "Good Luck",
            WeekDays.Tuesday => "Good luck",
            WeekDays.Wednesday => "",
            WeekDays.Thursday => "",
            WeekDays.Friday => "",
            WeekDays.Saturday => "",

        };

        static string GetBooleanValue(bool flag) => flag switch
        {
            true => "YES"
        };

    }
    enum WeekDays
    {
        Monday,Tuesday, Wednesday,Thursday, Friday,Saturday, Sunday
    }
}
