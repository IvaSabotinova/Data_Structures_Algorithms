using System;

using System.Linq;


namespace T01RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = Sum(input, 0);
            Console.WriteLine(sum);

        }

        //public static int Sum(int[] array, int index)
        //{
            
        //    if (index == array.Length)
        //    {
        //        return 0;
        //    }

        //    int result = array[index] + Sum(array, index + 1);
        //    return result;

        //}

        public static int Sum(int[] input, int index)
        {
            if (index == input.Length - 1)
            {
                return input[index];
            }
            int result = input[index] + Sum(input, index + 1);
            return result;
        }
       
    }
}
