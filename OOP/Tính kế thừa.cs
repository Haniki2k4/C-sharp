/*
tính kế thừu 
A, B
B kế thừa A
A - cơ sở, cha
B - kế thừa, con

class B : A (khai báo lớp B kế thừa A)
{
  
}

Animal
  - Legs
  - Weight
  - ShowLegs()

Cat : Animal 
*/

#region using 
Cat c = new Cat(); //pg thuc khoi tao cua lop co so dc thi hanh trc vaf sau do lop kthua
c.showLegs();
c.eat();
c.showInfo();
#endregion


#region khai ba0
//*khai bao lop co so
/*nếu muốn animal không baoh đc kế thừa bởi lớp khác thì kbao như sau:
sealed class animal{}
animal đã bị niêm phong và cat ko thể kế thừa*/
class Animal
{
  public Animal()
  {
    Console.WriteLine("khoi tao animal");
  }

  public Animal(string abc)
  {
    Console.WriteLine("Khoi taoo Animal");
  }
  public int Legs {set; get;}
  public float Weight {set; get;}

//! neu pvi truy cap la private thi lop ke thua se khong truy cap dc
//! neu la protect thi ben ngoai khong truy cap dc(main) nhg lop ke thua van truy cap dc
  public void showLegs()
  {
    Console.WriteLine($"Legs: {Legs}");
  }
}

//* khai bao lop ke thua
class Cat : Animal
{
  public string food;

  public Cat() //mdich ko khai bao gif thif mdich Animal()
  //neu muon Animal(abc) thi sdung 
  //! public Cat() : base("Abc") -> chay phg thuc Animal (string abc)
  {
    this.Legs = 4;
    this.food = "Fish";
    Console.WriteLine("khoi tao cat");
  }

  public void eat()
  {
    Console.WriteLine(food);
  }

  //define lai phg thuc showLegs cua Animal cho Cat
  public new void showLegs()
  {
    Console.WriteLine($"Cat Legs: {Legs}");
  }

  public void showInfo()
  {
    base.showLegs(); //goi pg thuc o lop co so
    showLegs(); //goi pg thuc moi trong lop ke thua
    
  }
}

#endregion





