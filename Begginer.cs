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
            /*Console.ReadKey(true); 
             * () mặc định là false
             * (false) hiện thị phím ấn trên màn hình
             * (true) không hiện thị phím ấn
            */
            Console.ReadLine(); //dừng chương trình là và giữ không auto off chương trình
        }
    }
}
