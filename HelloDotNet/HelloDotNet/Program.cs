using System;

namespace HelloDotNet
{
   public  class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Arrays();
        }
        static void Arrays()
        {
            int n;
            int[] myNumbers = new int[10];
            for(int i=0;i<10;i++)
            {
                myNumbers[i] = (int)Math.Pow(2, i);
                Console.WriteLine(myNumbers[i]);
            }
            bool result = Contains(myNumbers, 8);
            Console.WriteLine(result);
            bool binaryResult = BinarySearch(myNumbers, 8, 0, myNumbers.Length);
            Console.WriteLine(binaryResult);

        }


        static bool Contains (int[] array, int a)
        {
            foreach (int item in array)
            {
                if (item==a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool BinarySearch(int [] array, int a, int start, int end)
        {
            if(end < start)
            {
                return false;
            }
            int pos = (start + end) / 2;
            if (pos == start || pos == end) ;
            int pivot = array[pos];
            if (pivot == a)
            {
                return true;
            }
            if (pivot < a)
            {
                return BinarySearch(array, a, (pos + 1), end);
            }
            else if(pivot > a)
            {
                return BinarySearch(array, a, start, pos - 1);
            }
        }
    }

}
