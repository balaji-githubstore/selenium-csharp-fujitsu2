using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    public class Program1
    {
        static void Main1(string[] args)
        {
            // created by balaji
            Console.WriteLine("Hi Everyone!! Welcome to the session!!");

            sbyte a = 50;  //1 byte of memory will be occupied 
            short b = 100; //2 byte of memory 
            int c = 100; //4 byte
            long d = 100; //8 byte

            float f = 10.2f; //4 byte

            double e = 10.2; //8 byte

            char letter = '#'; //2 byte 

            bool check = true;

            e = c; //implicit conversion
            string name = "Balaji"; //6*2 byte of memory

            Console.WriteLine(name);
            Console.WriteLine(name[1]);
            Console.WriteLine(name.ToUpper());

            //add, sub, mul, div, mod 
            //area of triangle -> base =25, height = 1
            //area of circle -> radius - 12.2

            Console.WriteLine(10.2);

            double radius = 10;

            double result = 3.14 * radius * radius;
            Console.WriteLine("The output is " + result);

            Console.WriteLine((double)22 / 7);

            double x = 10.3;

            int z = (int)x; //explicit conversion //will lead to data loss
            Console.WriteLine(z);


            double[] numbers = new double[5]; //5*8 bytes of memory 

            numbers[0] = 10f;
            numbers[1] = 20.2;
            numbers[2] = 10;
            numbers[3] = 40;
            //numbers[4] = 50;
            //numbers[5] = 60;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[4]);

            //red,green,yellow
            string[] colors = new string[3];
            //colors[0] = "red";
            colors[1] = "yellow";
            colors[2] = "green";

            Console.WriteLine(colors);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            int[] numbers1 = { 45, 10, 55 };

            Console.WriteLine(numbers1[1]);

            string[] colors1 = { "red", "green", "yellow" };

            colors = new string[10];
            Console.ReadLine();


        }

    }


}
