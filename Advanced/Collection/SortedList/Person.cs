using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //tao 1 constructor co tham so de tien cho viec khoi tao nhanh 
        //doi tuong Person voi cac gia tri cho san
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }

        //override cac phuong thuc ToString de khi can co the in thong tin cua object ra nhanh hon
        public override string ToString()
        {
            return "Name: " + Name + "\tAge: " + Age;
        }
    }
}
