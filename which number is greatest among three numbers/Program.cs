using System;  
public class Exercise8  
{  
    public static void Main()
{
    int num1, num2, num3;

// input data
    Console.Write("Input the 1st number :");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the  2nd number :");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the 3rd  number :");
    num3 = Convert.ToInt32(Console.ReadLine());
 
 // condition
  if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write("1st Number is the greatest. \n\n");
        }
        else
        {
            Console.Write("3rd Number is the greatest. \n\n");
        }
    }
    else if (num2 > num3)
        Console.Write("2nd Number is the greatest. \n\n");
    else
        Console.Write("3rd Number is the greatest. \n\n");
}
}
