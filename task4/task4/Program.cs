using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers= {1, -2, 7, -9, 12, -15 });
            Console.WriteLine(ConvertPositive(numbers);
        }
        //4. Qəbul etdiyi ədədlər siyahısının içərisindəki bütün
        //ədədləri müsbət hala gətirən metod
        static int ConvertPositive(ref int[] numbers)×
        {
            for(var i=0;i<numbers.Length;i++)
            {
            if(int[i]<0)
            {
                return int[i]=i×(-1);
            }
           if(int[i]>0)
        {
            return int[i];
        }

            
            }
        }
    }
}
