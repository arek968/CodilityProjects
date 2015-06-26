using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    class Solution01
    {

        //naiwne sumowanie tablicy
        public static int Solution1(int[] A)
        {

            long[,] sumy = new long[A.Length, 2];
            for (int i = 0; i < A.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    sumy[i, 0] += A[j];
                }
                for (int j = i + 1; j < A.Length; j++)
                {
                    sumy[i, 1] += A[j];
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (sumy[i, 0] == sumy[i, 1]) return i;
            }
            return -1;


        }

        //sumowanie tablicy
        public static int Solution2(int[] A)
        {


            long suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                suma += A[i];
            }

            long suma_left = 0;
            for (int i = 0; i < A.Length; i++)
            {
                long sum_right = suma - suma_left - A[i];
                if (suma_left == sum_right) return i;
                suma_left += (long)A[i];
            }
            return -1;


        }


        //sortowanie tablicy
        public static int Solution3(int[] A)
        {
            var SA = A.OrderByDescending(a => a);
            int p3 = SA.ElementAt(0) * SA.ElementAt(1) * SA.ElementAt(2);
            int n2p1 = SA.ElementAt(A.Length - 1) * SA.ElementAt(A.Length - 2) * SA.ElementAt(0);

            if (p3 > n2p1) { return p3; } else { return n2p1; }
        }

        //frog jump
        public static int Solution4(int X, int Y, int D)
        {

            if (Y == X) return 0;

            if ((Y - X) % D == 0) return (Y - X) / D;
            else return (Y - X) / D + 1;


        }


        public static int Solution5(int[] A)
        {
            var SA = A.OrderBy(a => a).ToArray();

            for (int i = 0; i < SA.Length; i++)
            {
                if (SA[i] != (i + 1)) return i + 1;
            }
            return -1;
        }

        public static int Solution6(int X, int[] A)
        {
            int sum_X = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X) sum_X++;


            }
            if (sum_X == 0) return 0;
            if (sum_X == A.Length) return 0;

            int count_X = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X) count_X++;

                if (sum_X - count_X == A.Length - sum_X - i) return i + 1;

            }
            return 0;
        }

        public static int Solution7(int[] A)
        {
            double avrg = A.Average();
            double max_avg = avrg;
            int max_avg_index = -1;

            for (int i = 0; i < A.Length; i++)
            {
                double dev_i = Math.Abs(A[i] - avrg);
                if (dev_i > max_avg)
                {
                    max_avg = dev_i;
                    max_avg_index = i;
                }
            }
            return max_avg_index;
        }


        // { 5, 4, -3, 2, 0, 1, -1, 0, 2, -3, 4, -5 };
        public static int Solution8(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return 1;

            int max_slice_length = 1;
            int curr_slice_length = 1;

            int prev_sign = Math.Sign(A[1]);
            int prev_sign_2 = Math.Sign(A[0]);

            if (Math.Sign(A[0]) != Math.Sign(A[1]))
            {
                curr_slice_length = 2;
                max_slice_length = 2;
            }


            for (int i = 2; i < A.Length; i++)
            {
                int curr_sign = Math.Sign(A[i]);

                if ((curr_sign != prev_sign && prev_sign != 0) || (prev_sign == 0 && curr_sign == prev_sign_2 && curr_sign != 0))
                {
                    curr_slice_length++;
                    if (curr_slice_length > max_slice_length) max_slice_length = curr_slice_length;
                }
                else { curr_slice_length = 2; }
                prev_sign_2 = prev_sign;
                prev_sign = curr_sign;
            }
            return max_slice_length;
        }




        public static int Solution9(int[] A)
        {
            var SA = A.Where(a => a > 0).Distinct().OrderBy(a => a).ToArray();
            if (SA.Length == 0) return 1;
            for (int i = 0; i < SA.Length; i++)
            {

                if (i + 1 != SA[i]) return i + 1;
            }
            return SA.Length + 1;
        }

        //dominator - codility źle to weryfikuje
        public static int Solution10(int[] A)
        {
            int count = 0;
            int x = 0;
            for (int i = 0; i < A.ToArray().Length; i++)
            {
                if (count == 0)
                {
                    x = A[i];
                    count++;
                }
                else if (A[i] == x) count++;
                else count--;

            }


            int count1 = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] == x)
                    count1++;

            if (count1 > A.Length / 2)
                return x;
            else
                return -1;
        }

        //max profit
        public static int Solution11(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return 0;

            int minPrice = A[0];
            int localProfit = 0;
            int maxProfit = 0;
            for (int i = 1; i < A.Length; i++)
            {
                localProfit = Math.Max(0, A[i] - minPrice);
                minPrice = Math.Min(minPrice, A[i]);
                maxProfit = Math.Max(maxProfit, localProfit);
            }
            return maxProfit;
        }



        //min value 
        public static int Solution12(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return Math.Abs(A[0]);

            int minVal = 0;
            int curVal = 0;
            int[,] IA = new int[A.Length, A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {


                }
            }
            return minVal;
        }

        public static int Solution13()
        {
            string s = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
            var AR = s.ToArray();
            int A = 0;
            int G = 0;
            int C = 0;
            int T = 0;
            for (int i = 0; i < AR.Length; i++)
            {
                if (AR[i] == 'A') A++;
                else if (AR[i] == 'G') G++;
                else if (AR[i] == 'C') C++;
                else if (AR[i] == 'R') T++;
            }
            return 0;

        }
    }
}
