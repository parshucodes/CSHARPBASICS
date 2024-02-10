using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            int random = randno(1, 101);
            int count = 0;
            while (true)
            {
                Console.WriteLine("Enter a number between 1 to 101");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input==0)
                    return;
                else if(input<random)
                {
                    Console.WriteLine("Low, GUess a number higher than {0}",input);
                    count++;
                }
                else if(input>random)
                {
                    Console.WriteLine("High, GUess a number Lower than {0}",input);
                    count++;
                }
                else
                {
                    Console.WriteLine("You guessed the number right, the number is:{0}",input);
                    Console.WriteLine("it took you {0} {1}", count,count==1? "try" : "tries");
                    
                    break;
                }
            }
        }
    }
    static int randno(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}   
    