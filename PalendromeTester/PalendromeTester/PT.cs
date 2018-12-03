using System;

namespace PalendromeTester
{
    public class PT
    {
        public bool isPalendrome(string input)
        {
            string testString = trimInput(input);
            for (int i = 0; i < testString.Length/2; i++)
            {
                if (testString[i] != testString[testString.Length - i - 1])
                    return false;
            }
            return true;
        }

        private string trimInput(string input)
        {
            string ret = "";
            input = input.ToLower();
            for (int i=0; i < input.Length; i++)
            {
                if((input[i]>='A'&& input[i]<='Z') || (input[i]>='a' && input[i] <= 'z'))
                {
                    ret += input[i];
                }
            }
            return ret;
        }
    }
}
