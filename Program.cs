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

        public static void Main()
        {
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            ReverseArrayList(list);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
