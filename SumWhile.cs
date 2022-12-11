using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSum {
    internal class SumWhile {
        static void Main(string[] args) {
            //while 1 ~ n

            int n = int.Parse(Console.ReadLine());

            int i = 1;
            int sum = 0;
            while (i <= n) {
            
                sum+= i;
                i++;
            }

            Console.WriteLine(sum);


        }
    }
}
