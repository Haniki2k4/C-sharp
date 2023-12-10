using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            
            //khai báo chuỗi
            string chuoi1 = "Gà lại lập trình";
            Console.WriteLine("Chuỗi bạn vừa nhập là: "+chuoi1);

            //khai báo nguyên văn
            string chuoi2 = @"E:\C#";
            string chuoi3 = "E:\\learning\\C#";
            string chuoi4 = "có người nói răng \" abc xyz\" ";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);

            //chuyển đổi sang chuỗi
            int i = 1234;
            Console.WriteLine(i);
            Console.WriteLine(i.GetType().ToString());
            string chuoi5 = i.ToString();
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi5.GetType().ToString());
            string chuoi6 = i + " ";
            string chuoi7 = Convert.ToString(i);

            //tách chuỗi thành char lẻ và cho vào 1 mảng
            string chuoi8 = "Xin Chao";
            char[] lst = chuoi8.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());

            //length: trả về độ dài của chuỗi
            string chuoi9 = "test haha";
            int j = chuoi9.Length;
            Console.WriteLine(chuoi9);
            Console.WriteLine(j);
            Console.WriteLine("Ký tự thứ 2 của chuỗi: " + chuoi9[1]);
            Console.WriteLine("Ký tự cuối cùng của chuỗi: " + chuoi9[j-1]); //index bdau từ 0 mà length bdau từ 1

            //vdu1: Nhập vào 1 chuỗi
            //đếm xem có bao nhiêu ký tự thường
            //đếm xem có bao nhiêu chũ in hoa
            //đếm xem có bao nhiêu khoảng trắng
            //đếm xem có bao nhiêu số
            int demThuong = 0;
            int demHoa = 0;
            int demSo = 0;
            int demSpace = 0;
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi!");
            string nhapVao = Console.ReadLine();
            char[] list = nhapVao.ToCharArray();
            foreach (char c in list)
            {
                if (char.IsDigit(c))
                {
                    demSo++;
                }
                else if (char.IsLower(c))
                {
                    demThuong++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    demSpace++;
                }
                else if (char.IsUpper(c))
                {
                    demHoa++;
                }
            }
            Console.WriteLine("Chuỗi bạn nhập vào là: "+ nhapVao);
            Console.WriteLine("Số ký tự thường là: " + demThuong);
            Console.WriteLine("Số ký tự hoa là: " + demHoa);
            Console.WriteLine("Số khoảng trắngg là: " + demSpace);
            Console.WriteLine("Số ký tự số là: " + demSo);

            //so sánh chuỗi (ss giá trị)
            /*< : -1
            > : 1
            = : 0*/
            string chuoi10 = "12345a";
            string chuoi11 = "12453o";
            int k = chuoi10.CompareTo(chuoi11);
            Console.WriteLine(k);

            //Kiểm tra chuỗi con
            string chuoi12 = "abc";
            string chuoi13 = "abcdef";
            string chuoi14 = "awuhfpjis";
            bool check = chuoi14.Contains(chuoi12);
            bool check1 = chuoi13.Contains(chuoi12);
            Console.WriteLine(check);
            Console.WriteLine(check1);

            //Hàm CopyTo
            string chuoi15 = "123456";
            char[] lst2 = new char[6];
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi15.CopyTo(1, lst2, 2, 4);
            //copy 1 đoạn phần tử từ index 1 đến index 4 của chuoi15 và gán vào lst ở index 2
            Console.WriteLine(lst2);

            //Hàm bool EndsWith (string value) 
            //kktra xem chuỗi có kết thúc bằng chuỗi con hay không
            string chuoi16 = "ditimtuonglai.mp4";
            bool ktt1 = chuoi16.EndsWith(".mp4");
            bool ktt2 = chuoi16.EndsWith(".mp3");
            Console.WriteLine(ktt1);
            Console.WriteLine(ktt2);

            //gán chuỗi theo string.Format
            int n = 14;
            string chuoi17 = string.Format("n = {0} và căn bậc 2 của n là: {1}", n, Math.Sqrt(n));
            //có thể hiểu là:
            //gán lệnh hiển thị cho chuoi17 và có thể dùng lại 
            Console.WriteLine(chuoi17);
            Console.WriteLine("n = {0} và căn bậc 2 của n là: {1}", n, Math.Sqrt(n));
            //dùng đc 1 lần, dùng cho ng dùng xem

            //Hàm Equals (ktra 2 chuỗi có giống nhau không)
            string chuoi18 = "hahaha";
            string chuoi19 = "hahaha";
            string chuoi20 = "heheheh";
            bool kt2 = chuoi18.Equals(chuoi19);
            bool kt3 = chuoi18.Equals(chuoi20);
            Console.WriteLine(kt2);
            Console.WriteLine(kt3);

            //string.Insert (chèn thêm vào chuỗi)
            string chuoi21 = "234";
            string chuoi22 = "tatala";
            chuoi21 = chuoi21.Insert(3, chuoi22); //chèn chuoi22 vào chuoi21 từ index = 3 của chuoi 21
            Console.WriteLine(chuoi21);

            Console.ReadKey();
        }
    }
}
