using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   
    //Delegate là một biến kiểu tham chiếu(references) chứa tham chiếu tới một phương thức
    //thường được dùng để triển khai các phương thức hoặc sự kiện call-back.
    internal class Program
    {
      #region event_delegate
        /*delegate void UpdNamHandler(string name);
        static void Main(string[] args)
        {
            HocSinh hsinh = new HocSinh();
            hsinh.Name = "Hello";
            hsinh.NameChanged += Hsinh_NameChanged;//cach tuong minh hon
            //hsinh.NameChanged += (s) => { };        co the tai su dung cac bien ben ngoai de su dung
            Console.WriteLine("Ten tu clas: " + hsinh.Name);
            hsinh.Name = "Hiiiiiiii";
            Console.WriteLine("Ten tu clas: " + hsinh.Name)
                
                
                
                ;
            Console.ReadKey();
        }

        private static void Hsinh_NameChanged(string name)  
        {
            Console.WriteLine("Ten moi: " + name);        
        }

        class HocSinh
        {
            public event UpdNamHandler NameChanged;
            private string _Name;
            public string Name
            {
                get => _Name;
                set { _Name = value;
                    if (NameChanged != null) 
                    {
                        NameChanged(Name);      
                    } 
                }
            }
        }*/

        #endregion
    }
}


    
