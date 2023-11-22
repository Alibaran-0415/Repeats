using OOP3;

IKrediManager tasitKredi1=new TasitKrediManager();

IKrediManager ihtiyacKredi1=new IhtiyacKrediManager();

IKrediManager konutKredi1=new KonutKrediManager();

IKrediManager esnafKredi1 = new EsnafKrediManager();

ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService>() {fileLoggerService,databaseLoggerService};
BasvuruManager basvuru1=new BasvuruManager();
basvuru1.BasvuruYap(tasitKredi1,loggerServices);

BasvuruManager basvuru2=new BasvuruManager();
basvuru2.BasvuruYap(konutKredi1,new List<ILoggerService>() {databaseLoggerService,smsLoggerService});

Console.WriteLine("------DİZİ------");
BasvuruManager basvuru3 = new BasvuruManager();
List<IKrediManager> krediManagers=new List<IKrediManager>() {ihtiyacKredi1,konutKredi1,tasitKredi1,esnafKredi1};
basvuru3.OnDegerlendirme(krediManagers);









