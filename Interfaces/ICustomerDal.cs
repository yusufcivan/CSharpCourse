﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Orcale Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    } 

}
