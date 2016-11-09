using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch s = new Stopwatch();

            int[] a=new int[100000];
            for (int i = 0,j=2; i < 100000; i++,j++)
                a[i] = j;
            
            var v = a.Where((n) => {

                Boolean test = true;
                
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n%i == 0)
                        test = false;
                }

                return test;
            
            }).Select(n => n);


            s.Start();
            foreach (var i in v) { }
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
            


            Console.ReadLine();
        }
    }
}
