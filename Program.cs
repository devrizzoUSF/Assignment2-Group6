﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_Group6
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 2, 3, 9, 9, 9, 9, 9, 12};
            int target = 9;
            int[] r = TargetRange(l1, target);
            Console.WriteLine("[{0}]", string.Join(", ", r));
            Console.WriteLine();

            //QUESTION 2
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

            //QUESTION 3
            Console.WriteLine();
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6, 6, 7 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            //QUESTION 4
            Console.WriteLine();
            Console.WriteLine("Question 4");
            string s2 = "DeddDDell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);

            //QUESTION 5 - PART 1
            Console.WriteLine();
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);

            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");

            //QUESTION 5 - PART 2
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);

            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");

            //QUESTION 6 
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));

            //QUESTION 7 
            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);

            //QUESTION 8
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));

            //QUESTION 9
            Console.WriteLine();
            Console.WriteLine("Question 9");
            SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        public static int[] TargetRange(int[] l1, int t)
        {
            bool found = false;
            int index = 0;
            int position = -1;
            int position2 = -1;

            try
            {
                //Scan through the array 
                while (index < l1.Length)
                {
                    if (l1[index] == t && !found)
                    {
                        found = true;
                        position = index;
                    }

                    if (l1[index] == t && found == true)
                    {
                        position2 = index;
                    }

                    index++;
                }
            }
            catch (Exception)
            {
                throw;
            }

           return new int[] {position, position2};
        }

        public static string StringReverse(string s)
        {
            try
            {
                s = s + " ";

                Stack<char> st = new Stack<char>();

                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[i] != ' ')
                    {
                        st.Push(s[i]);
                    }
                    
                    //When we see a space we print the contents of the stack
                    else
                    {
                        while (st.Count > 0)
                        {
                            Console.Write(st.Pop());
                        }
                        Console.Write(" ");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static int MinimumSum(int[] l2)
        {
            int newSum = 0;

            try
            {
                for (int i = 0; i < l2.Length; i++)
                {
                    if (i != l2.Length - 1 && l2[i] == l2[i + 1])
                    {
                        l2[i + 1] = l2[i] + 1;
                    }
                    
                    newSum += l2[i];
                }
            }
            catch (Exception)
            {
                throw;
            }
            return newSum;
        }

        public static string FreqSort(string s2)
        {
            try
            {
                Dictionary<char, int> freqKey = new Dictionary<char, int>();

                for (int i = 0; i < s2.Length; i++)
                {
                    if (!freqKey.ContainsKey(s2[i]))
                    {
                        freqKey.Add(s2[i], 1);
                    }
                    else 
                    {
                        freqKey[s2[i]] += 1;
                    }
                }

                foreach(var item in freqKey.OrderByDescending(x => x.Value))
                {
                    for(int d = 0; d < item.Value; d++)
                    {
                        Console.Write(item.Key);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }

        public static int GoldRod(int rodLength)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }

        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }

        public static void SolvePuzzle()
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

