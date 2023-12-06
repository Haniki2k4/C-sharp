namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int countLoop = 0;
                int countLoopTime = 0;
                int valueNum = 10;
                int loopTime = 5;
                int minRandomValue = 0;
                int maxRandomValue = 100;


                Random rand = new Random();


            // Vẽ từ trên xuống LoopTime lần
            while (countLoopTime < loopTime) //ma trận số từ 0 ->10
            {
                    // reset lại biến countLoop về 0 để viết lại từ đầu
                    countLoop = 0;
                    // vẽ từ trái qua valueNum lần
                    while (countLoop < valueNum)
                    {
                        // in ra giá trị của countLoop trong 8 vị trí
                        Console.Write("{0,8}", countLoop);

                        // tăng giá trị của biến countLoop lên một đơn vị
                        countLoop++;
                    }
                    // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                    Console.WriteLine();
                    // tăng giá trị countLoopTime lên một đơn vị
                    countLoopTime++;
            }

            while (countLoopTime < loopTime) //ma trận số ngẫu nhiên
            {
                // reset lại biến countLoop về 0 để viết lại từ đầu
                countLoop = 0;
                // vẽ từ trái qua valueNum lần
                while (countLoop < valueNum)
                {
                    // giá trị sinh ngẫu nhiên trong khoảng [minRandomValue . . maxRandomValue - 1]
                    int showValue = rand.Next(minRandomValue, maxRandomValue);
                    // in ra giá trị của showValue trong 8 vị trí
                    Console.ForegroundColor = ConsoleColor.Red; //đổi màu console
                    Console.Write("{0,8}", showValue);
                    // tăng giá trị của biến countLoop lên một đơn vị
                    countLoop++;
                }
                // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                Console.WriteLine();
                // tăng giá trị countLoopTime lên một đơn vị
                countLoopTime++;
            }

            int Vertical = 20;
            int Horizontal = 50;
            char drawChar = '*';
            char insideChar = ' ';
            int countLoopVertical = 0;
            int countLoopHorizontal = 0;
            // Vẽ từ trên xuống
            while (countLoopVertical < Vertical)
            {
                // khởi tạo lại giá trị countLoopHorizontal = 0 mỗi lần lặp mới
                countLoopHorizontal = 0;
                // Vẽ từ trái sang
                while (countLoopHorizontal < Horizontal)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */
                    if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                    // tăng giá trị của countLoopHorizontal lên 1 đơn vị
                    countLoopHorizontal++;
                }
                // mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();
                // tăng giá trị của countLoopVertical lên 1 đơn vị
                countLoopVertical++;
            }


                Console.ReadKey();
            
        }
    }
}
