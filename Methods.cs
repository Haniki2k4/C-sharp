/*Bạn hãy viết phương thức trả về tổng của các phần tử trong mảng
các số nguyên arr được nhập vào từ bàn phím.*/
class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfArray(arr));
        }

        public static int sumOfArray(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
	    }
    }

/*Bạn hãy viết phương thức hiển thị ra màn hình những xâu có độ dài lớn hơn 3 trong mảng arr.*/
class Program {
        public static void Show (string[] arr){
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].Length > 3){
                    Console.Write(arr[i]+ " ");
                }
            }
        }

        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++) {
                arr[i] = Console.ReadLine();
            }
            Show(arr);
        }
    }

/*Cho số nguyên dương n được nhập từ bàn phím, bạn hãy viết phương thức đệ quy trả về n! (n giai thừa).*/
class Program {
        public static int Factorial (int n){
            if (n == 1){
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }

/*Cho số nguyên n được nhập từ bàn phím, 
bạn hãy viết phương thức đệ quy trả về tổng các số lẻ từ 1 tới n.*/
class Program {
        public static int Sum(int n) {
            if (n == 1) return 1;
            if (n % 2 == 0) {
                return Sum(n - 1);
	        } else {
                return n + Sum(n - 1);
	        }
        }

        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }
    }
//Nếu n bằng 1, tức là chúng ta đã điều kiện dừng của đệ quy 
///vì ta không thể tính tổng nào nếu chỉ có một số 1 duy nhất. Trong trường hợp này, hàm sẽ trả về giá trị là 1.
//Nếu n là số chẵn (n % 2 == 0), hàm sẽ gọi lại chính nó với đối số là n - 1. 
///Việc này giúp ta điều chỉnh n xuống một số lẻ để tính toán tiếp tục.
//Nếu n là số lẻ (n % 2 != 0), hàm sẽ tính tổng của n với tổng của các số từ 1 đến n - 1. 
///Việc này giúp tính tổng các số lẻ và đồng thời giảm n xuống một số lẻ khác để tính toán tiếp tục.

