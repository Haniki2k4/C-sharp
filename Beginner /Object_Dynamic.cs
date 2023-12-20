/*
 ________OBJECT___DYNAMIC_________
 */

//object: kiểu dữ liệu tham số
Console.WriteLine("Hello, World!");
object obj = "Hello!!!";

Console.WriteLine(obj.ToString); //trả về kdl chuỗi
Console.WriteLine(obj.GetHashCode); // trả về mã băm
Console.WriteLine(obj.Equals); //so sánh 2 đối tượng
Console.WriteLine(obj.ToString); // trả về kdl của đối tượng

/*
 boxing:chuyển từ kdl giá trị sang kdl tham chiếu
*/
int Value = 200;
object ObjValue = Value;

//unboxing 
int newValue = (int)ObjValue;

//var: từ khóa hỗ trợ khai báo biến mà không cần kiểu dữ liệu, không phải kiểu dữ liệu
var varString = "Halo Boiz";
Console.WriteLine(varString);

//dynamic: một từ khóa để khai báo kiểu dynamic
dynamic StringValue = "HowKteam"; // Khai báo biến StringValue kiểu dynamic và khởi tạo giá trị là một chuỗi kiểu string
/* 
StringValue++;

* Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++
* Nhưng câu lệnh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu cho biến StringValue
* Khi chạy chương trình thì lúc này C# mới phát hiện biến StringValue là kiểu string và không thể thực hiện toán tử ++ lúc đó sẽ xuất hiện lỗi
*/
// Khai báo 2 biến Name và Mission kiểu string và khởi tạo giá trị.
string Name = "HowKteam ";
string Mission = "Free Education";
/* 
 * Thực hiện gán 1 biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
 * Sau phép gán này thì biến DynamicValue chứa giá trị là "Free Education" nhưng kiểu dữ liệu của nó vẫn chưa được xác định.
*/
dynamic DynamicName = Name;
// Thực hiện cộng chuỗi và in ra màn hình bình thường
Console.WriteLine("Mission of " + DynamicName + " is " + Mission);



Console.ReadLine();
