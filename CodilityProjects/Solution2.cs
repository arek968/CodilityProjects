using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    class Solution02
    {
        //
        public static int Solution1(int N)
        {
            if (N < 2) return 1;
     
            int[] A = new int[100000];

            A[0] = 1;
            for (int i = 1; i <= N; i++ )
            {
                for (int j = 0; j < A.Length; j++ )
                {
                    A[j] = A[j] * i;  //pozycje dziesiętna * kolejna liczba w obliczaniu silni
                }
                bool not_done = false; 
                do {
                    for (int k = 0; k < A.Length - 1; k++)
                    {
                        not_done = false; // zakładamy że nie będzie pozycji do przeniesienia 
                        if (A[k] > 9) // jeśli na pozycji dziesiętnej trzeba wykonać przeniesienie
                        {
                            not_done = true; // przeniesienie zostało zrobione, trzeba będzie jeszcze raz przeskanować tablicę w poszukiwaniu pozycji do przeniesienia
                            A[k + 1] = A[k + 1] + A[k] / 10; //przenosimy rząd wyżej 
                            A[k] = A[k] % 10; //pozostawiamy resztę z dzielenia
                        }
                    }
                } while (not_done);
            }
            
            long Sum1 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                Sum1 += int.Parse(A[i].ToString());
            }
            if (Sum1 > 100000000) return -1; else return (int)Sum1; 
        }


        public static int Solution2(int A, int B) 
        {
            //jeśli obie liczby są równe
            if (A == B)
            {
                double d = Math.Round(Math.Pow((double)Math.Abs(A), (double)1 / (double)3)); //obliczamy pierwiastek i zaokrąglamy do najbliższej całkowitej
                if (d * d * d == Math.Abs(A) ) return 1; else return 0; // jeśli dane wejściowe mają pierwiastek 3 st. to 1, jeśli nie to 0
            } // koniec

            // wyliczamy pierwiastki 3 stopnia z danych wejściowych
            int cubeA = (int)Math.Pow((double) Math.Abs(A), 1.0 / 3.0); 
            int cubeB = (int)Math.Pow((double) Math.Abs(B), 1.0 / 3.0);

            int result = 0;

            // 1. jeślo obie dodatnie to pierwiastki 3 stopnia są między nimi
            if (A >= 0 && B >= 0)
            {
                result = cubeB - cubeA +1;
            }
            else
                // 2. jeśli A < 0 to pierwiastki są także ujemne i trzeba je uwzględnić
                if (A < 0 && B >= 0)
                {
                    result = Math.Abs(cubeB) + Math.Abs(cubeA) + 1;
                }
                else // 3. jeśl A < 0 i B < 0 to sytuacja symetryczna do przypadku 1.
                {
                    result = Math.Abs(cubeA) - Math.Abs(cubeB) + 1;
                }
            
            return result;
        }

        // { 5, 4, -3, 2, 0, 1, -1, 0, 2, -3, 4, -5 };
        public static int solution8(int[] A)
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

    }
}
