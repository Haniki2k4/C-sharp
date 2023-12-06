using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Beginner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for ([Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại])
             *   {
             *      // Khối lệnh được lặp lại. Có thể bỏ trống
             *   }
             *      Trong đó:
             *          Các phần [Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại] hoàn toàn có thể để trống như ví dụ sau.
             *          Mỗi đoạn [Khởi tạo]; hay [Điều kiện lặp]; hay [Bước lặp lại] là một câu lệnh riêng
             *      Tiến trình:
             *          Ban đầu trình biên dịch sẽ di vào phần khởi tạo chạy đoạn lệnh khởi tạo.
             *          Tiếp theo kiểm tra điều kiện lặp. Rồi thực hiện khối code bên trong vòng lặp for. 
             *          Khi đến ký hiệu } thì sẽ quay lên bước lặp lại.
             *          Sau đó lại kiểm tra điều kiện lặp rồi tiếp tục thực hiện đoạn code trong khối lệnh. 
             *          Đến khi điều kiện lặp không còn thõa mãn thì sẽ kết thúc vòng lặp for.
             */
             
            /*Trường hợp khác:
             *for (; ;)   // lưu ý dấu ;
             *   {
             *      // Khối lệnh được lặp lại. Có thể bỏ trống
             *   }
             *      Trong đó:
             *          Vòng lặp for này trở thành vòng lặp vô tận.
             *          Lưu ý dấu ; vẫn phải có.*/
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }

            int j;
            for (j = 0; false;) // true: đem lại loop vô tận, false: đkien không hợp lệ nên không chạy
            {
                Console.WriteLine(j);
                j++;
            }

            //Chúng ta có thể thực hiện nhiều đoạn lệnh trong [bước lặp lại]

                int h;
                int k = 0;
                for (h = 0; h < 10; h++, k += 3)
                {
                    Console.WriteLine(h);
                }
            
        /*Ta thấy đoạn i++và j += 3 được cách nhau bởi dấu phẩy(,)
         * Với mỗi đoạn lệnh trong bước lặp.Chúng đươc phân cách nhau bởi dấu phẩy(,)
         * Lưu ý: Đoạn code trong bước lặp còn có thể thêm cả Console.WriteLine("Tăng") vào(khuyến cáo không nên).
         * Nhưng không thể thực hiện đoạn code có chứa từ khóa(như if, for …).*/
                int a;
                int b = 0;
                for (a = 0; a < 10; a++, b += 3, Console.WriteLine("Tăng"))
                {
                    Console.WriteLine(a);
                }
            //Kết quả xuất dòng chữ "Tăng" mỗi khi lặp lại.

            /*Write m program that accepts two integers m and n from the user then checks the following conditions:
             * If m is greater than or equal to n, print the following line on the screen:
             *          m is greater than or equal to n
             * otherwise, if m is smaller than n, print the following line on the screen:
             *          m is smaller than n*/
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                if (m < n)
                    Console.WriteLine("a is smaller than b");
                else if (m >= n)
                    Console.WriteLine("a is greater than or equal to b");

            /*Write a program that accepts the names of two people from the user then checks whether  these two names are the same or not.
             * If two names are the same, print the following line on the screen:
             *      two people have the same name
             * If two names are different, print the following line on the screen:
             *      two people don't have the same name
             */
            string g = Console.ReadLine();
            string f = Console.ReadLine();

            if (g == f)
                Console.WriteLine("two people have the same name");
            else if (g != f)
                Console.WriteLine("two people don't have the same name");

            /*Write a program that accepts three integers from the user 
             * and prints the biggest number among them on the screen.
             */
            int e = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            if (e >= t && e >= x)
            {
                Console.WriteLine(e);
            }
            if (t >= e && t >= x)
            {
                Console.WriteLine(t);
            }
            if (x >= e && x >= t)
            {
                Console.WriteLine(x);
            }

            /*vẽ hình chữ nhật */
            int N = 10;
            int M = 20;

            char drawChar = '*';
            char insideChar = ' ';


            // Vẽ từ trên xuống
            for (int i = 0; i < N; i++)
            {
                // Vẽ từ trái sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */

                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
                //mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();
            }
            Console.ReadKey();*/
            
        }
    }
}
