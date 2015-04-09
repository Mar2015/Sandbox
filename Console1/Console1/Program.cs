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

            // この下に追加してください。
            // names[名簿番号の要素番号] = "名前";

            names[21] = "松谷 春華";

            foreach (var name in names)
	        {
		        Console.WriteLine(name);
	        }
            Console.ReadLine();
        }
    }
}
