using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace HashTable
{

    /*Hashtable:
     *  Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
     *      Key đại diện cho 1 khoá giống như chỉ số phần tử của mảng
     *      Value chính là giá trị tương ứng của khoá đó.
     *  Ta sẽ dử dụng Key để truy cập đến Value tương ứng.
    Do Hashtable là 1 Collections nên để sử dụng ta cần thêm thư viện:*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashTable:");
            #region Hashtable

            #region khoi tao hashtabble

            /*Vì Hashtable là một lớp nên trước khi sử dụng 
             * ta cần khởi tạo vùng nhớ bằng toán tử new:*/
            Hashtable myHash = new Hashtable(); //khoi tao hashtable rong
            Hashtable myHash2 = new Hashtable(5); //ktao hashtable vs capacity chi dinh = 5

            myHash.Add("Hello", "Christmass");
            myHash2.Add("Happy New Year", "2024");

            /*khoi tao 1 hashtbale co kich thuoc bang vs myHash2
             sao chep toan bo phan tu trong myHash2 vao myHash3*/
            Hashtable myHash3 = new Hashtable(myHash2);

            #endregion

            #region 1 so thuoc tinh cua hashtable
            /*Mỗi một phần tử trong Hashtable (bao gồm 1 cặp Key - Value)
             * được C# định nghĩa là 1 đối tượng có kiểu DictionaryEntry.*/
            Hashtable hash = new Hashtable();
            hash.Add("Hello", "Say Something");
            //Add(object Key, object Value)
            hash.Add("Hi", "Something");
            hash.Add("Wow", "Something is real");

            /* 
             * Duyệt qua các phần tử trong Hashtable.
             * Vì mỗi phần tử là 1 DictionaryEntry 
             * nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
             * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
             */

            //khi in ra hashtable se tu sap xep san theo thuat toan cua hashtable
            //chu ko theo thu tu dc add vao

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }


            Console.WriteLine("\n" + hash["Hello"]); //in ra value cua key Hello: Say Something

            //neu thuc hien lay value trong hash thong qua key ko ton tai
            //thi se ra la null va ko bao loi

            //neu gan value trong hash tai vi tri key ko ton tai
            //thi hash se tu them 1 ptu moi voi key va value nhu tren

            Console.WriteLine("\nhash[\"VV\"] = " + hash["VV"]); //hash[VV] = 
            if (hash["VT"] == null)
            {
                Console.WriteLine("Key VT is not exists");
            }

            //thu in ra so phan tu ban dau cua hashtable
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            //thuc hien gan value 1 key ko ton tai
            hash["Tv"] = "Exists";
            hash["Add"] = "Random";

            //thuc hien in lai so phan tu cua hashtable de thay su thay doi
            Console.WriteLine();
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }


            #endregion

            #endregion
             Console.WriteLine("_________________________________");
           
            
            Console.ReadKey();
        }
    }
}
