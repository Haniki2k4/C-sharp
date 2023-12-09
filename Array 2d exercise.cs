using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool checkRows, checkColumns;
            int N, M;
            do
            {
                do
                {

                    Console.Write("Mời bạn nhập số dòng mảng: ");
                    string Rows = Console.ReadLine();
                    checkRows = int.TryParse(Rows, out N);
                    /*Thử chuyển đổi chuỗi Rows thành một số nguyên (int).
                Nếu quá trình chuyển đổi thành công, giá trị số nguyên sẽ được gán vào biến N, 
                và kết quả của hàm int.TryParse() sẽ là true.
                Nếu không thành công giá trị của N không thay đổi và kết quả của int.TryParse() sẽ là false.*/
                    Console.Write("Mời bạn nhập số cột mảng: ");
                    string Columns = Console.ReadLine();
                    checkColumns = int.TryParse(Columns, out M);

                    if (!checkRows || !checkColumns || N <= 0 || M <= 0)
                    {
                        Console.WriteLine("Vui lòng nhập số nguyên dương!!!\n");
                    }
                    else Console.WriteLine();

                } while (N <= 0 || M <= 0); /*Vòng lặp này chạy khi số dòng hoặc số cột nhập vào 
                                             * là số âm hoặc bằng 0.
                                            Người dùng được yêu cầu nhập lại số dòng và số cột 
                                            cho đến khi cả hai số đều là số nguyên dương.*/
            } while (!checkRows || !checkColumns);
            /*Vòng lặp này chạy cho đến khi cả số dòng (N) và số cột (M) nhập vào đều hợp lệ.
            Biến checkRows và checkColumns kiểm tra xem người dùng đã nhập đúng kiểu dữ liệu (số nguyên) hay không.*/

            int i = 0;
            int j = 0;
            bool checkA;
            int[,] arrayA = new int[N, M];
            while (i < N) //Vòng lặp này duyệt qua các hàng của mảng arrayA.
                //Với mỗi hàng, nó sẽ chạy vòng lặp while (j < M) để điền các giá trị của cột tương ứng
            {
                j = 0;
                while (j < M) //Vòng lặp này duyệt qua các cột của mảng arrayA tại hàng i.
                        //Người dùng được yêu cầu nhập giá trị của từng phần tử tại vị trí[i, j] trong mảng.
                {
                    Console.Write("Phần tử của [{0},{1}]: ", i, j);
                    string strA = Console.ReadLine();
                    checkA = int.TryParse(strA, out arrayA[i, j]);
                    //chuyển đổi một chuỗi strA thành một số nguyên và gán giá trị đó
                    //vào phần tử của mảng hai chiều arrayA tại vị trí [i, j]
                    if (!checkA)
                    {
                        Console.WriteLine("Vui lòng nhập số nguyên của giá trị phần tử!\n");
                    }
                    else j++;

                }
                i++;
            }

            int sum = 0;
            Console.WriteLine("\nMảng có phần tử là:");
            do
            {
                i = 0;
                while (i < N)
                {
                    j = 0;
                    while (j < M)
                    {
                        Console.Write(arrayA[i, j] + " ");
                        sum += arrayA[i, j];
                        j++;
                    }
                    Console.WriteLine();
                    i++;
                }
            } while (false);
            Console.WriteLine("\nTổng giá trị của mảng là: " + sum);

            /*for (i = 0; i < mang.GetLength(0); i++)
            {
                for (j = 0; j < mang.GetLength(1);)
                {
                    Console.Write("Nhập phần tử của [{0}, {1}]: ", i,j);
                    string strA = Console.ReadLine();
                    checkA = int.TryParse(strA, out mang[i, j]);
                    if (!checkA)
                    {
                        Console.WriteLine("Mời bạn nhập lại số dương!");
                    }
                    else j++;
                }
            }

            int sum = 0;
            Console.WriteLine("\n Mảng bạn vừa nhập là: ");
            for (i = 0; i < mang.GetLength(0); i++)
            {
                for(j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i, j] +" ");
                    sum += mang[i, j];
                }
                Console.WriteLine(); 
            }
            Console.WriteLine("Tổng các giá trị trong mảng: " + sum);
*/


            Console.ReadKey();
        }
    }
}
