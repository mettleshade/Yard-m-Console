using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mettless_Yardım_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.SetWindowSize(60, 55);
            Console.Title = "Mettless Dizayn Hızlı İşlem";
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- METTLESS DİZAYN --- MEHMET PAÇAL -");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-                                  -");
            Console.WriteLine("-                                  -");
            Console.WriteLine("- Bilgisayar İşlemleri         : 1 -");
            Console.WriteLine("- İnternet İşlemleri           : 2 -");
            Console.WriteLine("- İnternette Gezin             : 3 -");
            Console.WriteLine("- Windows Programları          : 4 -");
            Console.WriteLine("- Ekranı Temizle               : 5 -");
            Console.WriteLine("- Çıkış                        : 6 -");
            Console.WriteLine("-                                  -");
            Console.WriteLine("-                                  -");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.Write("- Bir Seçenek Belirle          : ");

            string secim = null;

            while (secim != "6")
            {

                if (secim == "1")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Pcyi 10Sn İçinde Kapat     : 1.1 -");
                    Console.WriteLine("- Pcyi 10Dk İçinde Kapat     : 1.2 -");
                    Console.WriteLine("- Pcyi 20Dk İçinde Kapat     : 1.3 -");
                    Console.WriteLine("- Pcyi 30Dk İçinde Kapat     : 1.4 -");
                    Console.WriteLine("- Pcyi 40Dk İçinde Kapat     : 1.5 -");
                    Console.WriteLine("- Pcyi 50Dk İçinde Kapat     : 1.6 -");
                    Console.WriteLine("- Pcyi 60Dk İçinde Kapat     : 1.7 -");
                    Console.WriteLine("- Pcyi 120Dk İçinde Kapat    : 1.8 -");
                    Console.WriteLine("- Pcyi Yeniden Başlat        : 1.9 -");
                    Console.WriteLine("- Oturumu Kapat              : 1.10-");
                    Console.WriteLine("- Kapatma İşlemini İptal Et  : 11  -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.Write("- Bir Seçenek Belirle           : ");
                }
                
                if (secim == "2")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Modem Geçmişini Temizle    : 2.1 -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Geri                       : 5   -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                
                if (secim == "3")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Google                      : G  -");
                    Console.WriteLine("- Facebook                    : F  -");
                    Console.WriteLine("- Twitter                     : T  -");
                    Console.WriteLine("- İnstagram                   : İ  -");
                    Console.WriteLine("- YouTube                     : Y  -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Geri                        : 5  -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Görev Yöneticisi           : 4.1 -");
                    Console.WriteLine("- Sistem Yapılandırması      : 4.2 -");
                    Console.WriteLine("- Bilgisayar Özellikleri     : 4.3 -");
                    Console.WriteLine("- Kayıt Defteri              : 4.4 -");
                    Console.WriteLine("- Hesap Makinesi             : 4.5 -");
                    Console.WriteLine("- Ekran Alıntı Aracı         : 4.6 -");
                    Console.WriteLine("- Paint                      : 4.7 -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Geri                       : 5   -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.1")
                {
                    System.Diagnostics.Process.Start("taskmgr.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Görev Yönetici Başlatıldı        -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.2")
                {
                    System.Diagnostics.Process.Start("msconfig.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Sistem Yapılandırması Başlatıldı -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.3")
                {
                    System.Diagnostics.Process.Start("dxdiag.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Pc Özellikleri Başlatıldı        -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.4")
                {
                    System.Diagnostics.Process.Start("regedit.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Kayıt Defteri Başlatıldı         -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.5")
                {
                    System.Diagnostics.Process.Start("calc.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Hesap Makinesi Başlatıldı        -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.6")
                {
                    System.Diagnostics.Process.Start("SnippingTool.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Ekran Alıntı Aracı Başlatıldı    -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "4.7")
                {
                    System.Diagnostics.Process.Start("mspaint.exe");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Paint Başlatıldı                 -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.1")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 10Sn İçinde Kapanacak  ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.2")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 600");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 10Dk İçinde Kapanacak  ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }

                if (secim == "1.3")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 1200");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 20Dk İçinde Kapanacak  ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");

                }
                if (secim == "1.4")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 1800");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 30Dk İçinde Kapanacak  ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.5")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 2400");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 40Dk İçinde Kapanacak  ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.6")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 3000");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("- Bilgisayar 50Dk İçinde Kapanacak ");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("-                                 -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.7")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 3600");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 60Dk İçinde Kapanacak -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.8")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -s -t 7200");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar 120D İçinde Kapanacak -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.9")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -r");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Bilgisayar Yeniden Başlatılıyor  -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "1.10")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -l");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Oturum Kapatılıyor               -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "11")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C shutdown -a");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Kapatma İşlemi İptal Edildi !    -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "2.1")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/C ipconfig /flushdns");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Başarıyla Dns Ayarları Sıfırlandı ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "5")
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- METTLESS DİZAYN --- MEHMET PAÇAL -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("- Bilgisayar İşlemleri         : 1 -");
                    Console.WriteLine("- İnternet İşlemleri           : 2 -");
                    Console.WriteLine("- İnternette Gezin             : 3 -");
                    Console.WriteLine("- Windows Programları          : 4 -");
                    Console.WriteLine("- Ekranı Temizle               : 5 -");
                    Console.WriteLine("- Çıkış                        : 6 -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------------------------------");
                    Console.Write("- Bir Seçenek Belirle          : ");
                }
                if (secim == "G" || secim == "g" )
                {
                    System.Diagnostics.Process.Start("chrome.exe", "http://www.google.com");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Google'a Gidiliyor !             -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                } if (secim == "F" || secim == "f")
                {
                    System.Diagnostics.Process.Start("chrome.exe", "http://www.facebook.com");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Facebook'a Gidiliyor !           -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }

                if (secim == "İ" || secim == "i")
                {
                    System.Diagnostics.Process.Start("chrome.exe", "http://www.instagram.com");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- İnstagrama Gidiliyor !           -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }

                if (secim == "T" || secim == "t")
                {
                    System.Diagnostics.Process.Start("chrome.exe", "http://www.twitter.com");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- Twitter'e Gidiliyor !            -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }
                if (secim == "Y" || secim == "y")
                {
                    System.Diagnostics.Process.Start("chrome.exe", "http://www.youtube.com");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("- YouTubeye Gidiliyor !            -");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-                                  -");
                    Console.Write("- Bir Seçenek Belirle  : ");
                }


                secim = Console.ReadLine();
            }

        }
    }
}

