using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            if (time < 18) //normal if...else
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            string result = (time < 18) ? "Good day." : "Good evening."; //short-hand if...else
            Console.WriteLine(result);


            //_______________________________________________________________


            /* tìm x, y khi biết tổng và hiệu của chúng
             * case test: tong = 14, hieu = 4 => x=9, y=5
             * */
            Console.OutputEncoding= Encoding.UTF8;
            double x, y;
            double tong, hieu;
            Console.WriteLine("Nhập tổng 2 số: ");
            tong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hiệu 2 số: ");
            hieu = double.Parse(Console.ReadLine());

            x = (tong + hieu) / 2;
            y = tong - x;
            Console.WriteLine("Giá trị của x là: {0}", x);
            Console.WriteLine("Giá trị của y là: {0}", y);

            //_____________________________________________________________________
/* Viết chương trình nhập vào chiều cao và cân nặng. Tính BMI và xuất ra thông báo
 * BMI < 15: thân hình quá gầy
 * BMI >= 15 và BMI < 16: thân hình gầy
 * BMI >= 16 và BMI < 18.5: thân hình hơi gầy
 * BMI >= 18.5 và BMI < 25: thân hình bình thường
 * BMI >= 25 và BMI < 30: thân hình hơi béo
 * BMI >= 30 và BMI <35: thân hình béo
 * BMI >=35: thân hình quá béo
 * */
            float chieuCao, canNang;
            Console.WriteLine("Nhap chieu cao(m) (eg:1m67 = 1.67): ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang(kg): ");
            canNang = float.Parse(Console.ReadLine());

            double BMI = canNang / (Math.Pow(chieuCao, 2));
            Console.WriteLine("BMI của bạn là: {0}", Math.Round(BMI,2));

            if (BMI < 15)
            { Console.WriteLine("thân hình quá gầy"); }
            else if (BMI >= 15 && BMI < 16) { Console.WriteLine("Thân hình của bạn gầy"); }
            else if (BMI >= 16 && BMI< 18.5) { Console.WriteLine("Thân hình của bạn hơi gầy"); }
            else if (BMI >= 18.5 && BMI< 25) { Console.WriteLine("Thân hình của bạn bình thường"); }
            else if (BMI >= 25 && BMI< 30) { Console.WriteLine("Thân hình của bạn hơi béo"); }
            else if (BMI >= 30 && BMI<35) { Console.WriteLine("Thân hình của bạn béo"); }
            else if (BMI > 30 ) { Console.WriteLine("Thân hình của bạn quá béo"); }

            /* viết chương trình nhập vào 1 năm dương lịch và kiểm tra xem năm đó có phải năm nhuận hay không
             * case test: năm nhuận 2004, 2008, 2012
             *            năm không nhuận 1900, 2005
             */

            int year;
            Console.WriteLine("Nhập vào 1 năm dương lịch bất kì: ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0) || year % 400 == 0)
            { Console.WriteLine("Năm {0} là năm nhuận!", year); }
            else Console.WriteLine("Năm {0} là năm không nhuận!", year);

            Console.ReadLine();
        }
    }
}
