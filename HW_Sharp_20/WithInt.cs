using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_20
{
    internal class WithInt
    {
       static public IEnumerable<int> ReturnAll(int[] numbs)
        {
            IEnumerable<int> arr = from num in numbs select num;
            return arr;
        }
        static public IEnumerable<int> EvenNumbs(int[] numbs)
        {
            IEnumerable<int> arr = from num in numbs where num % 2 == 0 select num;
            return arr;
        }
        static public IEnumerable<int> OddNumbs(int[] numbs)
        {
            IEnumerable<int> arr = from num in numbs where num % 2 != 0 select num;
            return arr;
        }
        static public IEnumerable<int> MoreThen(int[] numbs, int moreThen)
        {
            IEnumerable<int> arr = from num in numbs where num > moreThen select num;
            return arr;
        }
        static public IEnumerable<int> InArea(int[] numbs, int bottom, int roof, bool include = true)
        {
            if(include)
            {
                IEnumerable<int> arr = from num in numbs where num >= bottom && num <= roof select num;
                return arr;
            }
            else
            {
                IEnumerable<int> arr = from num in numbs where num > bottom && num < roof select num;
                return arr;
            }    
        }
        static public IEnumerable<int> MultySeven(int[] numbs)
        {
            IEnumerable<int> arr = from num in numbs where num % 7 == 0 orderby num select num;
            return arr;
        }
        static public IEnumerable<int> MultyEleven(int[] numbs)
        {
            IEnumerable<int> arr = (from num in numbs where num % 8 == 0 orderby num select num);
            arr = Enumerable.Reverse(arr);
            return arr;
        }
    }
}
