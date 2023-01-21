using System;

class Program {
    static void Main(string[] args) {
        int n = 10; // change this to the desired value of n
        int result = 0;
        for (int i = 1; i <= n; i += 2) {
            result += i;
        }
        Console.WriteLine("Summation series: 1+3+5+...+" + n + " = " + result);
    }
}
