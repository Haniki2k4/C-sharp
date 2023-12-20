using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace HashTable
{
    /*Stack:
            là một cấu trúc dữ liệu hoạt động theo nguyên lý LIFO (Last In First Out)
        -Là một danh sách lưu trữ các đối tượng 
            +nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
        -Hành động thêm phần tử vào Stack được gọi là Push (đẩy vào).
        -Hành động lấy phần tử ra khỏi Stack được gọi là Pop (đẩy ra). 
            +Và luôn luôn lấy ra phần tử được thêm vào cuối cùng.
        -Hành động Peek lấy phần tử ra khỏi nhưng không xóa ptu đấy*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("Stack:");
            #region Stack
            //ktao
            Stack myStack = new Stack();
            Stack myStack2 = new Stack(5);

            //khoi tao 1 mang bat ky
            ArrayList myArray = new ArrayList();
            myArray.Add(5);
            myArray.Add(10);
            myArray.Add(15);
            //khoi tao 1 stack va sao chep gia tri cuar cac ptu myArray vafo stack
            Stack myStack3 = new Stack(myArray);
            #region su dung stack
            myStack.Push("Education");
            myStack.Push("Free");
            myStack.Push("Chritmas");
             
            //sdung cac phg thuc cua stack 
            Console.WriteLine("So phan tu cua stack: {0}", myStack.Count);

            //khi muon xem gia tri ptu dau cua stack ma ko xoa ptu thi dung peek
            Console.WriteLine("Phan tu dau cua stack la: {0}", myStack.Peek());

            //ktr lai xem so ptu sau khi goi peek de chac chan rang peek ko xoa ptu khoi stack
            Console.WriteLine("So phan tu sau khi goi Peek: {0}", myStack.Count);

            //thuc hien goi pop
            Console.WriteLine("Su dung Pop.....");
            for (int i = 0; i <= myStack.Count; i++)
            {
                Console.WriteLine(" " + myStack.Pop());

            }
            Console.WriteLine();

            //kiem tra lai so ptu sau khi sdung pop
            Console.WriteLine("So phan tu con lai sau khi goi pop: {0}", myStack.Count);
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
