using System;

namespace Palidromes.Library
{
    public class Program
    {
        public bool IsPalidromes(string s){
            string sinput = s;
            char[] arr = sinput.ToCharArray();

            Array.Reverse(arr);

            sReverse = new string(arr);
            
            return s.Equals(sReverse);

          

}
    }


}

