using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class BubbleSort<T>
    {
       // public delegate bool Compare(T a, T b);
      //  public T[] Sort(T[] items, Compare compare) 
        public T[] Sort(T[] items, Func <T,T,bool> compare) 
        {
            bool flag = true;
            int itemNumber = items.Length;
            T temp;
           for (int i = 0; i< itemNumber && flag; i++)
           {
                 flag = false;
                for(int j=0; j < items.Length - 1 - i; j++)
                {
                    
                    if (compare(items[j] , items[j+1]))
                    {
                        temp = items[j];
                        items[j] = items[j+1];
                        items[j+1] = temp;
                        flag = true;
                    }
                }
           }
            return items;
        }
    }
}
