using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCodes
{
    class Compare : IComparable
    {

        private string ln;
        public string Ln
        {
            get { return ln; }
            set { ln = value; }
        }
        
        //------------------------------------------------------
        // Returns a bool indicating equality of object contents
        //------------------------------------------------------
        public int CompareTo(object newObject)
        {
            return Ln.CompareTo(
              ((Employee)newObject).Ln);
            //return -1 (if current object is less than newObject) 
            //or 0 (if current object is equal newObject)
            //or +1 (if current object is greater than newObject)
        }

        /************************
        ** Sorts the specified array of objects using
        ** the selection sort algorithm.
            **********************************/
        public static void SelectionSort(IComparable[] array)
        //receiving as parameter an array of IComparable objects
        {
            // The change here is to choose the largest value
            int max_value_postion;
            int length = array.GetLength(0);

            IComparable anObjectTemp;

            for (int i = 0; i < length - 1; i++)
            {
                max_value_postion = i;
                for (int j = i + 1; j < length; j++)
                    if (array[j].CompareTo(array[max_value_postion]) < 0)    // Changed from >
                        max_value_postion = j; //max holds the position of the greatest value

                //Swap the values
                anObjectTemp = array[max_value_postion];
                array[max_value_postion] = array[i];
                array[i] = anObjectTemp;
            }
        }

        Console.WriteLine("\n*******************************************\n");
        Console.Out.WriteLine("Selection Sort Results in ascending order\n");
        Sorting.SelectionSort(arrOfEmployees);
        foreach (Employee friend in arrOfEmployees)
            Console.Out.WriteLine("\t" + friend); 
    }
}
