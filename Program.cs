using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int masaSayisi = 10;
            bool[] masaDurumu = new bool[10];
            int[] menuFiyatlar = { 120, 120, 120, 200, 190, 250, 130, 230, 360, 180, 170, 170, 50, 60, 55, 65, 70, 40, 100, 100, 200, 200, 250, 230 };
            int[] masaUcretleri = new int[24];
            string[] menu = {"[1] Mercimek Çorbası 100TL", "[2] Ezogelin Çorbası 120TL", "[3] Domates Çorbası 120TL", "[4] Kelle Paça 200TL",
            "[5] Dört Peynirli Pizza 190TL","[6] Bol Malzemos Pizza 250TL", "[7] Pesto Soslu Pizza 130TL", "[8] Karışık Pizza 230TL",
            "[9] Hünkar Beğendi 360TL", "[10] Tavuk Dürüm 180TL", "[11] Lahmacun 170TL", "[12] Pide 170TL","[13] Su 50TL",
            "[14] Ayran 60TL", "[15] Soda 55TL", "[16] Şalgam 65TL", "[17] Türk Kahvesi 70TL", "[18] Çay 40TL", "[19] Filtre Kahve 100TL",
            "[20] Salep 1000TL", "[21] Tiramisu 200TL", "[22] Çikolatalı Pasta 200TL", "[23] Baklava 250TL", "[24] Profiterol 230TL"};

        anamenu:
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                  ANA MENÜ                   ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Masa Aç                [1]");
            Console.WriteLine("Masa İşlem             [2]");
            Console.WriteLine("Masa Hesap             [3]");
            Console.WriteLine("Kasa İşlemleri         [4]");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("ÇIKIŞ YAP              [0]");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Seçiminiz: ");

            int secim = int.Parse(Console.ReadLine());

            while (true)
            {
                if (secim == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else if (secim == 1)
                {

                masaAc:
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("                  MASA AÇ                    ");
                    Console.WriteLine("---------------------------------------------");

                    for (int i = 1; i <= masaDurumu.Length; i++)
                    {
                        Console.WriteLine($"Masa {i}: {(masaDurumu[i - 1] ? "DOLU" : "BOŞ")}");
                    }
                    Console.Write("Lütfen açmak istediğiniz boş masa numarasını giriniz (Çıkış için ESC): ");

                    ConsoleKeyInfo cikis = Console.ReadKey(true);

                    if (cikis.Key == ConsoleKey.Escape)
                    {
                        goto anamenu;
                    }

                    int masaNo = int.Parse(Console.ReadLine());

                    if (masaNo <= 0 || masaNo > masaDurumu.Length)
                    {
                        Console.WriteLine("Geçersiz masa numarası girdiniz, lütfen tekrar masa numarası girin.");
                        Console.ReadLine();
                        goto masaAc;
                    }
                    else if (masaDurumu[masaNo - 1])
                    {
                        Console.WriteLine("Bu masa zaten dolu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        masaDurumu[masaNo - 1] = true;
                        Console.WriteLine($"Masa {masaNo} başarıyla açıldı.");
                        Console.ReadLine();
                    }
                    masaDurumu[masaNo - 1] = true;
                }
                else if (secim == 2)
                {

                menu:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("                       MASA İŞLEM                             ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("                          MENÜ                                ");

                    Console.WriteLine("\n--------------------------Çorbalar--------------------------");
                    Console.WriteLine();
                    Console.Write("[1] Mercimek Çorbası 120TL\t");
                    Console.WriteLine("[2] Ezogelin Çorbası 120TL\t");
                    Console.Write("[3] Domates Çorbası 120TL\t");
                    Console.WriteLine("[4] Kelle Paça 200TL\t");

                    Console.WriteLine("\n---------------------------Pizzalar---------------------------");
                    Console.WriteLine();
                    Console.Write("[5] Dört Peynirli Pizza 190TL\t");
                    Console.WriteLine("[6] Bol Malzemos Pizza 250TL\t");
                    Console.Write("[7] Pesto Soslu Pizza 130TL\t");
                    Console.WriteLine("[8] Karışık Pizza 230TL\t");

                    Console.WriteLine("\n---------------------------Ana Yemekler------------------------");
                    Console.WriteLine();
                    Console.Write("[9] Hünkar Beğendi 360TL\t");
                    Console.WriteLine("[10] Tavuk Dürüm 180TL\t");
                    Console.Write("[11] Lahmacun 170TL\t\t");
                    Console.WriteLine("[12] Pide 170TL\t");

                    Console.WriteLine("\n---------------------------Soğuk İçecekler---------------------");
                    Console.WriteLine();
                    Console.Write("[13] Su 50TL\t\t\t");
                    Console.WriteLine("[14] Ayran 60TL\t\t\t");
                    Console.Write("[15] Soda 55TL\t\t\t");
                    Console.WriteLine("[16] Şalgam 65TL\t\t\t");

                    Console.WriteLine("\n---------------------------Sıcak İçecekler----------------------");
                    Console.WriteLine();
                    Console.Write("[17] Türk Kahvesi 70TL\t\t");
                    Console.WriteLine("[18] Çay 40TL\t\t");
                    Console.Write("[19] Filtre Kahve 100TL\t\t");
                    Console.WriteLine("[20] Salep 100TL\t\t");

                    Console.WriteLine("\n---------------------------Tatlılar----------------------------");
                    Console.WriteLine();
                    Console.Write("[21] Tiramisu 200TL\t\t");
                    Console.WriteLine("[22] Çikolatalı Pasta  200TL\t\t");
                    Console.Write("[23] Baklava 250TL\t\t");
                    Console.WriteLine("[24] Profiterol 230TL\t\t");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------------");

                    Console.Write("Masa seçiniz: ");
                    int masaNo = int.Parse(Console.ReadLine());

                    if (masaNo <= 0 || masaNo > masaDurumu.Length)
                    {
                        Console.WriteLine("Yalnızca 10 masamız vardır, lütfen uygun masa numarası giriniz...");
                        Console.ReadKey();
                        goto menu;
                    }

                    else if (masaDurumu[masaNo - 1] == true)
                    {

                    siparis:
                        Console.Write("Lütfen sipariş numarasını giriniz (Geri gitmek için Sol Ok, Ana menü için ESC'ye basın): ");

                        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

                        if (consoleKeyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("Anamenüye dönülüyor...");
                            Console.ReadKey();
                            goto anamenu;
                        }
                        else if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            Console.WriteLine("Geri gidiliyor...");
                            Console.ReadKey();
                            goto menu;
                        }

                        int siparisGiris = int.Parse(Console.ReadLine());

                        if (siparisGiris >= 1)
                        {
                            masaUcretleri[masaNo] += menuFiyatlar[siparisGiris - 1];
                            Console.WriteLine($"{menu[siparisGiris - 1]} siparişi alındı. (Toplam: {masaUcretleri[masaNo]} TL)");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz sipariş numarası girdiniz, lütfen tekrar deneyin.");
                            goto anamenu;
                        }

                        Console.WriteLine("Onaylamak için SPACE'e basın.");
                        consoleKeyInfo = Console.ReadKey(true);

                        if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                        {
                            masaDurumu[masaNo] = true;
                            Console.WriteLine("Sipariş onaylandı.");
                            goto siparis;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bu masa henüz açılmamıştır.");
                        Console.ReadKey();
                        goto anamenu;
                    }

                }
                else if (secim == 3)
                {
                    Console.Clear();
                    Console.Write("Hesabını görmek istediğiniz masa numarasını giriniz: ");
                    int hesapMasa = int.Parse(Console.ReadLine());
                    int masaNo = hesapMasa;

                    if (masaNo == hesapMasa)
                    {
                        Console.WriteLine($"Masa {hesapMasa} Toplam Hesap: {masaUcretleri[masaNo]} TL");
                    }
                    Console.WriteLine("Ana menüye dönmek için ENTER'a basın.");

                    ConsoleKeyInfo go = Console.ReadKey(true);

                    if (go.Key == ConsoleKey.Enter)
                    {
                        goto anamenu;
                    }

                }
                else if (secim == 4)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("               KASA İŞLEMLERİ                ");
                    Console.WriteLine("---------------------------------------------");
                    double gunSonu = 0;

                    for (int i = 1; i <= masaDurumu.Length; i++)
                    {
                        Console.WriteLine($"Masa {i} : {(masaDurumu[i - 1] ? "DOLU" : "BOŞ")} --------> Toplam Tutar: {masaUcretleri[i - 1]} TL");
                        gunSonu = gunSonu + masaUcretleri[i - 1];
                    }

                    Console.WriteLine("*********************************************");
                    Console.WriteLine($"    Gün Sonu Toplam Kazanç: {gunSonu} TL    ");
                    Console.WriteLine("*********************************************");

                    Console.WriteLine("Ana menüye dönmek için ENTER'a basın.");
                    Console.ReadLine();
                    goto anamenu;
                }

            }

        }
    }
}
