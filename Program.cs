﻿using Assignment_C__Advanced_2.FixedSizeList;
using System.Collections;

namespace Assignment_C__Advanced_2
{
    internal class Program
    {
        public static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }
        public static List<int> GetEvens(List<int> list)
        {
            return list.Where(n => n % 2 == 0).ToList();
        }

        public static void Main()
        {
            #region Q1
            /*ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
                ReverseArrayList(list);

                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }*/
            #endregion

            #region Q2
            /*List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
                List<int> Evens = GetEvens(list);

                foreach (int i in Evens)
                {
                    Console.Write(i + " "); ;
                }*/
            #endregion

            #region Q3
/*            FixedSizeList<int> list = new FixedSizeList<int>(5);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            try
            {
                list.Add(6);

            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(list.Get(2));
                Console.WriteLine(list.Get(8));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion
        }
    }
}
