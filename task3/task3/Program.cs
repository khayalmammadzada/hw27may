using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            int[] numbers= { 1, -2, 7, -12, 15, 17};
            for(var i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(ReturnPositive(numbers, num));
            }

            
        }
        static int ReturnPositive(ref int[] numbers, int num)
           
            {

            if (num < 0)
            {
                 num = (num × (-1));
                return num
            }
            else
            {
                num > 0;
                
            }
            return num;
        }
            
            

    }
}
