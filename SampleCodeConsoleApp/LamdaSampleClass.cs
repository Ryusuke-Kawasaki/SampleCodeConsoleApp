using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeConsoleApp
{
    class LamdaSampleClass
    {
        //受け取った値numと合致する値が配列numbersにいくつあるかカウントするメソッド
        //配列が固定されているため汎用性が低い
        public int Count(int num)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == num)
                    count++;
            }
            return count;
        }

        //受け取った値numと合致する値が配列numbersにいくつあるかカウントするメソッド
        //引数に配列を受け取ることで汎用性を高くした
        //numと一致する数のカウント処理しか行えない。
        //例えばnumと一致しない数はいくつあるか、num以上の数はいくつあるかをカウントする
        //場合、新しいメソッドを定義する必要がある。
        public int Count(int[] numbers, int num)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == num)
                    count++;
            }
            return count;
        }

        //デリゲート(メソッドを型として定義しオブジェクトとして扱えるようにした)
        //Judgmentは受け取った値valueが条件を満たすならtrue、満たさないならfalseを返すことを想定したデリゲート
        public delegate bool Judgement(int value);
        //カウント条件の処理を引数に受け取ることで汎用性を高くした
        public int Count(int[] numbers, Judgement judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                    count++;
            }
            return count;
        }

        public void useCount()
        {
            //int count = Count(5);

            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //var count = Count(numbers, 5);
            //Console.WriteLine(count);

            Judgement judge = IsEven;
            //デリゲートの受け渡し
            //var count = Count(numbers, judge);
            //Console.WriteLine(count);

            //一回しか利用しないメソッドをわざわざ定義するのは面倒
            //匿名メソッドを使用することで呼び出しと同時にメソッドを定義可能
            //var count = Count(numbers, delegate (int n) { return n % 2 == 0 ; });

            //匿名メソッドをより簡潔に表現したものがラムダ式
            //７１行目のコードをラムダ式で書き換え
            //var count = Count(numbers, (int n) => { return n % 2 == 0; });
            //ラムダ式では１つの文ならばreturnと{}を省略可能
            //var count = Count(numbers, (int n) =>  n % 2 == 0 );
            //ラムダ式では引数の型を省略可能
            //var count = Count(numbers, (n) => n % 2 == 0);
            //ラムダ式では引数が一つなら引数のかっこを省略可能
            var count = Count(numbers, n => n % 2 == 0);
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
