using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int ri=0,le=0;
     foreach(var l in arr){
         for(int i=0;i<l.Count;i++){
             if(arr.IndexOf(l)==i){
                 Console.WriteLine(arr.IndexOf(l)+" "+i);
                ri+=arr[arr.IndexOf(l)][i]; 
             }
             if(arr.IndexOf(l)+i==(arr.Count-1)){
                   Console.WriteLine(arr.IndexOf(l)+" "+i+" "+(arr.Count-1));
             le+=arr[arr.IndexOf(l)][i];
             }
         }
     }
     Console.WriteLine("r"+ri);
      Console.WriteLine("l"+le);
     int a=Math.Abs(ri-le);
     return a;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
