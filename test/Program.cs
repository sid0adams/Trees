using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractSyntaxTree;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            INode node = Parser.Parse("(4*5-3) * 7 - 3");
        }
    }
}
