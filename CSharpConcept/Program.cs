using CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] colors1 = { "red", "green", "yellow","blue" };

            //Console.WriteLine(colors1.Length);

            //i++ or ++i --> i=i+1
            //for (int i=0;i<colors1.Length;i++)
            //{
            //    Console.WriteLine(colors1[i]);
            //}


            //foreach(string color in colors1)
            //{
            //    Console.WriteLine(color);
            //}

            //int[] numbers1 = { 45, 10, 55 };

            //foreach(int x in numbers1)
            //{
            //    Console.WriteLine(x);
            //}

            for (int r = 2; r <= 3; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    Console.WriteLine(r);
                    Console.WriteLine(c);
                    Console.WriteLine("---------------");
                }
            }
        }

    }


}
