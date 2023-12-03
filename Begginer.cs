using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { //day la cach viet comment 
            Console.OutputEncoding= Encoding.UTF8; //sdung để có thể in tiếng việt mà không lỗi font
            Console.WriteLine("Chào mọi người "); //tương tự như lệnh print và sau khi in ra sẽ xuống dòng
            Console.Write("My name is A, ");// lệnh print và câu lệnh phía sau hiện liền, không xuống dòng
            Console.Write("Im a new student on C# and my birth is ");
            Console.WriteLine(2004);
            Console.WriteLine("I'm Male");
            /*Console.ReadKey(true); có thể dùng như Readline
             * () mặc định là false
             * (false) hiện thị phím ấn trên màn hình
             * (true) không hiện thị phím ấn
            */
            
            int soLuong = 0; //khai bao  bien
            float diemTB = 8.5f;
            string name = "Trang";
            byte tuoi = 24;
            Console.WriteLine("So Luong la: {0}", soLuong); //truyền giá trị soluong vào {0}
            Console.WriteLine("Diem trung binh cua {0} la: {1}", name, diemTB); // truyền giá trị name và diemTB lần lượt và {0}, {1}

            /*quy tắc đặt tên (camel):
             * đặt tên sát với mục đích sử dụng biến
             * từ chữ cái thứ 2 thì viết hoa chữ cái đầu
             *          vd: diemTrungbinh
             *              diemToan
             */

            int a = 2;
            int b = 3;
            float c = a / b;
            float d = (float)a / b; //ép kiểu
            Console.WriteLine("gia tri cua c la: {0}", c);
            Console.WriteLine("gia tri cua d la: " + d);

            string hoTen; //khai báo biến
            float diemToan;
            float diemVan;

            Console.WriteLine("Moi nhap vao ho ten: ");
            hoTen = Console.ReadLine(); //đọc giữ liệu nhập vào

            Console.WriteLine("Moi nhap diem Toan: ");
            diemToan = float.Parse(Console.ReadLine()); //đọc dữ liệu nhập vào và ép kiểu float

            Console.WriteLine("Moi nhap diem Van: ");
            diemVan = float.Parse(Console.ReadLine()); //đọc dữ liệu nhập vào và ép kiểu float

            Console.WriteLine("Hoc sinh {0} co diem toan la {1} va diem Van la {2}", hoTen, diemToan, diemVan);

            var y = 241; //ngầm hiểu kiểu dữ liệu (ko nên lạm dụng)
            //nếu như vdu là 12.4 thì sẽ định dạng là double chứ ko phải float
            Console.WriteLine("kieu du lieu cua y: " + y.GetType().ToString());

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length); //đo độ dài kí tự của string

            string text = "Hello World";
            Console.WriteLine(text.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(text.ToLower());   // Outputs "hello world"

            //Console.ReadKey()
            Console.ReadLine(); //dừng chương trình là và giữ không auto off chương trình

        }
    }
}
