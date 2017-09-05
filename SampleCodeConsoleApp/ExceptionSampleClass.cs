using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeConsoleApp
{
    class ExceptionSampleClass
    {
        public void fileRead()
        {
            //try-catch-finallyを利用した外部リソースアクセスの典型的な処理
            //@はエスケープシーケンスの無効化(パス区切りが\\ではなく\とかける）
            StreamReader sr = new StreamReader(@"test\test.txt");
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null) // 1行ずつ読み出し。
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                //例外の発生原因をコンソール出力
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                //例外を再スロー
                throw;
            }
            finally
            {
                sr.Dispose();
            }

            // using句を利用した場合
            using (StreamReader r = new StreamReader(@"test\test.txt"))
            {
                try
                {
                    string line;
                    while ((line = r.ReadLine()) != null) // 1行ずつ読み出し。
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    //例外の発生原因をコンソール出力
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.TargetSite);
                    Console.WriteLine(e.StackTrace);
                    //例外を再スロー
                    throw;
                }
            }


        }
    }
}
