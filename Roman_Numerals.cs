/*quy tắc:
  -Nếu một ký tự La Mã có giá trị nhỏ hơn ký tự sau nó, thì giá trị của nó sẽ bị trừ đi.
  -Nếu một ký tự La Mã có giá trị lớn hơn hoặc bằng ký tự sau nó, thì giá trị của nó sẽ được cộng vào tổng.
Ví dụ: IV là 4 vì I (1) là nhỏ hơn V (5) nên 5 - 1 = 4.

Phương thức RomanToInt của bạn thực hiện duyệt qua chuỗi đầu vào La Mã từ trái sang phải. 
Nếu giá trị của ký tự hiện tại nhỏ hơn giá trị của ký tự tiếp theo,nó sẽ được trừ đi khỏi tổng, 
ngược lại, nó sẽ được cộng vào tổng.
Tuy nhiên, vòng lặp trong phương thức chỉ duyệt đến s.Length - 1 để xử lý từng cặp ký tự. 
Sau đó, giá trị của ký tự cuối cùng trong chuỗi (s[s.Length - 1]) sẽ được cộng vào kết quả.

Ví dụ:
"III" sẽ được chuyển thành 1 + 1 + 1 = 3.
"IV" sẽ được chuyển thành 5 - 1 = 4.
*/

public class Solution 
{
        //Khởi tạo bảng chữ số La Mã lưu trữ các giá trị tương ứng của các ký tự La Mã
    static Dictionary<char, int> romanDigits = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    public int RomanToInt(string s)
    {
        var result = 0; //Khởi tạo biến result để lưu trữ giá trị số nguyên cuối cùng.

      //Duyệt qua chuỗi số La Mã từ 0 đến s.Length - 1 (để xử lý từng cặp ký tự).
       //vì chuyển từ chuỗi sang mảng ký tự và mảng bắt đầu bảng 0 nên cần trừ đi 1 giá trị
        for(int i = 0; i < s.Length - 1; i++) 
        {
          /*Kiểm tra xem giá trị của ký tự hiện tại (s[i]) 
        có nhỏ hơn giá trị của ký tự tiếp theo (s[i + 1]) không. 
        Nếu có, trừ giá trị của ký tự hiện tại (s[i]) khỏi result.
        */
            if(romanDigits[s[i]] < romanDigits[s[i + 1]])
                result -= romanDigits[s[i]]; //Nếu giá trị của ký tự hiện tại (s[i]) nhỏ hơn giá trị của ký tự tiếp theo (s[i + 1]),
                                            //result sẽ bị trừ đi giá trị của ký tự hiện tại.
            else
                result += romanDigits[s[i]]; //cộng giá trị của ký tự hiện tại (s[i]) vào result.
        }
      //Trả về tổng của result với giá trị cuối cùng trong chuỗi số La Mã
        return result + romanDigits[s[s.Length - 1]];
    }
}
