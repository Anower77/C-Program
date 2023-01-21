using System;

class Program {
    static void Main(string[] args) {
        int n = 10; // change this to the desired value of n
        int result = 0;
        for (int i = 2; i <= n; i += 2) {
            result += i;
        }
        Console.WriteLine("Summation series: 2+4+6+...+" + n + " = " + result);
    }
}
