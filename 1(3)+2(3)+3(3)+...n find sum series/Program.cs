using System;

class Program {
    static void Main(string[] args) {
        int n = 3; // change this to the desired value of n
        int result = 0;
        for (int i = 1; i <= n; i++) {
            result += i * i * i;
        }
        Console.WriteLine("Summation series: 1^3 + 2^3 + 3^3 + ... + " + n + "^3 = " + result);
    }
}
