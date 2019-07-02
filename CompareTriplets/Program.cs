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

class Solution
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int[] aRate = a.ToArray();

        int[] bRate = b.ToArray();

        int aliceCount = 0;

        int bobCount = 0;

        for(int i=0;i<3;i++)
        {
            if(a[i]>b[i])        //Alice awarded 1 point
            {
                aliceCount++;
            }
            else if (a[i]<b[i]) //bob awarded 1 point
            {
                bobCount++;
            }

        }

        int[] finalRating = { aliceCount, bobCount };

        return finalRating.ToList();

    }

    static void Main(string[] args)
    {
       
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

    }
}
