using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudgeSign {
    internal class JudgeSign {
        static void Main(string[] args) {
            Console.WriteLine("정수를 입력하세요");
            int n = int.Parse(Console.ReadLine());

            if (n>0) {
                Console.WriteLine("양수");
            }
            else if (n<0) {
                Console.WriteLine("음수");
            }
            else {
                Console.WriteLine("0입니다.");
            }

        }
    }
}
