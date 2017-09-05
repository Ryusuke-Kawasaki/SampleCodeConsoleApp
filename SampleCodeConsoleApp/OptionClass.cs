using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeConsoleApp
{
    class OptionClass
    {
        //オーバーロード
        //少ない引数のメソッドから多い引数を呼び出すパターン
        /*
        public void DoSomething(int num, string message, int retryCount)
        {
            //
        }
        public void DoSomething(int num, string message)
        {
            DoSomething(num, message, 3);
        }
        public void DoSomething(int num)
        {
            DoSomething(num, "DefaultMessage", 3);
        }
        */
        /// <summary>
        /// オプション引数を定義する方法で書き換え
        /// </summary>
        /// <param name="num">数</param>
        /// <param name="message">メッセージ</param>
        /// <param name="retryCount">再試行回数</param>
        public void DoSomething(int num, string message = "DefaultMessage", int retryCount = 3)
        {
            //
        }
    }
}
