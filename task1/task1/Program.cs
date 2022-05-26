using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5 };
            int num = 7;
            
            Console.WriteLine(NewElement(ref numbers, num));
        }
        // 1. Parameter olaraq integer array variable-i ve bir integer value qebul eden ve
        // hemin integer value-nu integer array-e yeni element kimi elave eden metod.
//Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable-mız var.yazdığımız metodu çağırıb
//arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3} olmalıdır.

        static int NewElement(ref int[] numbers, int num)
        {
            for(var i=0;i<numbers.Length; i++)
            {
                int[] newnumbers;
                int newnumbers.Length = numbers.Length + 1;
                newnumbers[newnumbers.Length - 1] = num;

            }


        }
    }
}
