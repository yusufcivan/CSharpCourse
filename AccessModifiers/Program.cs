using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {

        //private int Id { get; set; }
        protected int Id { get; set; }


        public void Save()
        {
            
        }
    }

    class Student:Customer
    {
        public void Save2()
        {

        }
    }

    //internal class Course // internal erişime sahip olursa proje içerisinde diğer classlarda kullanabiliriz
    public class Course // public class'ları kullanmak istediğimiz farklı projenin referansına ekleyerek, using proje ismi ile kullanabiliriz

    {
        public string Name { get; set; }
        private class NestedClass // public veya internal class yapsaydık dışarıdan erişilebilirdi. private sadece tanımlandığı blokta
        {

        }
    }
    
    
}
