using Assignment_C__Advanced_2.FixedSizeList;
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
        public static int FirstNONRepeatedCharacter(string s)
        {
            Dictionary<char, (int count, int index)> charDict = new Dictionary<char, (int, int)>();
            for (int i = 0; i < s.Length; i++) 
            {
                char c = s[i];
                if (charDict.ContainsKey(c))
                {
                    charDict[c] = (charDict[c].count + 1, charDict[c].index);
                }
                else
                {
                    charDict[c] = (1, i);
                }
            }
            foreach (var x in charDict)
            {
                if (x.Value.count == 1)
                {
                    return x.Value.index;
                }
            }
            return -1;

        }
        public static void Main()
        {
            #region Part 1

            #region Array
            
            //Fixed-Size
            //can access elements by index .
            //Elements are stored in contiguous memory locations.

            //Time Complexity:
            //Access: O(1)
            //Search: O(n)
            //Insert: O(n)

            //Implemented Example :
        /*    int[] array = new int[] { 1, 2, 3 };
            Console.WriteLine(array[0]);
            Console.WriteLine(array[2]);*/

            #endregion

            #region NON_Generic

            #region ArrayList
            //Structure:
            //Dynamic-Sized.
            //Stores elements as objects means you can store heterogenous elements in it.

            //Time Complexity:
            //Access: O(1)
            //Search: O(n)
            //Appending: O(1)
            //Deletion: O(n)

            //Implemented Example:
            /*ArrayList arrayList = new ArrayList();
            arrayList.Add("number 1");
            arrayList.Add(19);
            arrayList.Add(true);*/
            #endregion

            #region Stack
            //Structure:
            //Last-In-First-Out (LIFO)

            //Time Complexity:
            //Access: O(n)
            //Search: O(n)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/
            #endregion

            #region Queue
            //Structure:
            //First-In-First-Out (FIFO)

            //Time Complexity:
            //Access: O(n)
            //Search: O(n)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());*/
            #endregion

            #region HashTable
            //Structure:
            //Collection of key-value pairs.
            //Keys are hashed to find corresponding values.
            //Stores elements as objects means you can store heterogenous elements in it.

            //Time Complexity:
            //Access: O(1)
            //Search: O(1)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*Hashtable siteSettings = new Hashtable();
            siteSettings["1"] = "12";
            siteSettings["2"] = 12;
            siteSettings["3"] = false;*/
            #endregion

            #region Dictionary
            //Structure:
            //Generic version of HashTable.

            //Time Complexity:
            //Access: O(1)
            //Search: O(1)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs["1"] = "12";
            pairs["1"] = "20";
            pairs["1"] = "false";*/
            #endregion

            #region HashSet
            //Structure:
            //Collection of unique elements.

            //Time Complexity:
            //Access: O(1)
            //Search: O(1)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*HashSet<string> names = new HashSet<string>();
            names.Add("youssef");
            names.Add("nabeh");
            names.Add("youssef");
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }*/
            #endregion

            #region SortedList
            //Structure:
            //Collection of key-value pairs sorted by keys.
            //Backed by two arrays.

            //Time Complexity:
            //Access: O(log n)
            //Search: O(log n)
            //Insertion: O(n)
            //Deletion: O(n)

            //Implemented Example:
            /*SortedList<string, int> Prices = new SortedList<string, int>();
            Prices["A"] = 1;
            Prices["B"] = 20;
            Prices["C"] = 15;
            foreach (var Price in Prices)
            {
                Console.WriteLine(Price.Key + ": " + Price.Value);
            }*/
            #endregion

            #region SortedDictionary
            //Structure:
            //Sorted version of Dictionary (sorted by Key)
            //Backed by a binary search tree.

            //Time Complexity:
            //Access: O(log n)
            //Search: O(log n)
            //Insertion: O(log n)
            //Deletion: O(log n)

            //Implemented Example:
            /*SortedDictionary<string, int> Prices = new SortedDictionary<string, int>();
            Prices["A"] = 1;
            Prices["B"] = 20;
            Prices["C"] = 15;*/
            #endregion

            #endregion

            #region Genaric

            #region List
            //Structure:
            //Generic version of ArrayList, providing type safety.

            //Time Complexity:
            //Access: O(1)
            //Search: O(n)
            //Insertion: O(n)
            //Appending: O(1)
            //Deletion: O(n)

            //Implemented Example:
            /*List<string> myList = new List<string> { "1", "2", "3" };
            myList.Add("4");*/
            #endregion

            #region LinkedList
            //Structure:
            //Nodes contain references to the next node.
            //Generic means it must contain one type of elements
            //Elements are stored in scattered memory locations.

            //Time Complexity:
            //Access: O(n)
            //Search: O(n)
            //Insertion: O(1)
            //Deletion: O(1)

            //Implemented Example:
            /*LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("1");
            myList.AddFirst("2");
            myList.AddLast("3");
            myList.AddFirst("4");
            myList.Remove("2");*/

            #endregion

            #endregion

            #endregion

            #region Part_2
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

            #region Q4
            /*string str = "yousseffe"; // y = 0
                int index = FirstNONRepeatedCharacter(str);
                Console.WriteLine(index);*/
            #endregion
            #endregion
        }
    }
}
