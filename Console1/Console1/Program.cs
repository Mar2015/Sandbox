using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[21];
            names[0] = "溝江 智徳";
            foreach (var name in names)
	        {
		        Console.WriteLine(name);
	        }
            Console.ReadLine();
        }
    }
}
