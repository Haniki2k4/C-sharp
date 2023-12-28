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
    {#region event chuẩn .net
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Hsinh hs = new Hsinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "thay doi lan 1";
            hs.Name = "thay doi lan 2";
            hs.Name = "thay doi lan 3";
            
            Console.ReadKey();
        }

        private static void Hs_NameChanged(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("ten co su thay doi la: "+ e.Name);
        }

        class Hsinh
        {
            private string _Name;
            public string Name
            {
                get => _Name;
                set 
                { _Name = value;
                    OnNameChanged(value);
                }

            }
            private event EventHandler<NameChangedEventArgs> _NameChanged;
            public event EventHandler<NameChangedEventArgs> NameChanged
            {
                add
                {
                    _NameChanged += value;
                }
                remove
                {
                    _NameChanged -= value;
                }
            }
            void OnNameChanged(string name)
            {
                if(_NameChanged != null )
                {
                    _NameChanged( this, new NameChangedEventArgs(name));
                }
            }
        }
        public class NameChangedEventArgs : EventArgs
        {
            public string Name { set; get; }
            public NameChangedEventArgs(string name)
            {
                Name = name;
            }
        }

        #endregion

    }
}
