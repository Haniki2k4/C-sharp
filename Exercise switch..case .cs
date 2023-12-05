using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* chương trình tính năm âm lịch từ năm dương lịch đã nhập*/
            int nam; //biến chứa giá trị năm cần tính
            string Can = "", Chi =  "";
            Console.WriteLine("Nhập vào 1 năm bất kỳ: ");
            nam = int.Parse(Console.ReadLine());

            switch (nam % 10) //tìm Can theo thuật toán đã trình bày
            {
                case 0:
                    Can = "Canh"; //giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Can = "Tân";
                    break;
                case 2:
                    Can = "Nhâm";
                    break;
                case 3:
                    Can = "Quý";
                    break;
                case 4:
                    Can = "Giáp";
                    break;
                case 5:
                    Can = "Ất";
                    break;
                case 6:
                    Can = "Bính";
                    break;
                case 7:
                    Can = "Đinh";
                    break;
                case 8:
                    Can = "Mậu";
                    break;
                case 9:
                    Can = "Kỷ";
                    break;
            }

            switch (nam % 12)
            {
                case 0:
                    Chi = "Thân";
                    break;
                case 1:
                    Chi = "Dậu";
                    break;
                case 2:
                    Chi = "Tuất";
                    break;
                case 3:
                    Chi = "Hợi";
                    break;
                case 4:
                    Chi = "Tý";
                    break;
                case 5:
                    Chi = "Sửu";
                    break;
                case 6:
                    Chi = "Dần";
                    break;
                case 7:
                    Chi = "Mão";
                    break;
                case 8:
                    Chi = "Thìn";
                    break;
                case 9:
                    Chi = "Tị";
                    break;
                case 10:
                    Chi = "Ngọ";
                    break;
                case 11:
                    Chi = "Mùi";
                    break;
            }
            Console.WriteLine("Năm {0} có năm âm lịch là năm: {1} {2} ", nam, Can, Chi); //nối Can với Chi để có được năm âm lịch
            Console.WriteLine("_____________________________________________");
            /*Viết chương trình nhập vào một số tương ứng là năm. 
             * Xuất ra màn hình năm vừa nhập và tuổi của một người tương ứng với năm vừa nhập đó.
             * Từ câu 1. Thêm chức năng:
             * - Nếu tuổi người đó < 16 thì hiện thông báo theo format: Bạn <Tuổi>, tuổi vị thành niên.
             * - Nếu tuổi người đó >= 16 và <18 thì hiện thông báo theo format: Bạn <Tuổi>, tuổi trưởng thành.
             * Nếu tuổi người đó >= 18 thì hiện thông báo theo format: Bạn <Tuổi>, già rồi.*/

            int dateNow = DateTime.Now.Year;
            Console.WriteLine("Nhập năm sinh của bạn: ");
            int namSinh = int.Parse(Console.ReadLine());
            int tuoi = dateNow - namSinh;
            Console.WriteLine("Bạn sinh năm {0}, {1} tuổi", namSinh, tuoi);

            switch (tuoi > dateNow || tuoi < 0)
            {
                case true:
                    Console.WriteLine("Bạn đang nhập sai năm sinh!");
                    Console.ReadKey();
                    return;
            }

            switch (tuoi < 16)
            {
                case true:
                    Console.WriteLine("Bạn {0} tuổi, tuổi vị thành niên.", tuoi);
                    break;
            }

            switch (tuoi >= 16 && tuoi < 18)
            {
                case true:
                    Console.WriteLine("Bạn {0} tuổi, tuổi trưởng thành.", tuoi);
                    break;
            }

            switch (tuoi >= 18)
            {
                case true:
                    Console.WriteLine("Bạn {0} tuổi, tuổi già.", tuoi);
                    break;
            }

            Console.WriteLine("__________________________________________________________________2");

            /*Viết trò chơi Kéo Búa Bao với cách chơi: 
             * Người dùng sẽ nhập vào các số 1 hoặc 2 hoặc 3 tương ứng với kéo hoặc búa hoặc bao. 
             * Máy sẽ ngẫu nhiên sinh ra một số trong 3 số và tính toán máy hoặc người chiến thắng. 
             * Nhớ phải in kết quả ra màn hình.*/
            int kbb;
            Console.WriteLine("Kéo, Búa, Bao đơn giản!");
            Console.WriteLine("Kéo-Búa-Bao tương ứng với 1-2-3");
            Console.WriteLine("Mời bạn chọn số: ");
            kbb = int.Parse(Console.ReadLine());

            Random r = new Random();
            int rd = r.Next(1, 4);


            int kq = kbb - rd;

            if (kbb > 3)
            {
                Console.WriteLine("Bạn đã nhập sai!!!");
                Console.WriteLine("Vui lòng chơi lại ~_~");
                Console.ReadKey();
                return;
            }

            //Người chơi:
            switch (kbb)
            {
                case 1:
                    Console.WriteLine("Bạn chọn Kéo");
                    break;
                case 2:
                    Console.WriteLine("Bạn chọn Búa");
                    break;
                case 3:
                    Console.WriteLine("Bạn chọn Bao");
                    break;
            }

            switch (rd)
            {
                case 1:
                    Console.WriteLine("Máy chọnn Kéo");
                    break;
                case 2:
                    Console.WriteLine("Máy chọnn Búa");
                    break;
                case 3:
                    Console.WriteLine("Máy chọnn Bao");
                    break;
            }

            switch (kq)
            {
                case -1:
                case 2:
                    Console.WriteLine("Bạn đã thắng!!!  ^o^");
                    break;
                case 1:
                case -2:
                    Console.WriteLine("Bạn đã thua! X_X");
                    break;
            }


            Console.ReadLine();
        }
    }
}
