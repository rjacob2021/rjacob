using System;

namespace OddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an odd number:");
            int n = Convert.ToInt32(Console.ReadLine());
            var a = new int[n];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            var sol = new Solution();
            int result = sol.solution(a);
            Console.WriteLine("The odd number:"+result);

        }
        class Solution
        {
            public int solution(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = i+1; j < A.Length; j++)
                    {
                        if (A[i] == A[j])
                        {
                            A[i] = 0;
                            A[j] = 0;
                        }


                    }

                }
                for(int k=0;k<A.Length;k++)
                {
                    if (A[k] != 0)
                        return A[k];
                }


                return 0;
            }



        }
    }
}
