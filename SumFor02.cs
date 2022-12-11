using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSum2 {
    internal class SumFor02 {
        static void Main(string[] args) {
            //n 을 양수만 입력

            int n;

            do {
                n = int.Parse(Console.ReadLine());
            } while (n<=0);

            int sum = 0;
            for (int i = 1; i <= n; i++) {
                if (i<n) {
                    Console.Write(i + " + ");
                }
                else {
                    Console.Write(i + " = ");
                }

                sum += i;
            }
            Console.WriteLine(sum);


        }
    }
}
