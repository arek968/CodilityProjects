using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{

    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;

            //int[] A = new int[8]   {-1, 3, -4, 5, 1, -6, 2, 1};


            //int[] A = new int[7] {5,5,1,7,2,3,5};

            //int[] A = new int[4] { 9, 4, -3, -10 };

            //int[] A = new int[12] { 5, 4, -3, 2, 0, 1, -1, 0, 2, -3, 4, -5 };
            //int[] A = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            /*
            A[0] =  5    A[1]  = 4    A[2]  = -3
            A[3] =  2    A[4]  = 0    A[5]  =  1
            A[6] = -1    A[7]  = 0    A[8]  =  2
            A[9] = -3    A[10] = 4    A[11] = -5
            */
            //result = Solution0.Solution8(A);




            //int[] A = new int[6] { 1,3,6,4,1,2};
            //result = Solution0.Solution9(A);


            //A[0] = 3    A[1] = 4    A[2] =  3
            //A[3] = 2    A[4] = 3    A[5] = -1
            //A[6] = 3    A[7] = 3

            //int[] A = new int[8] { 3,4,3,2,3,-1,3,3};
            //result = Solution.Solution10(A);

            // max profit
            //int[] A = new int[6] { 23171, 21011, 21123, 21366, 21013, 21367 };
            //result = Solution2.Solution02(A);

            //silnia
            //result = Solution02.Solution1(2000);

            //ilość pierwiastków 3 stopnia
            //result = Solution02.Solution2(1,2);


            //njmniejszt wspólny element
            //int[] A = new int[4] { 1, 3, 2, 1};
            //int[] B = new int[5] { 4, 2, 5, 3, 2};
            //result = Solution03.Solution3(A, B);

            //bitcount
            int[] A = new int[10] { 1, 2, 3, 6, 7, 11, 24, 33, 45, 46};

            result = Solution03.Solution5(A);


            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
    
    
    