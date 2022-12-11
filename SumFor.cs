using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSum {
    internal class SumFor {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++) {
                sum+= i;
            }

            Console.WriteLine(sum);

        }
    }
}
