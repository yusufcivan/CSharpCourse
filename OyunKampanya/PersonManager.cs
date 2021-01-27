using System;
using System.Collections.Generic;
using System.Text;

namespace OyunKampanya
{
    public class PersonManager : IPersonDal
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName, person.LastName);
        }

        public void Add()
        {
            throw new NotImplementedException();
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
