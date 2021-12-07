using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_DictionarySortedListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic olmayan koleksiyon davranışı..
            Hashtable htList = new Hashtable();
            htList.Add(1, "Bir");
            htList.Add(2, "İki");
            htList.Add(3, "Üç");
            //htList.Add(1, "Test");

            //Dictionary<Tkey, TValue>
            Dictionary<int, string> dList = new Dictionary<int, string>();
            dList.Add(1, "Bir");
            dList.Add(2, "İki");
            dList.Add(3, "Üç");
            //dList.Add(3, "Test");

        }
    }
}
