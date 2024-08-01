using System.Collections;

namespace Assm2_ADV
{
    internal class Program
    {
        public static int SumarrrayList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList is not null)           
                for (int i = 0; i < arrayList.Count; i++)
                    sum += (int)arrayList[i];
                
            
            return sum;
        }

        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                    sum += list[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region NOnGeneric

            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add( 1 );

            //Console.WriteLine("After Adding First Element");
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");


            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add(5);

            //Console.WriteLine("After Adding 5th Element");
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList(5) { 1 , 2 ,3 ,4 ,5 };
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");
            //arrayList.Add(6);


            //Console.WriteLine("After Adding 6th Element");
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.TrimToSize();


            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Cpunt Of arraylist = {arrayList.Count} , Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add(1);
            //arrayList.Add("Ahmed");

            //int Result = SumarrrayList(arrayList);
            // Console.WriteLine(Result);
            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //};
            #endregion

            #region Generic Collection = list
            //List<int> Number = new List<int>();
            //Console.WriteLine($"Cpunt Of List = {Number.Count} , Capacity of arraylist = {Number.Capacity}");

            //Number.Add(1);
            //Console.WriteLine($"Cpunt Of List = {Number.Count} , Capacity of arraylist = {Number.Capacity}");

            //Number.Add(2);
            //Number.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Cpunt Of List = {Number.Count} , Capacity of arraylist = {Number.Capacity}");
            //List<int> Number = new List<int>(5) { 1 , 2 , 3 , 4 , 5};
            //Console.WriteLine($"Cpunt Of List = {Number.Count} , Capacity of arraylist = {Number.Capacity}");


            //Number.Add(6);
            //Console.WriteLine($"Cpunt Of List = {Number.Count} , Capacity of arraylist = {Number.Capacity}");

            //foreach (int item in Number)
            //    Console.WriteLine(item);

            //Number[3] = 40;
            //for(int i = 0; i < Number.Count; i++)
            //   Console.WriteLine(Number[i]);

            ////Number.Add(100);


            //int Result = SumList(Number);
            //Console.WriteLine(Number);
            #endregion

            #region List Methods
            //Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");

            //Numbers.Add(5);
            ////Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");

            //Numbers.AddRange(new int[] { 6 , 7});
            //Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");
            //Numbers.Insert(6, 8);
            //Numbers.InsertRange(4, new int[] { 9, 10 });


            //foreach (int item in Numbers)
            //    Console.WriteLine($" {item}");

            //Console.WriteLine("\n=================");
            //int index = Numbers.BinarySearch(100);
            //Console.WriteLine(index);


            //Numbers.Clear();
            //Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");

            //Console.WriteLine(Numbers.Contains(100));

            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };

            //int[] array = new int[10];

            ////Numbers.CopyTo(array , 3);

            ////Numbers.CopyTo(1, array , 5 , 3 );
            //foreach (int i in array)
            //    Console.WriteLine(i);


            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };
            //Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");
            //Numbers.EnsureCapacity(10);
            //Console.WriteLine($"Cpunt Of List = {Numbers.Count} , Capacity of arraylist = {Numbers.Capacity}");

            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5,4,3,2,5 };

            //foreach (int num in Numbers) 
            //    Console.WriteLine(num);

            //Numbers.Remove(3);
            //Numbers.TrueForAll();
            //Console.WriteLine("=============");

            //foreach (int num in Numbers)
            //    Console.WriteLine(num);

            //int index = Numbers.LastIndexOf(3);
            //Console.WriteLine(index);



            #endregion

            #region Generic Collections - lists

            //LinkedList<int> linkedList = new LinkedList<int> ();
            //Console.WriteLine(linkedList.Count);

            //linkedList.AddFirst(1);
            //linkedList.AddLast(2);
            //LinkedListNode<int> AfterNode = linkedList.Find(1);
            ////LinkedList.AddAfter(2);
            ////Console.WriteLine(LinkedList.Count);
            //linkedList.AddAfter(AfterNode, 5);
            //linkedList.AddBefore(linkedList.Find(2) , 10);
            //foreach (int i in linkedList)
            //    Console.WriteLine(i);
            //Console.WriteLine(linkedList.Count);
 
            #endregion
        }
    }
}
