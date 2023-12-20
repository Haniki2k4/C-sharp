#region Sử dụng phg thức khởi tạo
    #region #Khi tạo đối tượng của lớp bằng toán tử new thì nó sẽ tạo đối tượng
      //và thi hành phương thức khởi tạo tương ứng phù hợp với tham số.
    #endregion
    //!tạo đối tượng, không truyền tham số nên
    //!nó gọi phương thức khởi tạo không tham số
    Product product1 = new Product();
    Console.WriteLine(product1.Name);//*không tên

    Product product2 = new Product ("Laptop", 123);
    Console.WriteLine(product2.Name); //*Laptop


    #region sử dụng pg thức ktao class cơ sở
      CategoryMobile cat1 = new CategoryMobile("Dien Thoai", "Danh muc cac loai dien thoai");
      Console.WriteLine(cat1.Name);
      Console.WriteLine(cat1.Description);
    #endregion
    
    #region đoạn mã sử dụng kiểm tra
    Console.WriteLine(myColorCode.color_danger);
    Console.WriteLine(myColorCode.color_info);
    #endregion

#endregion

#region cú pháp khai báo phg thức khởi tạo

//*phương thức khởi tạo có tên giống tên class, không có kiểu trả về
class Product 
{
  private string name;
  private decimal price;

  //?khai bao phương thức khởi tạo với 2 tham số
  public Product (string nameProduct, decimal priceProduct)
  {
    name = nameProduct;
    price = priceProduct;
  }

  //?khai báo phương thức khởi tạo không tham số
  public Product ()
  {
    name = "Khong ten";
    price = 0;
  }
  //?Thuộc tính Name lấy hoặc thiết lập tên sản phẩm
  public string Name
  {
    set { name = value;}
    get { return name; }
  }
}

/*trong lớp có các phương thức mà thực hiện một biểu thức đơn giản,
thì bạn có thể gán ngay biểu thức 
vào tên phương thức bằng ký hiệu =>, kể cả setter và getter,*/

class Category 
{
  private string categoryname;
  //dùng thân biểu thức cho phương thức khởi tạo
  public Category(string nameofCategory) => categoryname = nameofCategory;
  
  //dùng thân biểu thức cho setter, getter
  public string Name{
    set => categoryname = value;
    get => categoryname;
  }
}

#endregion

#region phương thức khởi tạo của lớp cơ sở
  //?nếu lớp cha (cơ sở) có xây dựng phương thức khởi tạo,
  ///thì cần chỉ định rõ gọi phương thức khởi tạo nào của lớp cơ sở (truyền tham số)
  ///khi phương thức khởi tạo lớp con thi hành.
  ///Thực hiện điều này bằng cách dùng từ khóa base ở khai báo tên phương thức

  class CategoryMobile : Category
  {
    private string description;
    //?khi phương thức khởi tạo này được gọi, nó gọi phương thức khởi tạo 
    ///có một tham số của lớp cơ sở (Category) trước,
    ///rồi mới thi hành các code trong thân của pg thức khởi tạo này
    ///  
    public CategoryMobile (string nameofCategory, string mota) : base(nameofCategory)
    {
      description = mota;
    } 

    public string Description 
    {
      set => description = value;
      get => description;
    }
  }
#endregion

#region pg thức khởi tạo riêng tư
    //?khi xây dựng một số lớp đặc biệt, 
    ///nhất là những lớp tiện ích chỉ chứa thành viên tĩnh, 
    ///bạn mong muốn chỉ ra một cách tường minnh lớp này không được phép tạo đối tg,
    ///lớp này không được phép kế thừa thì hãy cho vào 1 pg thức khởi tạo
    ///không tham số và chỉ ra trạng thái truy cập là (private)
    ///
    class myLib 
    {
      public static double PI = 3.14;

      private myLib()
      {

      }
    }

    /*lúc này nếu dùng lớp khởi tạo sẽ bị lỗi
    myLib my1 = new myLib(); //error
    
    kể cả dùng làm lớp cơ sở cx error
    */

#endregion

#region pg thức khởi tạo tĩnh
  ///có thể xây dựng một phương thức khởi tạo không tham số 
  ///có chỉ thị truy cập là static, 
  ///phương thức khởi tạo này dùng để khởi tạo các thành viên dữ liệu tĩnh, 
  ///nó tự động gọi khi truy cập một thành viên dữ liệu tĩnh lần đầu
  ///

  class myColorCode
  {
    public static string color_primary;
    public static string color_success;
    public static string color_danger;
    public static string color_warning;
    public static string color_info;

    //! pg thức khởi tạo tĩnh,
    //! được gọi khi lần đầu truy cập 1 thành viên tĩnh
    static myColorCode()
    {
      Console.WriteLine("Stactic MycolorCode Contructor Call");
      color_danger = "Red";
      color_info = "Cyan";
      color_primary = "Navy";
      color_success = "Green";
      color_warning = "Warning";
    }
  }
#endregion






