/*Viết trò chơi Kéo Búa Bao với cách chơi: 
            * Người dùng sẽ nhập vào các số 1 hoặc 2 hoặc 3 tương ứng với kéo hoặc búa hoặc bao. 
            * Máy sẽ ngẫu nhiên sinh ra một số trong 3 số và tính toán máy hoặc người chiến thắng. 
            * Nhớ phải in kết quả ra màn hình.*/
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int kbb;
bool choiLai = true;
while (choiLai)
{
    Console.WriteLine("________________________________");
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
        Console.WriteLine("Vui lòng nhấn phím Enter để chơi lại ~_~");
        Console.ReadLine();
        continue;
        
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
        case 0:
            Console.WriteLine("Kết quả hòa!!!!");
            break;
    }

    Console.WriteLine("Chơi lại? ");
    Console.Write("Nhập 1-Yes hoặc 2-No: ");
    int rp = int.Parse(Console.ReadLine());
    switch (rp)
    {
        case 1:
            choiLai = true;
            break;
        case 2:
            choiLai = false;
            Console.WriteLine("Cảm ơn bạn đã chơi. Hẹn gặp lại!");
            break;
        default:
            Console.WriteLine("Bạn đã nhập sai giá trị. Vui lòng nhập lại.");
            break;
    }

}
Console.ReadLine();
