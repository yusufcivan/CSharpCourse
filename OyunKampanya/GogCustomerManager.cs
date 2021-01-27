using System;
using System.Collections.Generic;
using System.Text;

namespace OyunKampanya
{
    public class GogCustomerManager : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Gog Kullanıcı Eklendi");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
