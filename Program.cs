using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay2Exercise1
{
    public class MonSal
    {
        public int Salary(int wh = 0, int wd = 0, int ph = 1, int ext = 0)
        {
            return (wh * wd * 100) + (ph * 3000) + (ext * 2000);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MonSal obj = new MonSal();
            Console.WriteLine("Enter Employee Type");
            string etype= Console.ReadLine();
            switch(etype)
            {
                case "HR":
                    {
                        Console.WriteLine("Enter Working hours and Number of Working Days");
                        int wh=int.Parse(Console.ReadLine());
                        int wd=int.Parse(Console.ReadLine());
                        Console.WriteLine( $"Salary of {etype} is {obj.Salary(wh, wd)}");  
                        
                    }
                    break;

                case "Admin":
                    {
                        Console.WriteLine("Enter Working hours, Number of Working Days and Project Handles");
                        int wh = int.Parse(Console.ReadLine());
                        int wd = int.Parse(Console.ReadLine());
                        int ph = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Salary of {etype} is {obj.Salary(wh, wd, ph)}");
                    }
                    break;
                case "SDE":
                    {
                        Console.WriteLine("Enter Working hours, Number of Working Days, Project Handles and Extras");
                        int wh = int.Parse(Console.ReadLine());
                        int wd = int.Parse(Console.ReadLine());
                        int ph = int.Parse(Console.ReadLine());
                        int ext = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Salary of {etype} is {obj.Salary(wh, wd, ph, ext)}");
                    }
                    break;
                default: Console.WriteLine("Type not found");break;
            }
            Console.ReadKey();
        }
    }
}
