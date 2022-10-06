using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string DoubleChars = "";
            foreach (char x in original)
            {
                DoubleChars = DoubleChars + x + x;
            }
                return DoubleChars;
                 
        }
    }
}
