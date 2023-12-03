using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const float pi = 3.14f;
            Console.WriteLine("Hello, This's where we start");
            Console.WriteLine("_____________________________");
            
            Console.WriteLine("This is operator: ");
            Console.Write("Nhập a: ");
            int a, b;
            a = int.Parse(Console.ReadLine()); //lưu giá trị nhập từ bàn phím và ép kiểu thành int
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a += 3: {0}", a += 3);
            Console.WriteLine("a -= 5: {0}", a -= 5);
            Console.WriteLine("a *= 2: {0}", a *= 2);
            Console.WriteLine("a /= 9: {0}", a /= 9);
            Console.WriteLine("a %= 5: {0}", a %= 5);
            Console.WriteLine("a = a - ( b + 7): {0}", a -= (b + 7));
            Console.WriteLine("------");
            float r;
            Console.WriteLine("Nhập vào chu vi r của hình tròn: ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi của hình tròn: {0}", 2*r*pi);
            Console.WriteLine("Diện tích của hình tròn: {0}", pi*(r*r));
            Console.WriteLine("------"); 
            int x = 5, y = 12;
            Console.WriteLine("Với x = 5, y = 12:");
            Console.WriteLine("AND bit-wise: {0}", x &= 3);
            Console.WriteLine("OR bit-wise: {0}", x |= 3);
            Console.WriteLine("XOR bit-wise: {0}", x ^= 3);
            Console.WriteLine("Phép dịch phải: {0}", y >>= 3);
            Console.WriteLine("Phép dịch trái: {0}", y <<= 3);
            Console.WriteLine("\n______________________________");
            
            Console.WriteLine("This is constant value: ");
            const int doSoi = 100, doDong = 0; //khóa giá trị của doSoi và doDong lại, không thể thay đổi
            Console.WriteLine("Nhiệt độ sôi là: {0}", doSoi);
            Console.WriteLine("Nhiệt độ đông là: {0}", doDong);
            Console.WriteLine("Giá trị của pi = {0}", pi);
            Console.WriteLine("\n______________________________");
            
            Console.WriteLine("Mức độ ưu tiên tính toán postfix(x++), prefix(++y): \nint x=1, y=2; \nint z = x++ - ++y +1;");
            Console.WriteLine("Step1 (Prefix): ++y => y = 3 \nStep2(các phép toán còn lại): x=1, y=3 => 1-3+1 = -1");
            Console.WriteLine("Step3 (gán giá trị cho biến bên trái dấu bằng): z = -1 \nStep4(tính Postfix): x++ => x=2");
            int g = 1, h = 2;
            int t = g++ - ++h + 1;
            Console.WriteLine("Giá trị z: {0}", t);
            Console.WriteLine("\n______________________________");
            
            Console.WriteLine("The highest value of x and y: " + Math.Max(5, 10));//used to find the highest value of x and y
            Console.WriteLine("The lowest value of of x and y: " + Math.Min(5, 10));//used to find the lowest value of of x and y
            Console.WriteLine("The square root of x: " + Math.Sqrt(64));//returns the square root of x
            Console.WriteLine("The absolute(positive) value of x: " + Math.Abs(-4.7));//returns the absolute(positive) value of x:
            Console.WriteLine("Number to the nearest whole number: " + Math.Round(9.99));
            
            Console.ReadLine();
        }
    }
}
