// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

class Solution {
    public static bool AreAnagrams(ArrayList arr1, ArrayList arr2)
    {
        if(arr1.Count != arr2.Count)
        {
            return false;
        }

        arr1.Sort();
        arr2.Sort();

        for(int i = 0; i < arr1.Count; i++)
        {
            if(arr1[i]!.ToString() != arr2[i]!.ToString())
            {
                return false;
                
            }
        }
        
        return true;
    }

    public static void Main() {
        String str1 = "garden";
        String str2 = "agrand";

        char[] strSplit1 = str1.ToCharArray();
        ArrayList arr1 = new ArrayList(strSplit1);

        char[] strSplit2 = str2.ToCharArray();
        ArrayList arr2 = new ArrayList(strSplit2);

        bool areAnagrams = AreAnagrams(arr1, arr2);

        if(areAnagrams)
        {
            Console.Write("The words {0} and {1} are anagrams!", str1, str2);
        }
        else
        {
            Console.Write("The words {0} and {1} are not anagrams!", str1, str2);
        }


    }
}