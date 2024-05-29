using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labs_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "THE USER WITH THE NICKNAME koala757677 THIS MONTH WROTE 3 TIMES MORE COMMENTS THAN THE USER WITH THE NICKNAME crCco181dile920 4 MONg6HS AGO";


            var p1 = new Converter(myString);


            Console.WriteLine(p1.TaskTwoMethod());

            //Console.WriteLine(p1.BinaryStringToInt());



        }
    }
}
