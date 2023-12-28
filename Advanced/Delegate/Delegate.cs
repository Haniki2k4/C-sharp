using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   
    //Delegate là một biến kiểu tham chiếu(references) chứa tham chiếu tới một phương thức
    //thường được dùng để triển khai các phương thức hoặc sự kiện call-back.
    internal class Program
    {
        #region Delegate
        /*
       delegate int myDelegate(string s);
       static void Main(string[] args)
       {
           Console.OutputEncoding = Encoding.Unicode;
           myDelegate convertToInt = new myDelegate(ConvertStringToInt);
           myDelegate showString = new myDelegate(ShowString); 
           myDelegate multicast = convertToInt + showString; 

           //event call back
           NhapShowTen(showString);

           string numberS = "50";
           int valueConverted = convertToInt(numberS);
           Console.WriteLine("Giá trị đã convert thành int: {0}", valueConverted);


           Console.WriteLine("\nKet qua cua multicast");
           multicast(numberS);
           //loai bo delegate trong multicast
           multicast -= showString;
           Console.WriteLine("\nKet qua sau khi loai bo showString bang multicast");
           Console.WriteLine("__________________________");
           Console.ReadKey();
       }
       static int ConvertStringToInt(string stringValue)
       {
           int value = 0;
           Int32.TryParse(stringValue, out value);
           Console.WriteLine("Đã ép kiểu dữ liệu thành công");

           return value;
       }

       static int ShowString (string stringValue)
       {
           Console.WriteLine(stringValue);
           return 0;
       }

       static void NhapShowTen(myDelegate showTen)
       {
           Console.WriteLine("\nMoi nhap ten cua ban:");
           string ten = Console.ReadLine();
           showTen(ten);
       }*/
        #endregion
    }
}
