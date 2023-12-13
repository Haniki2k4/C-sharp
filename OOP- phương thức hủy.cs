class Program
{
  static void Main(string[] args)
  {
    //phuong thuc huy
    Student student;
     /* student = new Student("sinh vien 1");
      student = null; //khong con tham chieu nao den dtg new Student va dotnet thu hoi bo nho(goi phg thuc huy)
                      //khong thu hoi ngay
      GC.Collect(); //dotnet frw se thu hoi ngay lap tuc (.net core ko con cnang nay)
      */
    for(int i = 0; i < 100000; i++)
    {
      student = new Student("Sinh vien " + i);
      student = null;
    }

//tao phuong thuc huy
class Student{
  public string name;
  public Student(string name){
    this.name = name;
    Console.WriteLine("Khoi tao " + name);
  }
  //de tao ra 1 phuong thuc huy thi ta tao ra 1 phuong thuc co cung ten voi ten lop 
  //nhung bdau bang dau ~ va ko co kieu tra ve va khong co tham so
  ~Student(){
    //nhung hanh dong ma khi doi tuong bi huy se thi hanh
    Console.ForegroundColor = ConsoleColor.Red; //nhung phg thuc bi huy se hien mau do
    Console.WriteLine("Huy " + name);
    Console.ReserColor;
  }
}
