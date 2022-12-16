using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramblies;

public class WorkScramblies
{
    public static bool Scramble(string str1, string str2)
    {
        int counter = 0;
        for (int i = 0; i < str2.Length;)
        {
            for (int j = 0; j < str1.Length;)
            {
                if (counter != str2.Length && str1[j] == str2[i])
                {
                    counter++;
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            if (counter != str2.Length)
            {
                return false;
            }
        }
        if (counter == str2.Length)
        {
            return true;
        }
        return false;
    }
}
