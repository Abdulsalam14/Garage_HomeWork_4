using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var names = "Suleyman Semed Tural Abdulsalam Mirqubad";

            var reversenames = ReverseNames(names);
            Console.WriteLine(names);
            Console.WriteLine(reversenames);

        }

        static string ReverseNames(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var names = str.Split(' ');
                var result= new StringBuilder();
                foreach (var name in names)
                {
                    for (int i =name.Length-1; i >=0; i--) 
                    {
                        result.Append(name[i]);
                    }
                    result.Append(' ');
                }
                return result.ToString();
            }
            return str;
        }
    }
}
