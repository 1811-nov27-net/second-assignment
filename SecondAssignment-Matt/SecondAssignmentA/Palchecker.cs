using System;

namespace SecondAssignment
{
    public class PalChecker
    {

        public bool checker(string item)
        {
            int length = item.Length;

            for (int i = 0; i < length / 2; i++)
                if (item[i] != item[length - 1 - i])
                    return false;

            return true;
        }

    }
}
