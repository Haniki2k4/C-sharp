/*<Access Modifiers> class Class_Name {
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
     // khai báo các thành viên  hàm (phương thức)
}*/


class Vukhi {

//du lieu
  public string name = "Ten vu khi";
  int doSthuong = 0;


  //thuoc tinh
  public string Noisx {set; get;}

  public int Satthuong{
    // khoi lenh set thi hanh khi thuc hien phep gan
    set {
      //cac lenh thi hanh
      Console.WriteLine(value); //xem gia tri duoc truyen vao
      doSthuong = value;
    }
    //khoi lenh get thi hanh khi truy cap va phai tra ve cung kieu voi thuoc tinh
    get{
      return doSthuong;
    }
  }


  //phuong thuc khoi tao
  public Vukhi(){
    doSthuong = 1;
  }

  public Vukhi(string name, int _dosatthuong){
    doSthuong = _dosatthuong;
    this.name = name;
  }

  //phuong thuc
  public void ThietlapDosatthuong (int doSthuong){
    //nếu không có this (-ref) thì sẽ kbt doSthuong là phương thức hay tvien của lớp
    this.doSthuong = doSthuong; 
    /*Vukhi abc;
    abc = this;*/ //nghĩa là abc bằng chính đối tượng hiện tại
  }
  public void tanCong(){
    Console.WriteLine(name + ":\t");//viet ra ten vu khi la gi
    for (int i = 0; i < doSthuong; i++){
      Console.Write("* ");

    }
    Console.WriteLine();
  }
  
}