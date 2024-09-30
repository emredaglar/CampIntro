
using OOP2;
//Emre Dağlar
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Name = "Emre";
musteri1.TcNo = "123";
musteri1.Surname = "Dağlar";
musteri1.MusteriNo = "123";
musteri1.Id = 1;

//Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "1231";
musteri2.VergiNo = "111";
musteri2.SirketAdi = "Kodlama.io";

//Musteri sınıfı hem gercek hemde tüzel müsterinin referansını tutabiliyor.
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
