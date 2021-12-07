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

            bool silmeSonuc = dList.Remove(1);
            if (silmeSonuc)
                Console.WriteLine("Silindi");
            else
                Console.WriteLine("Aranan değer liste içerisinde bulunamadı. Silme işlemi başarısız!");

            bool arananDegerSonuc = dList.ContainsKey(1);
            if (arananDegerSonuc)
            {
                //string gelenDeger = dList[1];
                string gelenDeger = "Yenilenen Değer";
                dList[1] = gelenDeger;
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı.");
            }

            bool arananDeger = dList.ContainsValue("Üç");
            if(arananDeger)
                Console.WriteLine("Aranan değer bulundu.");
            else
                Console.WriteLine("Aranan değer bulunamadı.");

            foreach (KeyValuePair<int, string> item in dList)
            {
                Console.WriteLine("Anahtar : {0} && Değer : {1}", item.Key, item.Value);
            }

            dList.Clear();

        }
    }
}
