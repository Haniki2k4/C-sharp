using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp4
{
    /// Collection:
    /// 
    /// Cac lop ho tro luu tru, quan ly, thao tac voi cac doi tg 1 cach co thu tu
    ///   -la 1 mang co kich thuoc dong
    ///     +ko can khai bao kich thuoc khi khoi tao
    ///     +co the tang giam so luong phan tu trong mang 1 cach linh hoat
    ///   -co the luu tru 1 tap hop dtg thuoc nhieu kieu != nhau
    ///   -ho tro rat nieu thao tac voi tap hop  
    ///   -moi collection dc to chuc thanh 1 lop nen can khoi tao doi tg trc khi sdung
    ///
    /// Collection & Array?
    ///     -diem manh của collection  
    ///         +co nhieu lop da dang ho tro cho tung muc dich khac nhau
    ///             (collection co the truy xuat thong qua chi so hoac key)
    ///         +voi dsach co thao tac tim kiem nhieu thi Cl co lop ho tro 
    ///             giup vc trim kiem nhanh hon array (HashTable)
    ///         +vs dasch can tdoio so lg ptu lien tuc thi Cl cx co ho tro
    ///         +Ho tro 2 cau truc du lieu: Stack & Queue
    ///   
    ///   -Khi nao sd Array, khi nao Cl
    ///     +array sd vs cac doi tg Strongly-type (kdl ko bi thay doi dot ngot, tuong minh)
    ///     +collection cung cap 1 cach linh hoat hon de lm vc voi danh sach
    ///
    /// 1 so lop Collection pho bien
    ///     +ArrayList
    ///     +HashTable
    ///     +SortedList
    ///     +Stack
    ///     +Queue
    ///     +BitArray
    /// 


    class Program
    {
        static void Main(string[] args)
        {
            #region khoi tao ArrayList
            ArrayList myArray = new ArrayList(); //khoi tao 1 arraylist rong
            ArrayList myArray2 = new ArrayList(5); //khoi tao 1 arraylist va chi dinh capacity ban dau la 5
            /*khoi tao 1 arraylist co kthuoc = myArray2
             sao chep toan bo ptu trong myArray2 vao arraylist moi tao*/
            ArrayList myArray3 = new ArrayList(myArray2);
            #endregion

            #region Sort()
            //cho phep ng dung tu dinh nghia cach sap xep theo y minh
            //tham so truyen vao la 1 lop ke thua tu interface IComparer
                //interface IComparer chua 1 pgh thuc duy nhat la int Compare(object x, object y)
                // tra ve 3 gia tri
                // < 0 : x < y
                // > 0 : x > y
                // = 0 : x = y


            //tao 1 list kieu ArrayList rong
            ArrayList addPersons = new ArrayList();
            //them 3 person vao list
            addPersons.Add(new Person("Nguyen Van A", 18));
            addPersons.Add(new Person("Nguyen Van B", 30));
            addPersons.Add(new Person("Nguyen Van C", 26));

            Console.WriteLine("Danh sach sap xep ban dau: ");
            foreach (Person item in addPersons)
            {
                Console.WriteLine(item.ToString());
            }


            ///thuc hien sap xep danh sach Person theo 
            ///trong ph thuc Compare caur lop SortPerson 
            ///

            addPersons.Sort(new SortPerson());
            Console.WriteLine();
            Console.WriteLine("Danh sach Person da duoc sap xep: ");
            foreach (Person item in addPersons)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
            #endregion
        }
    }

    public class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;

            /*Vi co the 2 obj truyen vao ko phai Person khi do ta ko the so sanh dc
             Truong hop nay tot nhat ta nen nem ra loi de lap trinh vien sua*/
            if(p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                /*khi dlieu da ok thi ta thuc hien so sanh va tra gia tri ve 
                 * cac gia tri 1 0 -1 tuong ung lon honw, bang, be hon*/

                if (p1.Age < p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

        }
    }
}
