using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escapeSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("And John said \" Bend the Knee\" "); //To use Quote you will use backslash for escape sequence. 
            Console.WriteLine("D:\\Movies"); //To Display backslash you use double backslash where the first one is for escape sequence
            Console.WriteLine("And John said \" Bend \t the Knee\" "); // \t for horizontal Tab
            Console.WriteLine("And John said \" Bend \n the Knee\" "); // \n for new line.
            Console.WriteLine("And John said \" Bend\bthe Knee\" "); // \b Backspace.
            Console.WriteLine("And John said \" Bend \a the Knee\" "); // \a Alert or bell.
        }
    }
}
