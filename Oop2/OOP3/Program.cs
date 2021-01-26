using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //IKrediManager esnafKrediManager = new EsnafKredisiManager();
            //alternatif

           

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fiLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();
            //Alternatif


            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            //alternatif

            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), databaseLoggerService);
            //alternatif


            //List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService(), new DatabaseLoggerService()}
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
            //alt tarafta new yapılarak direk basvurumanagerde kullanılan versiyonu var 
            
            
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>{new DatabaseLoggerService(), new SmsLoggerService()});



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
