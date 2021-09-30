using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining test cases:
                string string1 = "ABCD";
                string string2 = "ABDC";
                string string3 = "HARRY";
                string string4 = "SALLY";
                string string5 = "AA";
                string string6 = "BB";
                string string7 = "SHINCHAN";
                string string8 = "NOHARAAA";
                string string9 = "ABCDEF";
                string string10 = "FBDAMN";

            //executing on test cases:
            System.Console.WriteLine($"For Test Case 1 ,(strings {string1} and {string2}), the output is {commonChild(string1,string2)}!");
            System.Console.WriteLine($"For Test Case 2 ,(strings {string3} and {string4}), the output is {commonChild(string3,string4)}!");
            System.Console.WriteLine($"For Test Case 3 ,(strings {string5} and {string6}), the output is {commonChild(string5,string6)}!");
            System.Console.WriteLine($"For Test Case 4 ,(strings {string7} and {string8}), the output is {commonChild(string7,string8)}!");
            System.Console.WriteLine($"For Test Case 5 ,(strings {string9} and {string10}), the output is {commonChild(string9,string10)}!");
           

            static int commonChild(string S1,string S2)
             {   
                var result = 0;
                int[,] commonChildMatrix = new int[S1.Length + 1, S2.Length + 1]; //create a matrix that has rows and columns that are the length of the strings that take in, with the first rows being null.

                for(int i = 0; i < S1.Length; i++)
                {
                    commonChildMatrix[i, 0] = 0; //loop through and write '0' to the first row
                }            
                for (int j = 0; j < S2.Length; j++)
                {
                    commonChildMatrix[0, j] = 0; //loop through and write '0' to the first column. NOTE!! by doing this, you actually overwrite the first '0' in the row with a '0' for the first column.
                }
                for (int i = 1; i <= S1.Length; i++) // start on row 2 (i=1)
                {
                     for (int j = 1; j <= S2.Length; j++) //start on column 2 (j=1)
                    //These two 'for' loops "walk" through the matrix, row by column.
                    {
                        if (S1[i - 1] == S2[j - 1])
                        {
                            commonChildMatrix[i, j] =  commonChildMatrix[i - 1, j - 1] + 1; 
                            //this returns the value IN the matrix and adds one to it if there is a match in a string array analysis. 
                            
                            //creates a result variable to refernece and assigns it the integer number associated with the multi-dim array pair (coordinate look up)
                        }
                        else
                        {
                            commonChildMatrix[i, j] = Math.Max(commonChildMatrix[i, j - 1], commonChildMatrix[i - 1, j]); 
                            //return the max between 2 values found by inspecting matrix coordinates. This acts like a diagonal counter.
                        }
                    
                    result = commonChildMatrix[i,j]; 
                            
                    }

               

                }
               return result;
               
        
             }   
        }
    }
}
