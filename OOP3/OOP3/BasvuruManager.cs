using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService) {
            krediManager.Hesapla();
            for (int i = 0; i < loggerService.Count; i++)
            {
                loggerService[i].Log();
            }
        }

        public void OnDegerlendirme(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
