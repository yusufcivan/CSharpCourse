using System;

namespace OyunKampanya
{
    class Program
    {

        static void Main(string[] args)
        {
            SendUser();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SteamCustomerManager(),
                new GogCustomerManager()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(new Person person(){person. });
            }

            static void SendUser()
            {
                PersonManager manager = new PersonManager();
                Person person = new Person
                {
                    Id = 1,
                    FirstName = "Engin",
                    LastName = "Demiroğ",
                    TcNo = "222222",
                    BirthDay = 1990

                };







            }
        }
    }
}
