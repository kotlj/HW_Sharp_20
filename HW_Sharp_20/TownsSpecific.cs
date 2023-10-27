using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_20
{
    internal class TownsSpecific
    {
        static public IEnumerable<string> ReturnAll(string[] towns)
        {
            IEnumerable<string> res = from town in towns select town;
            return res;
        }
        static public IEnumerable<string> GetWithLenght(string[] towns, int lenght)
        {
            IEnumerable<string> res = from town in towns where town.Length == lenght select town;
            return res;
        }
        static public IEnumerable<string> StartWith_K(string[] towns)
        {
            IEnumerable<string> res = from town in towns where town.ToUpper().StartsWith("K") select town;
            return res;
        }
        static public IEnumerable<string> EndWith_M(string[] towns)
        {
            IEnumerable<string> res = from town in towns where town.ToUpper().EndsWith("M") select town;
            return res;
        }
        static public IEnumerable<string> Start_N_End_K(string[] towns)
        {
            IEnumerable<string> res = from town in towns where town.ToUpper().StartsWith("N") && town.ToUpper().EndsWith("K") select town;
            return res;
        }
        static public IEnumerable <string> StartWith_Ne_Descend(string[] towns)
        {
            IEnumerable<string> res = from town in towns where town.StartsWith("Ne") orderby town select town;
            res = Enumerable.Reverse(res);
            return res;
        }
    }
}
