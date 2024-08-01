using System.Collections;

namespace Assm2_ADV
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

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        static void Main(string[] args)
        {

            #region Part01

            //===============Arrays============
            //int[] temperatures = new int[7] { 30, 32, 31, 29, 28, 33, 34 };
            //Console.WriteLine(temperatures[0]);

            //===============Lists============
            //List<int> orders = new List<int> { 101, 102, 103 };
            //orders.Add(104); 
            //Console.WriteLine(orders[3]); 

            //==============Dictionaries========
            //Dictionary<int, string> userProfiles = new Dictionary<int, string>
            //{
            //{ 1, "Alice" },
            //{ 2, "Bob" }
            //};
            //Console.WriteLine(userProfiles[1]);

            //=============HashSets============
            //HashSet<string> emails = new HashSet<string> { "alice@example.com", "bob@example.com" };
            //emails.Add("charlie@example.com");
            //Console.WriteLine(emails.Contains("bob@example.com"));

            //============Queues==============
            //Queue<string> tasks = new Queue<string>();
            //tasks.Enqueue("Task1");
            //tasks.Enqueue("Task2");
            //Console.WriteLine(tasks.Dequeue()); 

            //============Stacks===============
            //Stack<string> history = new Stack<string>();
            //history.Push("State1");
            //history.Push("State2");
            //Console.WriteLine(history.Pop());

            #endregion

            #region Part02 A1
            //ArrayList myList = new ArrayList { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original ArrayList:");
            //foreach (var item in myList)
            //{
            //    Console.Write(item + " ");
            //}

            //ReverseArrayList(myList);

            //Console.WriteLine("\nReversed ArrayList:");
            //foreach (var item in myList)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Part02 A2
            //List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = GetEvenNumbers(myNumbers);

            //Console.WriteLine("Even numbers:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region Part02 A3
            //try
            //{
            //    FixedSizeList<int> myList = new FixedSizeList<int>(5);

            //    myList.Add(1);
            //    myList.Add(2);
            //    myList.Add(3);
            //    myList.Add(4);
            //    myList.Add(5);


            //    for (int i = 0; i < myList.Count; i++)
            //    {
            //        Console.WriteLine(myList.Get(i));
            //    }

       
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

        }
    }
}
