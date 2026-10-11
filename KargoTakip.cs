
namespace Projem.App
{
    public class KargoTakip
    {
        public static void Main()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       HIZLI KARGO TAKİP SİSTEMİ     ");
            Console.WriteLine("=====================================");
            // sube bigileri
            string subeAdi="Kocaeli/gebze";
            int subeKodu=41100;
            string calisanAdi="bengi";
            DateTime sistemTarihi=DateTime.Now;

            //korga bilgileri
            string[] musteriAdi=new string[3];
            string[] takipKodu= new string[3];
            string[] sehirAdi=new string[3];
            decimal[] agirlik=new decimal[3];
            bool[] sigortaVar=new bool[3];
            DateTime[] gönderimTarihi=new DateTime[3];
            DateTime[] tahminiTeslimTarihi=new DateTime[3];

            //kargo1
            Console.WriteLine("**********************");
            Console.WriteLine("Kargo 1   ");
            Console.WriteLine("**********************");

            Console.WriteLine("Müsteri Adini Giriniz");
            Console.Write("Müsteri adi:");
            musteriAdi[0]=Console.ReadLine().Trim();

            Console.WriteLine("Takip Kodunu Giriniz");
            Console.Write("Takip kodu:");
            takipKodu[0]=Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("Teslim Edilecek Şehri Giriniz");
            Console.Write("Teslimat sehri:");
            sehirAdi[0]=Console.ReadLine().Trim();

            Console.WriteLine("Kargo Agiriliginizi Giriniz");
            Console.Write("Kargo Agirligi:");
            agirlik[0]=Convert.ToDecimal(Console.ReadLine().Trim());

            Console.WriteLine("Sigortali Olup Olmadigi Bilgisini Giriniz");
            Console.Write("Sigortali mi?");
            sigortaVar[0]=Convert.ToBoolean(Console.ReadLine().Trim());

            Console.WriteLine("Göndereceginiz Tarihi Giriniz");
            Console.Write("Gönderim Tarihi");
            gönderimTarihi[0]=Convert.ToDateTime(Console.ReadLine().Trim());

            tahminiTeslimTarihi[0]=gönderimTarihi[0].AddDays(3);
            TimeSpan teslimSuresi1=tahminiTeslimTarihi[0]-gönderimTarihi[0];

            Console.WriteLine("**********************");
            Console.WriteLine("Kargo 2   ");
            Console.WriteLine("**********************");

            Console.WriteLine("Müsteri Adini Giriniz");
            Console.Write("Müsteri adi:");
            musteriAdi[1]=Console.ReadLine().Trim();

            Console.WriteLine("Takip Kodunu Giriniz");
            Console.Write("Takip kodu:");
            takipKodu[1]=Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("Teslim Edilecek Şehri Giriniz");
            Console.Write("Teslimat sehri:");
            sehirAdi[1]=Console.ReadLine().Trim();

            Console.WriteLine("Kargo Agiriliginizi Giriniz");
            Console.Write("Kargo Agirligi:");
            agirlik[1]=Convert.ToDecimal(Console.ReadLine().Trim());

            Console.WriteLine("Sigortali Olup Olmadigi Bilgisini Giriniz");
            Console.Write("Sigortali mi?:");
            sigortaVar[1]=Convert.ToBoolean(Console.ReadLine().Trim());

            Console.WriteLine("Göndereceginiz Tarihi Giriniz");
            Console.Write("Gönderim Tarihi:");
            gönderimTarihi[1]=Convert.ToDateTime(Console.ReadLine().Trim());

            tahminiTeslimTarihi[1]=gönderimTarihi[1].AddDays(3);
            TimeSpan teslimSuresi2=tahminiTeslimTarihi[1]-gönderimTarihi[1];

            Console.WriteLine("**********************");
            Console.WriteLine("Kargo 3               ");
            Console.WriteLine("**********************");

            Console.WriteLine("Müsteri Adini Giriniz");
            Console.Write("Müsteri adi:");
            musteriAdi[2]=Console.ReadLine().Trim();

            Console.WriteLine("Takip Kodunu Giriniz");
            Console.Write("Takip kodu:");
            takipKodu[2]=Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("Teslim Edilecek Şehri Giriniz");
            Console.Write("Teslimat sehri:");
            sehirAdi[2]=Console.ReadLine().Trim();

            Console.WriteLine("Kargo Agiriliginizi Giriniz");
            Console.Write("Kargo Agirligi:");
            agirlik[2]=Convert.ToDecimal(Console.ReadLine().Trim());

            Console.WriteLine("Sigortali Olup Olmadigi Bilgisini Giriniz");
            Console.Write("Sigortali mi?:");
            sigortaVar[2]=Convert.ToBoolean(Console.ReadLine().Trim());

            Console.WriteLine("Göndereceginiz Tarihi Giriniz");
            Console.Write("Gönderim Tarihi:");
            gönderimTarihi[2]=Convert.ToDateTime(Console.ReadLine().Trim());

            tahminiTeslimTarihi[2]=gönderimTarihi[2].AddDays(3);
            TimeSpan teslimSuresi3=tahminiTeslimTarihi[2]-gönderimTarihi[2];


            decimal toplamAgirlik=(agirlik[0]+agirlik[1]+agirlik[2]);
            decimal ortAgirlik=toplamAgirlik/3;

            Console.WriteLine("                           ");
            Console.WriteLine("===========================");
            Console.WriteLine("KARGO #1                   ");
            Console.WriteLine("===========================");
            Console.WriteLine("                           ");
            Console.WriteLine($"Müsteri         : {musteriAdi[0]}");
            Console.WriteLine($"Takip Kodu      : {takipKodu[0]}");
            Console.WriteLine($"Şehir           : {sehirAdi[0]}");
            Console.WriteLine($"Ağirlik         : {agirlik[0]}");
            Console.WriteLine($"Sigortali       : {sigortaVar[0]}");
            Console.WriteLine($"Gönderim        : {gönderimTarihi[0]}");
            Console.WriteLine($"Tahmini Teslim  : {tahminiTeslimTarihi[0]}");
            Console.WriteLine($"Teslim Süresi   : {teslimSuresi1}");

            Console.WriteLine("                           ");
            Console.WriteLine("===========================");
            Console.WriteLine("KARGO #2                   ");
            Console.WriteLine("===========================");
            Console.WriteLine("                           ");
            Console.WriteLine($"Müsteri         : {musteriAdi[1]}");
            Console.WriteLine($"Takip Kodu      : {takipKodu[1]}");
            Console.WriteLine($"Şehir           : {sehirAdi[1]}");
            Console.WriteLine($"Ağirlik         : {agirlik[1]}");
            Console.WriteLine($"Sigortali       : {sigortaVar[1]}");
            Console.WriteLine($"Gönderim        : {gönderimTarihi[1]}");
            Console.WriteLine($"Tahmini Teslim  : {tahminiTeslimTarihi[1]}");
            Console.WriteLine($"Teslim Süresi   : {teslimSuresi2}");

            Console.WriteLine("                           ");
            Console.WriteLine("===========================");
            Console.WriteLine("KARGO #3                   ");
            Console.WriteLine("===========================");
            Console.WriteLine("                           ");
            Console.WriteLine($"Müsteri         : {musteriAdi[2]}");
            Console.WriteLine($"Takip Kodu      : {takipKodu[2]}");
            Console.WriteLine($"Şehir           : {sehirAdi[2]}");
            Console.WriteLine($"Ağirlik         : {agirlik[2]}");
            Console.WriteLine($"Sigortali       : {sigortaVar[2]}");
            Console.WriteLine($"Gönderim        : {gönderimTarihi[2]}");
            Console.WriteLine($"Tahmini Teslim  : {tahminiTeslimTarihi[2]}");
            Console.WriteLine($"Teslim Süresi   : {teslimSuresi3}");
            
            Console.WriteLine("===============================");
            Console.WriteLine("         GÜN SONU ÖZETİ        ");
            Console.WriteLine("===============================");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine($"Şube            :{subeAdi}");
            Console.WriteLine($"Şube Kodu       :{subeKodu}");
            Console.WriteLine($"Çalişan         :{calisanAdi}");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("Toplam gönderi   :" +musteriAdi.Length);
            Console.WriteLine("Toplam Ağirlik   :" +toplamAgirlik);
            Console.WriteLine("Ortalama Ağirlik :" +ortAgirlik);
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("Sistem Tarihi    :"+sistemTarihi);
            Console.WriteLine("===============================");

            
        }
    }
} 

