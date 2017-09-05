using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //呼び出し
            OptionClass op = new OptionClass();
            op.DoSomething(100);
            op.DoSomething(100, "エラーです");
            op.DoSomething(100, "エラーです", 5);
        }
    }
}
