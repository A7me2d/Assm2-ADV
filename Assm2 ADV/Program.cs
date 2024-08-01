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


        }
    }
}
