using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region khai báo với mảng 1 chiều
            int[] IntArray = { 1, 5, 2, 4, 6 };
            int Sum = 0;

            /*
             * Sử dụng foreach để duyệt mảng và in giá trị của các phần tử trong mảng.
             * Đồng thời tận dụng vòng lặp để tính tổng các phần tử trong mảng.
             */
            foreach (int item in IntArray) //từng phần tử cảu mảng được lưu vào biến tạm item
            {
                Console.Write("\t" + item);
                Sum += item;
            }

            Console.WriteLine("\n Sum = " + Sum);
            #endregion


            #region khai báo với mảng jagged
            int[][] JaggedArray =
                            {
                                new int[] { 1, 2, 3 },
                                new int[] { 5, 2, 4, 1, 6},
                                new int[] { 7, 3, 4, 2, 1, 5, 9, 8}
                            };
            /*
             * Tương tự như dùng for, ta cũng dùng 2 vòng foreach lồng vào nhau để duyệt mảng.
             */
            foreach (int[] Element in JaggedArray)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
            #endregion

            // In ra các phần tử trong một mảng
            string[] names = { "John", "Mary", "Peter", "Susan" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            #region exercise with foreach
            /*Viết chương trình cho người dùng nhập vào 1 tháng bất kỳ từ 1-12.
             cho biết tháng đó có bao nhiêu ngày*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mơi nhập vào 1 tháng: ");
            int thang = int.Parse(Console.ReadLine());
            int[] list31 = { 1, 3, 5, 7, 9, 11 }; ////khởi tạo 1 list
            int[] list30 = {4, 6, 8, 10, 12};
            foreach (int i in list31)
            {
                    if (thang == i) 
                    { 
                        Console.WriteLine("Tháng {0} có 31 ngày!", thang);
                        break; //tìm được gtri r thì dùng break để thoát lặp
                    }
            }
            foreach (int j in list30)
            {
                if (thang == j)
                    {
                        Console.WriteLine("Tháng {0} cso 30 ngày!", thang);
                        break;
                    }
            }
            
            if (thang == 2)
            {
                Console.WriteLine("Mời bạn nhập vào số năm: ");
                int year = int.Parse(Console.ReadLine());
                if (year % 4 == 0)
                    Console.WriteLine("Tháng 2 năm {0} có 28 ngày", year);
                else if (year % 4 != 0)
                    Console.WriteLine("Tháng 2 năm {0} có 29 ngày", year);
            }


            #endregion

            Console.ReadKey();
        }
    }
}
