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
            char[] charS = s.ToCharArray();
            char[] charGoal = goal.ToCharArray();
            bool letterChange = true;
            int indexLetterChange = 0;
            if (s == goal)
            {
                for (int i = 0; i < charS.Length - 1; i++)
                {
                    for (int j = i + 1; j < charS.Length; j++)
                    {
                        if (charS[i] == charS[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
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
                            SwapeTwoLetter(i, indexLetterChange);                            
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
            void SwapeTwoLetter(int indexLetter, int indexChange)
            {
                char tmp = charS[indexLetter];
                charS[indexLetter] = charS[indexChange];
                charS[indexChange] = tmp;
            }
            return false;
        }
    }
}
/*if (charS[i] != charGoal[i])
                {
                    if (letterChange)
                    {                        
                        indexLetterChange = i;
                        letterChange = false;
                    }
                    else 
                    {
                        charS[indexLetterChange] = charS[i];
                        charS[i] = charGoal[i];

                        if ((new string(charS) == new string(charGoal)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }*/