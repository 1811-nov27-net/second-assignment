using System;

namespace ConnerProj2.Library
{
    public static class PalendromeFinder
    {

        public static bool findPalendrome(string s)
        {
            string modString = s.ToUpper();
            string[] remove = { ".", ",", " " };
            string ns = modString;
            foreach(var r in remove)
            {
                ns = ns.Replace(r, String.Empty);   
            }

            //string input = modString.Trim(new char[] { '.', ',',' ' });
            for(int i = 0; i < ns.Length/2; i++)
            {
                if(ns[i] != ns[ns.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
