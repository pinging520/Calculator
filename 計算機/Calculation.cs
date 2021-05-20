using System;
using System.Collections.Generic;
using System.Text;

namespace 計算機
{
    public class Calculation
    {







        static public string Back(string text)
        {
            char[] x = new char[text.Length];
            for (int i = 0; i < text.Length - 1; i++)
            {
                x[i] = text[i];
            }
            return new string(x);
        }

    }
}
