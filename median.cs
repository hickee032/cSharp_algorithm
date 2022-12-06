using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace median {
    internal class median {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"중간값은 {med(a, b, c)}");
        }

        static int med(int a,int b,int c) {
            if (a>=b) {
                if (b>=c) {
                    return b;
                }
                else if (a<=c) {
                    return a;
                }
                else {
                    return c;
                }
            }
            else if (a>c) {
                return a;
            }
            else if (b>c) {
                return c;
            }
            else {
                return b;
            } 
         }
    }
}
