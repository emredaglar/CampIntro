using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //krediye basvuru alacağız
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//hangi krediyi gönderirsem onun için çalışcak
        {
            //basvuru bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }
        //müşteri öreneğin 2 kredi türünün hesaplamasını istedi.Bir List<> oluştururuz çünkü içerisine kaç tane kredi göndereceğini bilmiyoruz.Listeler ne kadar gönderirirsen o kadar alabilir. Bu listenin türüde IKrediManager olmalı
        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
