using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        /*Struct là một kiểu dữ liệu có cấu trúc để thuận tiện trong việc quản lý dữ liệu và lập trình.
            -Là một kiểu dữ liệu tham trị
            -Dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau
            -Bên trong struct ngoài các biến có kiểu dữ liệu cơ bản còn có các phương thức, các struct khác.
            -Muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán tử new   
            -Struct không được phép kế thừa*/

      //Vì struct là kiểu tham trị nên khi truyền vào các phương thức thì giá trị của nó sau khi kết thúc phương thức sẽ không thay đổi. 
      //Do đó cần sử dụng từ khoá out để có thể cập nhật giá trị thay đổi khi kết thúc phương thức.

        /*
         * //cach khai bao struct 
        struct<ten_struct> 
        {
            public<dsach_cac_bien>;
        }*/
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }

        static void NhapTtinSv(out SinhVien SV)
        {
            Console.Write("Ma so: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write("HoTen: ");
            SV.HoTen = Console.ReadLine();
            Console.Write("DiemToan: ");
            SV.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("DiemLy: ");
            SV.DiemLy = double.Parse(Console.ReadLine());
            Console.Write("DiemVan: ");
            SV.DiemVan = double.Parse(Console.ReadLine());
        }

        static void XuatTtinSv(SinhVien SV)
        {
            Console.WriteLine("\n Ma So: " + SV.MaSo);
            Console.WriteLine("Ho Ten: " + SV.HoTen);
            Console.WriteLine("Diem Toan: " + SV.DiemToan);
            Console.WriteLine("Diem Ly: " + SV.DiemLy);
            Console.WriteLine("DiemVan: " + SV.DiemVan);
        }

        static double DiemTb(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }

        static void Main(string[] args)
        {
            SinhVien Sv1 = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien: ");
            NhapTtinSv(out Sv1);

            Console.WriteLine("Thong tin sinh vien vua nhap: ");
            XuatTtinSv(Sv1);
            Console.Write("Diem TB cua sinh vien la: " + DiemTb(Sv1));

            Console.ReadKey();
        }

    }
}
