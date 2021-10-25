using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("1.Count");
            string[] empty = new string[6];
            var totalElements = empty.Count(); 
            Console.WriteLine("Indexin sayi: "+ empty.Count());
            #endregion\
            #region
            Console.WriteLine("2.Clear()");
            int[] arr = new int[] { 1, 2, 3 };
            Console.WriteLine("Array (Old):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }

            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Array (Clear etdikden sonra):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
            #endregion
            #region
            Console.WriteLine("3.Remove");

            string[] myArray = 
             {
            "Cavad",
            "Cavad1",
            "Cavad2",
            "Cavad3",
            "Cavad4"
             };
            Console.WriteLine("Array before deletion");
            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }
            int indexToRemove = 3;
            myArray = myArray.Where((source, index) => index != indexToRemove).ToArray();
            Console.WriteLine("Array after deletion");

            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }
            #endregion
            #region
            Console.WriteLine("4.Find");
            try 
            {

                
                String[] myArr = { "Mavad", "Ravad", "Javad", "Cavad" };

                
                Console.WriteLine("Daxil olan arrlar:");

                
                PrintIndexAndValues(myArr);

                
                string value = Array.Find(myArr,
                           element => element.StartsWith("C",
                           StringComparison.Ordinal));

                
                Console.Write("Cixarilan arr: ");

                
                Console.Write("{0}", value);
            }
            catch (ArgumentNullException e)
            {

                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
        }

        
        public static void PrintIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {

                Console.WriteLine("{0}", myArr[i]);
            }
            Console.WriteLine();
         }
        #endregion

    }
}
