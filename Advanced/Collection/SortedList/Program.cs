using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace HashTable
{
    /*SortedList:
           *Cũng là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
        -Là 1 Hashtable nhưng các giá trị được sắp xếp theo Key. 
            +Việc sắp xếp này được thực hiện một cách tự động mỗi khi thêm 1 phần tử mới vào SortedList.
        -Có thể truy xuất đến các phần tử trong SortedListthông qua Key(như Hashtable) 
            +hoặc thông qua chỉ số phần tử (như ArrayList).
    SortedList chính là sự kết hợp giữa ArrayList với Hashtable .*/
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("SortedList:");
            #region SortedList

                #region khoi tao sortedlist
                SortedList myStL = new SortedList();
                SortedList myStL2 = new SortedList(5);

                SortedList myStL3 = new SortedList(myStL2);

                /*dnghia 1 lop PersonComparer co thuc thi 1 interface IComparer
                 sau do override lai phuong thuc Compare
                sdung lop tren de truyen vao constructor cua SortedList*/
                SortedList myStL4 = new SortedList(new PersonComparer());

                SortedList myStL5 = new SortedList(myStL3, new PersonComparer());

                #region vi du su dung Sortedlist
                //tao 1 sortedlist va truyen vao cach sap xep trong sortedlist
                myStL4.Add(new Person("Helloooooo", 20), 10);
                myStL4.Add(new Person("Helloooooo", 2), 15);

                foreach (DictionaryEntry item in myStL4)
                {
                    Console.WriteLine("Key: "+item.Key + "\nValue: "+item.Value);
                }

            #endregion
            #endregion
            #endregion
            Console.WriteLine("_________________________________");
            
            Console.ReadKey();
        }

        #region class SortedList
        class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Person a = x as Person;
                Person b = y as Person;
                    
                if ( a == null || b == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (a.Age > b.Age)
                    {
                        return 1;
                    }
                    else if (a.Age == b.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        #endregion
    }
}
