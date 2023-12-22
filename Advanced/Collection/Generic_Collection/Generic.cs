using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic
            /*cho phép bạn định nghĩa một hàm, một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì. 
             *Tuỳ vào kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó.*/

            int a = 5, b = 7;
            double c = 1.2, d = 5.6;

            ///GENERIC CHO PHUONG THUC
            //gọi cú pháp bên dưới thì hàm Swap sẽ chạy và thay ký tự T thành kiểu dữ liệu int tương ứng
            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);

            ///GENERIC CHO LOP
            //khoi tao 1 mang so nguyen kieu int co 5 phan tu
            MyGeneric<int> myG = new MyGeneric<int>(5);
            myG.SetItemValue(0, 10);

            #endregion

            Console.ReadKey();
        }
      
        #region Generic
        //bạn muốn hàm hoán đổi giá trị 2 số nguyên ta sẽ viết như sau:
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //Nhưng khi bạn hoán đổi 2 số thực.
        //Khi đó bạn phải viết lại 1 hàm Swap mới với kiểu dữ liệu của tham số truyền vào là kiểu số thực.

        //Nếu sử dụng Generic Bạn chỉ cần đặt 1 chữ cái nào đó thay cho kiểu dữ liệu
        //và khi gọi hàm bạn chỉ ra kiểu dữ liệu bạn đang thao tác là gì.
        public static void Swap<T> (ref T a, ref T b) //dùng T hay bất kì chữ cái gì cx đc 
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //Generic cho class
            public class MyGeneric<T>
            {
                private T[] items;

                public T[] Items
                {
                    get { return items; }
                }

                public MyGeneric(int Size)
                {
                    items = new T[Size];
                }

                public T GetByIndex(int Index)
                {
                    // Nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
                    if (Index < 0 || Index >= items.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        return items[Index];
                    }
                }

                public void SetItemValue(int Index, T Value)
                {
                    if (Index < 0 || Index >= items.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        items[Index] = Value;
                    }
                }
            }


        #endregion

    }
}
