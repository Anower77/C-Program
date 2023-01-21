using System;
namespace characters_specialChar_number
{
    class characters_specialChar_number
    {
        public static void Main(string[] args)
        {
            string str;
            int alphabet, number, specialChar, i, l;
            alphabet = number = specialChar = i = 0;
            Console.Write("Write Somethig : ");
            str = Console.ReadLine();
            l = str.Length;
            
            
            while(i < l)
            {
                if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
                {
                    alphabet++;
                }
                else if(str[i]>='0' && str[i]<='9')
                {
                    number++;
                }
                else
                {
                    specialChar++;
                }
                i++;
            }
            Console.WriteLine("Aphabet is = {0}\n ", alphabet);
            Console.WriteLine("Number is = {0}\n" , number);
            Console.WriteLine("Special Character is = {0}\n", specialChar);
        }
    }
}