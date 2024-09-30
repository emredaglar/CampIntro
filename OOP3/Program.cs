using OOP3;

//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

//TasitKrediManager tasitKrediManager= new TasitKrediManager();
//tasitKrediManager.Hesapla();

//KonutKrediManager konutKrediManager=new KonutKrediManager(); 
//konutKrediManager.Hesapla();


IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService databaseLoggerService = new DatabaseLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();

basvuruManager.BasvuruYap(ihtiyacKrediManager,fileLoggerService);

List<IKrediManager> krediler=new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
//basvuruManager.KrediOnBilgilendirme(krediler);
//krediden 