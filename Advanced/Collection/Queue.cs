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
            #region Queue
            //Queue(hàng đợi): là một cấu trúc dữ liệu hoạt động theo nguyên lý FIFO (First In First Out)
            /*Là một danh sách lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
               -Hành động thêm phần tử vào Queue  được gọi là Enqueue (xếp hàng).
               -Hành động lấy phần tử ra khỏi Queue được gọi là Dequeue (ra khỏi hàng). 
                    Và luôn luôn lấy ra phần tử được thêm vào đầu tiên.*/

            Queue myQueue = new Queue();
            Queue myQueue2 = new Queue(5);

            //khoi tao mang
            ArrayList myArray = new ArrayList();
            myArray.Add(5);
            myArray.Add(28);
            myArray.Add(35);

            //khoi tao queue va sao chep gia tri cua cac phan tu myArray vao queue
            Queue myQueue3 = new Queue(myArray);

            //them phan tu vao queue thong qua ham Enqueue
            myQueue.Enqueue("Hellooo");
            myQueue.Enqueue("Good Afternoon");
            myQueue.Enqueue("Have a good work");

            Console.WriteLine("So phan tu cua queue la: {0}", myQueue.Count);
            Console.WriteLine("Phan tu dau tien cua Queue la: {0}", myQueue.Peek()); //xem gia tri ma ko xoa khoi queue
            //thuc hien lay phan tu ra khoi queue xem va sau do xoa ptu do thong qua Dequeue
            Console.WriteLine("Poping.....");
            for (int i = 0; i < myQueue.Count; i++)
            {
                Console.WriteLine(" " + myQueue.Dequeue());
            }
            Console.WriteLine();

            //ktra so phan tu con lai sau khi Dequeue
            Console.WriteLine("So phan tu con lai cua Queue sau khi Dequeue la: {0}", myQueue.Count);

            #endregion

            Console.ReadKey();
        }
    }
}
