using System;  
public class Exercise34 
{  
    public static void Main()
{
    //variable declaration
    int num, i, ctr, first_num, second_num;
	
	  	
    //Input prime number
    Console.Write("Input 1st number: ");
    first_num = Convert.ToInt32(Console.ReadLine()); 	
    Console.Write("Input 2nd number: ");
    second_num = Convert.ToInt32(Console.ReadLine()); 	
    Console.Write("Prime numbers between {0} and {1} are : \n",first_num,second_num);
  
  
    //Condition & Loop
    for(num = first_num; num <= second_num; num++)
       {
         ctr = 0;

         for(i = 2; i <= num/2; i++)
            {
             if(num%i == 0){
                 ctr++;
                 break;
             }
        }
        
         if(ctr==0 && num!= 1)
             Console.Write("{0} ",num);
    }
    Console.Write("\n"); 
  } 
} 