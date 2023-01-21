using System;  
public class Exercise11  
{  
    public static void Main()
{
//   variable declaration
   int a,b,c;
   double d, x1,x2;
    Console.Write("Input the value of a : ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the value of b : ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the value of c : ");
    c = Convert.ToInt32(Console.ReadLine());

// quadratic law
   d=b*b-4*a*c;
   if(d==0)
   {
     Console.Write("Both roots are equal.\n");
     x1=-b/(2.0*a);
     x2=x1;
     Console.Write("First  Root1= {0}\n",x1);
     Console.Write("Second Root2= {0}\n",x2);
   }
   else if(d>0)
	{
	   Console.Write("Both roots are real and diff-2\n");

	   x1=(-b+Math.Sqrt(d))/(2*a);
	   x2=(-b-Math.Sqrt(d))/(2*a);

	   Console.Write("First  Root1= {0}\n",x1);
	   Console.Write("Second Root2= {0}\n",x2);
	}
	else
	    Console.Write("Root are imeainary;");
}
}
