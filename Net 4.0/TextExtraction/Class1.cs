using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextExtraction
{
    public class Extractor
    {
        string[] strX;
        public Extractor()
        {

        }

        
        public string[] GetDuplicateVector(string[] strA, string[] strB)
        {
            int n = strA.Length;
            int m = strB.Length;                        

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    if (IsA(strB[j], strA))
                    {                        
                        strX[j] = strB[j];
                    }
                }
            }

            return strX;
        }

        public bool IsA(string a, string[] strA)
        {
            bool result = false;
            int n = strA.Length;

            for (int i = 0; i <= n - 1; i++)
            {
                if (a.Trim() == strA[i].Trim())
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
