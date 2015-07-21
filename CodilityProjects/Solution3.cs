using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    class Solution03
    {

        public static int Solution1(int[] A)
        {
            return 0;
         
        }

        /*public static bool isDigit(char c)
        {
            if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                return true;
            else return false;
        
        }*/

        public static int Solution2(int[] A)
        {
            string S = "13+62*7+*4+";
            S = "11++";
            
            if (S.Length==0) return -1;
            char[] ca = S.ToCharArray();
            int result = 0;

            Stack<int> si = new Stack<int> ();
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < ca.Length; i++)
            {
                
                // add
                if (ca[i] == '+')
                {
                    if (si.Count < 2) return -1;
                    c1 = si.Pop();
                    c2 = si.Pop();
                    try
                    {
                        si.Push(c1 + c2);
                    }
                    catch (OverflowException)
                    {
                        return -1;
                    }
                }
                //multiply
                if (ca[i] == '*')
                {
                    if (si.Count < 2) return -1;
                    c1 = si.Pop();
                    c2 = si.Pop();
                    try
                    {
                        si.Push(c1 * c2);
                    }
                    catch (OverflowException)
                    {
                        return -1;
                    }
                }
                //push
                if ((ca[i] == '0' || ca[i] == '1' || ca[i] == '2' || ca[i] == '3' || ca[i] == '4' || ca[i] == '5' || ca[i] == '6' || ca[i] == '7' || ca[i] == '8' || ca[i] == '9'))
                {
                    si.Push( int.Parse(ca[i].ToString()));
                }
            
            }
            if (si.Count > 0)
            {
                result = si.Pop();
                return result;
            }
            else return -1;

        }

        public static int Solution3(int[] A, int[] B)
        {
            int n = A.Length;
            int m = B.Length;
            Array.Sort(A);
            Array.Sort(B);
            int i = 0;
            for (int k = 0; k < n; k++)
            {
                if (i < m - 1 && B[i] < A[k])
                    i += 1;
                if (A[k] == B[i])
                    return A[k];
            }
            return -1;
        }


        public static int Solution4(int[] A)
        {
            int bitcount = A[A.Length - 1] + 4;

            int[] bitarray = new int[bitcount];
            for (int i = 0; i < bitarray.Length; i++) bitarray[i] = 0;

            int[] B = new int[A.Length];

           // set the result bit representation
            for (int i = 0; i < A.Length; i++)
            {
                bitarray[A[i]] = 1;
            }
            // shift left and add
            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i] + 1;
                if (bitarray[position] == 0)
                {
                    bitarray[position] = 1;
                }
                else
                { 
                    bitarray[position] = 0;
                    for (int k = position + 1; k < bitarray.Length; k++)
                    {

                        if (bitarray[k] == 0)
                        {
                            bitarray[k] = 1;
                            break;
                        }
                        else
                        {
                            bitarray[k] = 0;
                        }
                    }
                }

            }
            
            //calculate nr of set bits
            int Result = 0;
            for (int i = 0; i < bitarray.Length; i++) 
            {
                Result += bitarray[i];
            }
            return Result;
        }



        public static int Solution5(int[] A)
        {
            int bitcount = A[A.Length - 1] + 2;

            int[] bitarrayA = new int[bitcount];
            int[] bitarrayB = new int[bitcount];
            int[] bitarrayC = new int[bitcount];

            // set the result bit representation
            for (int i = 0; i < A.Length; i++)
            {

                bitarrayA[A[i] - 1] = 1;
                bitarrayB[A[i]] = 1;
            }


            // shift left and add

            int carry = 0;

            // O(n) data size
            for (int i = 0; i < bitarrayA.Length; i++)
            {
                if (bitarrayA[i] == 1 && bitarrayB[i] == 1)
                {
                    if (carry == 0)
                    {
                        bitarrayC[i] = 0;
                        carry = 1;
                    }
                    else
                    {
                        bitarrayC[i] = 1;
                        carry = 1;
                    }

                }
                else
                {
                    if (bitarrayA[i] == 1 && bitarrayB[i] != 1 || bitarrayA[i] != 1 && bitarrayB[i] == 1)
                    {

                        if (carry == 0)
                        {
                            bitarrayC[i] = 1;
                            carry = 0;
                        }
                        else
                        {
                            bitarrayC[i] = 0;
                            carry = 1;
                        }
                    }
                    else //bitarrayA[i] == 0 && bitarrayB[i] == 0
                    {
                        if (carry == 0)
                        {
                            bitarrayC[i] = 0;
                            carry = 0;
                        }
                        else
                        {
                            bitarrayC[i] = 1;
                            carry = 0;
                        }
                    }
                }
            }
 
            //calculate nr of set bits
            int Result = carry;
            for (int i = 0; i < bitarrayC.Length; i++)
            {
                Result += bitarrayC[i];
            }
            return Result;

        }

        public static int Solution6(int[] A)
        {
            double nr = 0;
            for (int i = 0; i < A.Length; i++)
            {
                nr = nr + (Math.Pow(2, A[i]));
                Console.Write(A[i].ToString()); 
            }
            Console.WriteLine();
            Console.WriteLine(nr.ToString());
            nr = nr * 3;
            Console.WriteLine(nr.ToString());


            // count 1
            
            int carry = 0;
            int Result = 1;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i + 1] - A[i] == 1)
                {
                    if (carry == 1)
                    {
                        Result++;
                        carry = 1;
                    }
                    else
                    {
                        carry = 1;
                    }
                }
                else 
                {
                    Result++;
                    carry = 0;
                }
            }
            Result += carry;
            return Result;
        }



        // sample
        public static int Solution0(int[] A)
        {

            Dictionary<int , int> dictionary = new Dictionary<int, int>();
            //return 0;

            for (int i = 0; i < A.Length; i++)
            {
                dictionary.Add(i, A[i]);
            }

            if (dictionary.ContainsKey(1)) 
            {
                return dictionary[1];
            }
            return 0;
        }







    }
}
