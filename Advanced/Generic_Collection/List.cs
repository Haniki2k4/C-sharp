using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*List là 1 Generic Collections đưa ra như một sự thay thế ArrayList 
             * vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList.*/

            //giúp lưu trữ và quản lý một danh sách các đối tượng theo kiểu mảng
            //(truy cập các phần tử bên trong thông qua chỉ số index).

            List<int> myList = new List<int>();
            List<int> myList2 = new List<int>(5);
            List<int> myList3 = new List<int>(myList2); //sao chep phan tu cua myList2

            //su dung list
            List<string> myList4 = new List<string>();
            myList4.Add("Hiiiiiiii");
            myList4.Add("Have a good day");
            myList4.Add("Something");

            Console.WriteLine("List ban dau: ");
            Console.WriteLine("So luong phan tu trong list: {0}", myList4.Count);
            foreach (string item in myList4)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine();

            //chen 1 phan tu vao list
            myList4.Insert(0, "I know");

            //ktra lai xem ptu da dc chen vao chua
            Console.WriteLine("List sau khi insert: ");
            Console.WriteLine("So luong phan tu trong list: {0}", myList4.Count);
            foreach (string item in myList4)
            {
                Console.WriteLine(" " + myList4);
            }
            Console.WriteLine();

            //ktra 1 phan tu co ton tai trong list hay khong
            bool eXist = myList4.Contains("I know");
            if (!eXist)
            {
                Console.WriteLine("Khong tim thay phan tu trong list!");
            }
            else
            {
                Console.WriteLine("Da tim thay phan tu trong list");
            }
            
            bool eXist1 = myList4.Contains("Haiii");
            if (!eXist1)
            {
                Console.WriteLine("Khong tim thay phan tu trong list!");
            }
            else
            {
                Console.WriteLine("Da tim thay phan tu trong list");
            }
            #endregion



            Console.ReadKey();
        }
    }
}
