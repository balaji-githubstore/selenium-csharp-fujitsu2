using CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{

    class Father
    {
        public int fAge = 65;

        public Father(int fAge)
        {
            this.fAge = fAge;
            Console.WriteLine("Father Constructor");
        }
        public void FatherStyle()
        {
            Console.WriteLine("Father Style!!");
        }
    }
    class Son : Father
    {
        public int sAge = 20;
        public Son(int fAge,int sAge):base(fAge)
        {
            this.sAge = sAge;
            Console.WriteLine("Son Constructor");
        }
        public void SonStyle()
        {
            Console.WriteLine("Son Style");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Father f=new Father();
            //f.FatherStyle();

            Son s = new Son(65,20);
            s.FatherStyle();
            s.SonStyle();
            Console.WriteLine(s.fAge);
            Console.WriteLine(s.sAge);
         
        }
    }


}
