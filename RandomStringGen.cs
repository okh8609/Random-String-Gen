using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rd = new Random();

        static void Main(string[] args)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"output.txt", true))
            {
                for (int i = 0; i < 2000; i++)
                {
                    file.WriteLine(GetRandomStr(4) + " " + GetRandomStr(4));
                }
            }
        }

        public static string GetRandomStr(int len)
        {
            //設定驗證碼字元的陣列
            string[] Code = { "A", "B", "C", "D", "E", "F", "G", "H", "K", "M", "N", "P", "R", "S", "U", "V", "W", "X", "Y", "Z", "2", "3", "4", "5", "6", "8", "9" };
            //驗證碼字串
            string str = string.Empty;



            for (int i = 0; i != len; ++i)
                str += Code[rd.Next(Code.Count())];

            return str;
        }
    }
}
