using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Homework2
            string a = "the sky is blue";
            string[] words = a.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {

                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    Console.Write(words[i]);

                    if (i > 0)
                    {
                        Console.Write(" ");
                    }
                }
            }
            #endregion
        }

    }


    #region Homework1
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {

            var output = 0;
            var determineWord = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    determineWord = true;
                    output++;
                    continue;
                }
                else if (determineWord)
                {
                    break;
                }
            }
            return output;

        }
    }
    #endregion

}
