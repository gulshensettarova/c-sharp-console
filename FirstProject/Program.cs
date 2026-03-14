using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Gulshan";
            System.String name1 = new String("Gulshan".ToCharArray());
            Console.WriteLine(Object.Equals(name,name1));
        }
    }
}
