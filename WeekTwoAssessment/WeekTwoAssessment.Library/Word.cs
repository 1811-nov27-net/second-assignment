using System;

namespace WeekTwoAssessment.Library
{
    public class Word
    {
        // private initialization of the name of the word that we are going to check
        private string _name = "";

        // constructor. If no parameters are passed, then the name of the word that we are going to check 
        // should be the empty string
        public Word()
        {
            name = "";
        }

        // constructor. If the name of the word to check is passed, then
        // that argument should take be automatically assigned.
        public Word(string Name)
        {
            name = Name;
        }
        public string name
        {
            get 
            { 
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }

        bool checkPalindrome(string _name)
        {
            int i = 0;
            int j = _name.Length - 1;
            bool isPalindrome = true;
            while (i < j)
            {
                char a = _name[i];
                char b = _name[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    isPalindrome = false;
                }
                i++;
                j--;
            }
            return isPalindrome;
        }
    }
}
