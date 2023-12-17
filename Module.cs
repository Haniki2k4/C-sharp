using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Net.Sockets;


public class Package
{
    
    public static void tBao()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t ______________Choose options______________");
        Console.WriteLine("\t\t\t |0.Xem                       |7.Thoát    |");
        Console.WriteLine("\t\t\t |1.Nhập File  |3.Tìm kiếm    |5.Thêm     |");
        Console.WriteLine("\t\t\t |2.Xuất File  |4.Chỉnh sửa   |6.Xóa      |");
        Console.WriteLine("\t\t\t __________________________________________");
    }

    public static void nhapFile(List<SsV> listSv, string fileLink)
    {
        try
        {
            if (File.Exists(fileLink))
            {
                using (var pack = new ExcelPackage(new FileInfo(fileLink)))
                {
                    ExcelWorksheet wks = pack.Workbook.Worksheets[0];

                    int soHang = wks.Dimension.Rows; //chứa số hàng có dữ liệu trong trang 
                    for (int hang = 2; hang <= soHang; hang++)
                    {
                        //đọc giá trị của mỗi một ô trong trang tính
                        //in giá trị ra màn hình và kèm theo kí tự tab và tọa kcach
                        SsV xuatSV = new SsV
                        {
                            Name = wks.Cells[hang, 2].Text,
                            lastName = wks.Cells[hang, 3].Text,
                            mSv = long.Parse(wks.Cells[hang, 4].Text),
                            cLass = wks.Cells[hang, 5].Text,
                            sChool = wks.Cells[hang, 6].Text,
                            GPA = float.Parse(wks.Cells[hang, 7].Text),
                        };
                        SsV.ThemSv(listSv, xuatSV);
                    }
                    Console.WriteLine("Cập nhật file thành công!");
                    Console.WriteLine();
                }
            }
            else /*nếu tập tin Excel không tồn tại, 
                  *hàm sẽ in ra thông báo “Không tìm thấy file!!”.*/
            {
                Console.WriteLine("Không tìm thấy file!!");
            }
        }
        catch (Exception ex) /*Nếu có lỗi khác xảy ra, hàm sẽ in ra thông báo chứa nội dung của lỗi.*/
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void xuatFile(string fileLink, List<SsV> listSvien)
    {
        try
        {
            /* Tạo một biến kiểu ExcelPackage tên là pack, 
             * là một đối tượng dùng để đọc và ghi dữ liệu từ tập tin Excel. 
             * sử dụng từ khóa using để giải phóng bộ nhớ khi kết thúc khối lệnh trong dấu ngoặc nhọn
             * Tham số truyền vào pack là một đối tượng kiểu fileLink,
             * được khởi tạo bằng cách truyền biến fileLink vào hàm tạo*/
            using (var pack = new ExcelPackage(new FileInfo(fileLink)))
            {

                //đối tượng đại diện cho một trang tính trong tập tin Excel.
                var wks = pack.Workbook.Worksheets[0];
                int indexHang = wks.Dimension.Rows; //số hàng có dữ liệu trong trang tính 
                indexHang += 1; //tránh bị đè dữ liệu

                ///duyệt qua các phần tử trong danh sách listItem, 
                ///Tạo một biến kiểu iTem tên là sV , 
                ///dùng để lưu đối tượng hiện tại trong danh sách.
                foreach (SsV sV in listSvien)
                {
                    Console.WriteLine("Loading***");
                    ///Ghi giá trị của thuộc tính SsV của đối tượng sV 
                    ///vào ô tại hàng indexRow và cột 2 trong trang tính
                    wks.Cells[indexHang, 2].Value = sV.Name;
                    wks.Cells[indexHang, 3].Value = sV.lastName;
                    wks.Cells[indexHang, 4].Value = sV.mSv;
                    wks.Cells[indexHang, 5].Value = sV.cLass;
                    wks.Cells[indexHang, 6].Value = sV.sChool;
                    wks.Cells[indexHang, 7].Value = sV.GPA;

                    indexHang++;
                    pack.Save(); // lưu lại các thay đổi vào tập tin Excel
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class SsV
{
    int Stt = 0;
    public string Name { set; get; } //tên của mỗi sinh viên
    public string lastName { set; get; }
    public long mSv { set; get; } //mã sinh viên của mỗi sinh viên
    public string cLass { set; get; } //lớp đang học hiện tại của mỗi sinh viên
    public string sChool { set; get; }
    public float GPA { set; get; }

    public static void XemSvien(List<SsV> listSv)
    {
        foreach (var sV in listSv)
        {
            Console.WriteLine($"***GPA của {sV.Name} {sV.lastName}[{sV.mSv}-{sV.cLass}-{sV.sChool}]: {sV.GPA}.");
        }
    }

    public static void TimKiem(List<SsV> listSv, long mSv)
    {
        SsV tKiemSv = listSv.FirstOrDefault(sV => sV.mSv == mSv);

        if (tKiemSv != null)
        {
            Console.WriteLine("Kết quả: ");
            Console.WriteLine($"Họ và tên: {tKiemSv.lastName}{tKiemSv.Name}");
            Console.WriteLine($"Mã Sinh Viên: {tKiemSv.mSv}");
            Console.WriteLine($"Lớp: {tKiemSv.cLass}");
            Console.WriteLine($"Trường: {tKiemSv.GPA}");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("Sinh viên không tồn tại! ");
        }
    }

    public static void cSuaSv(List<SsV> listSv, long mSv, SsV UpdSv)
    {
        //FirstOrDefault trả về phần tử đầu tiên trong danh sách thỏa mãn điều kiện chỉ định.
        SsV svSua = listSv.FirstOrDefault(sV => sV.mSv == mSv);
        if (svSua != null)
        { 
            //cập nhật giá trị mới của Name 
            svSua.Name = UpdSv.Name;
            svSua.lastName = UpdSv.lastName;
            svSua.mSv = UpdSv.mSv;
            svSua.cLass = UpdSv.cLass;
            svSua.sChool = UpdSv.sChool;
            svSua.GPA = UpdSv.GPA;
            Console.WriteLine($"Đã chỉnh sửa thông tin sinh viên {mSv}");
        }
        else
        {
            Console.WriteLine("Sinh viên không tồn tại! ");
        }
    }

    public static void ThemSv(List<SsV> listSv, SsV sVienMoi)
    {
        sVienMoi.Stt = listSv.Count + 1;
        listSv.Add(sVienMoi);
        Console.WriteLine($"**Đã thêm{sVienMoi.Name} - mã sinh viên:{sVienMoi.mSv}");
    }

    public static void XoaSv(List<SsV> listSv, long mSv)
    {
        SsV SvXoa = listSv.FirstOrDefault(sV => sV.mSv == mSv);
        if (SvXoa != null)
        {
            listSv.Remove(SvXoa);
            Console.WriteLine($"**Đã xóa {SvXoa.Name}({SvXoa.mSv})");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã sinh viên phù hợp");
        }
    }

    public static SsV NhapSvien()
    {
        Console.Write("Tên Sinh Viên:");
        string nhapName = Console.ReadLine();
        Console.Write("Họ/Đệm Sinh Viên: ");
        string nhapLname = Console.ReadLine();
        Console.Write("Mã Sinh Viên: ");
        var nhapMSV = long.Parse(Console.ReadLine());
        Console.Write("Lớp đào tạo: ");
        string nhapLop = Console.ReadLine();
        Console.Write("Trường: ");
        string nhapTrg = Console.ReadLine();
        Console.Write("Điểm GPA: ");
        var nhapGpa = float.Parse(Console.ReadLine());
        return new SsV
        {
            Name = nhapName,
            lastName = nhapLname,
            mSv = nhapMSV,
            cLass = nhapLop,
            sChool = nhapTrg,
            GPA = nhapGpa,
        };
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        Console.OutputEncoding = Encoding.UTF8;
        //Nhập, Tìm, Xóa, Sửa, Exit
        List<SsV> listSv = new List<SsV>();
        string fileLink = @"D:\SteamLibrary\Module1.xlsx";
        int n;
        do
        {
            Package.tBao();
            Console.Write("Hãy nhập sự lựa chọn của bạn: ");
            do
            {
                //ktra giá trị nhập vào có tròn khoảng từ 0 ->  7 ko?
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 7)
                {
                    Package.tBao();
                    Console.WriteLine("Mời nhập số phù hợp (0 -> 7)!");
                }
                else
                {
                    break;
                }
            } while (true);
            switch (n)
            {
                case 0: //xem
                    SsV.XemSvien(listSv);
                    break;
                case 1: //Nhập
                    Package.nhapFile(listSv, fileLink);
                    break;
                case 2: //xuất
                    Package.xuatFile(fileLink, listSv);
                    break;
                case 3: //tìm
                    Console.Write("Nhập mã sinh viên cần tìm kiếm: ");
                    var SearchSv = long.Parse(Console.ReadLine());
                    SsV.TimKiem(listSv, SearchSv);
                    break;
                case 4: //sửa
                    Console.WriteLine("Xin mời sửa thông tin sinh viên (ngoại trừ Msv):");
                    SsV UpdSv = SsV.NhapSvien();
                    SsV.cSuaSv(listSv, UpdSv.mSv, UpdSv);
                    break;
                case 5: //thêm
                    SsV.ThemSv(listSv, SsV.NhapSvien());
                    break;
                case 6: //xóa
                    Console.Write("Nhập mã sinh viên cần loại bỏ: ");
                    var SvXoa = int.Parse(Console.ReadLine());
                    SsV.XoaSv(listSv, SvXoa);
                    break;
                case 7: //thoát
                    Environment.Exit(0);
                    break;
            }
            
        } while (true);
    }
 }

