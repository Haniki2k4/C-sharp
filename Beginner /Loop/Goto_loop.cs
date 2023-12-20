using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //________________LOOP____(vòng lặp)_________

         /*
         Goto loop (Khuyến cáo không sử dụng Goto trong ngôn ngữ C#)
         */

         int a = 1;
         switch (a)
         {
            case 1:             // label case 1
                Console.WriteLine("Case 1");
                   break;
            case 2:             // label case 2
                Console.WriteLine("Case 2");
                goto case 1;    // dịch chuyển tới label case 1
                   break;          // Đoạn code này thừa vì sẽ không bao giờ thực thi
            case 3:             // label case 3
                Console.WriteLine("Case 3");
                   break;
         }
         
        /*Trong đoạn code này chúng ta biên dịch sẽ thấy kết quả xuất ra màn hình dòng chữ "Case 1" vì a == 1.
        Giờ chúng ta thay giá trị a == 1 thành == 2  xem kết quả ra sao nhé
        */
                int b = 2;
                switch (a)
                {
                    case 1:             // label case 1
                        Console.WriteLine("Case 1");
                        break;
                    case 2:             // label case 2
                        Console.WriteLine("Case 2");
                        goto case 1;    // dịch chuyển tới label case 1
                        break;          // Đoạn code này thừa vì sẽ không bao giờ thực thi
                    case 3:             // label case 3
                        Console.WriteLine("Case 3");
                        break;
                }
                Console.ReadKey();
            
        /*
        Kết quả:
        Ta thấy chương trình đi vào case 2 sau đó gặp dòng code goto case 1; nên đã nhảy lên thực thi dòng code
        case 1:  // label case 1
        Console.WriteLine("Case 1");
                    break;
        rồi mới kết thúc chương trình.
        */

        int c = 1;
        // nếu c == 2
        if (c == 2)
        {
         // dịch chuyển tới vị trí label c_Is_2
            goto c_Is_2;
        }
        Console.WriteLine("A == 1");
        // Kết thúc vị trí label c_Is_2
        c_Is_2:
        Console.WriteLine("A == 2");

        /*Ở trường hợp này  kết quả màn hình sẽ xuất ra dòng chữ "A == 1" và dòng chữ "A == 2" ra màn hình.
        Chúng ta có thể nhận thấy 2 điều ở ví dụ này:
        label có thể được tạo ra một cách dễ dàng và không nhất thiết phải nằm trong cấu trúc switch.
        Việc tạo label sẽ không ảnh hưởng gì đến code thông thường.*/
        
        //Chúng ta thử cho giá trị của a = 2 và xem kết quả nhé:
                int e = 2;
                // nếu a == 2
                if (e == 2)
                {
                    // dịch chuyển tới vị trí label a_Is_2
                    goto e_Is_2;
                }

                Console.WriteLine("A == 1");
                      e_Is_2:
                Console.WriteLine("A == 2");
            
        /*Kết quả sẽ in ra màn hình dòng chữ "A == 2".Dòng chữ "A == 1" không được in ra do đoạn code 
         * Console.WriteLine("A == 1"); bị bỏ qua vì câu lệnh goto dịch chuyển đến label a_Is_2: nằm bên dưới nó.
         * Vậy rõ ràng lần này chương trình không đi theo trình tự từ trên xuống dưới mà bị dịch chuyển ngược lên trên trở lại bởi câu lệnh goto.
         * Bản chất của goto là nhảy đến bất cứ nơi đâu có label. Mọi câu lệnh khác khi goto bỏ qua đều bị trình biên dịch bỏ qua.*/

         //Ví dụ về vòng lặp vô tận:
             int d = 2;
             Ifinity_Loop:
                // nếu a == 2
                if (d == 2)
                {
                    // dịch chuyển tới vị trí label a_Is_2
                    goto d_Is_2;
                }

                Console.WriteLine("A == 1");
                      d_Is_2:
                Console.WriteLine("A == 2");
                 goto Ifinity_Loop; // dịch chuyển tới vị trí label Ifinity_Loop

            /*Chúng ta thấy khi chạy chương trình sẽ in ra hàng loạt dòng "A == 2" do đoạn code Console.WriteLine("A == 2"); 
             * được lặp lại liên tục.Đoạn code làm phát sinh vấn đề này là ở đây:
             * Ban đầu chương trình sẽ đi đến đoạn code goto a_Is_2;.
             * Sau đó lại bị đoạn code goto Ifinity_Loop; đưa ngược lại label Ifinity_Loop.
             * Mãi không thể nào kết thúc quá trình lặp lại này dẫn đến một vòng lặp vô tận.*/

            Console.ReadLine();
        }
    }
}  
