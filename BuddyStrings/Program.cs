using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abab", goal = "abab";
            Console.WriteLine(s);
            Console.WriteLine(goal);
            if (BuddyStrings(s, goal))
            {
                Console.WriteLine("Goal!!!");
            }
            else
            {
                Console.WriteLine("Not a goal!!!");
            }
        }
       
        public static bool BuddyStrings(string s, string goal)
        {
            if (s == goal)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
            else
            {
                char[] charS = s.ToCharArray();
                char[] charGoal = goal.ToCharArray();
                bool letterChange = true;
                int indexLetterChange = 0;
                for (int i = 0; i < charS.Length; i++)
                {
                    if (charS[i] != charGoal[i])
                    {
                        if (letterChange)
                        {
                            letterChange = false;
                            indexLetterChange = i;
                        }
                        else
                        {
                            SwapeTwoLetter(charS, i, indexLetterChange);
                            if ((new string(charS) == new string(charGoal)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            void SwapeTwoLetter(char[] arr, int indexLetter, int indexChange)
            {
                char tmp = arr[indexLetter];
                arr[indexLetter] = arr[indexChange];
                arr[indexChange] = tmp;
            }
            return false;
        }
    }
}