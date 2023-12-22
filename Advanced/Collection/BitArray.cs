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
            #region BitArray
            ///một Collections giúp quản lý, lưu trữ một danh sách các bit (0 hoặc 1), 
            ///được biểu diễn như kiểu Boolean (kiểu luận lý). 
            ///Trong đó true biểu thị cho bit 1 và false biểu thị cho bit 0.   
            ///mỗi phần tử chỉ tốn đúng 1 bit

            //Mỗi phần tử có giá trị mặc định 0 (false).
            BitArray MyBA = new BitArray(10); //không thể khởi tạo 1 BitArray rỗng!

            // Mỗi phần tử có giá trị mặc định 1 (true).
            BitArray myBA = new BitArray(10, true);

            //khoi tao bitarray tu 1 mang bool cho san
            bool[] Bools = new bool[5] { true, true, false, true, false };
            BitArray myBa4 = new BitArray(Bools);
            Console.WriteLine("so bit cua BitArray la: {0}", myBa4.Length);

            //khoi tao bitArrat tu 1 mang byte cho san
            byte[] myByte = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray myBa5 = new BitArray(myByte);
            Console.WriteLine("so bit cua BitArray tao tu 1 mang bool la: {0}", myBa5.Length);

            //khoi tao 1 bitarray tu 1 mang int cho san
            int[] myInt = new int[5] { 1, 2, 3, 4, 5};
            BitArray myBa6 = new BitArray(myInt);
            Console.WriteLine("So bit cua BitArray tao tu 1 mang in la: {0}", myBa6.Length);

            /* AND, OR, XOT, XOR
             cac phep toan phai dc thuc hien tren 2 BItArray co cung do dai neu khong se xay ra loi
             cac phep toan se lm thay doi ca BitArray goi no*/
            BitArray A = new BitArray(5);
            BitArray B = new BitArray(5, true);
            A.And(B); //kqua se dc cap nhat vao BitArray A

            // Khởi tạo 1 BitArray từ mảng bool có sẵn
            bool[] MyBool2 = new bool[5] { true, false, true, true, false };
            BitArray MyBA6 = new BitArray(MyBool2);

            // Khởi tạo 1 BitArray có 2 phần tử và có giá trị mặc định là 1 (true)
            bool[] MyBool3 = new bool[] { false, true, true, false, false };
            BitArray MyBA7 = new BitArray(MyBool3);

            Console.Write("\n Gia tri cua MyBA6: ");
            PrintBits(MyBA6, 5);

            Console.Write(" Gia tri cua MyBA7: ");
            PrintBits(MyBA7, 5);

            Console.WriteLine(" Thuc hien cac phep toan AND, OR, NOT, XOR tren MyBA6 va MyBA7: ");

            // thực hiện sao chép giá trị của MyBA6 ra để không làm thay đổi nó
            BitArray AndBit = MyBA6.Clone() as BitArray; //tao 1 ban sao cua BA6
            AndBit.And(MyBA7);
            Console.Write(" Ket qua cua phep toan AND: ");
            PrintBits(AndBit, 5);

            BitArray OrBit = MyBA6.Clone() as BitArray;
            OrBit.Or(MyBA7);
            Console.Write(" Ket qua cua phep toan OR: ");
            PrintBits(OrBit, 5);

            BitArray XorBit = MyBA6.Clone() as BitArray;
            XorBit.Xor(MyBA7);
            //trả về 1 khi hai bit tương ứng khác nhau và trả về 0 khi chúng giống nhau.
            Console.Write(" Ket qua cua phep toan XOR: ");
            PrintBits(XorBit, 5);

            BitArray NotBit = MyBA6.Clone() as BitArray;
            NotBit.Not();
            //Tất cả các bit 0 sẽ trở thành 1 và tất cả các bit 1 sẽ trở thành 0 
            Console.Write(" Ket qua cua phep toan NOT tren MyBA6: ");
            PrintBits(NotBit, 5);

            Console.ReadKey();
        }

        #region Bit
        public static void PrintBits(BitArray MyBA, int Width)
        {
            int i = Width;
            foreach (bool item in MyBA)
            {
                if (i < 1)
                {
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode()); // In ra 0 1 thay vì true false
            }

            Console.WriteLine();
        }
    }
}
