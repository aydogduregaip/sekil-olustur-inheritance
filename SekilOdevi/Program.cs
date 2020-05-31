using System;

namespace SekilOdevi
{
    abstract class Sekiller
    {
        public char sembol { get; set; }
        public bool DoluMu { get; set; }
        public DateTime Zaman { get; private set; }
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
        public abstract void ciz();
        public abstract void OzellikYazdir();

        public Sekiller()
        {
        }
        public Sekiller(char karakter)
        {
            sembol = karakter;
        }
        public Sekiller(char karakter, bool icdolu)
        {
            Zaman = DateTime.Now;
            sembol = karakter;
            DoluMu = icdolu;
        }

    }
    class Ucgen : Sekiller
    {
        public double kenar { get; set; }

        public Ucgen()
        {
        }
        public Ucgen(double kenaruzunluk)
        {
            kenar = kenaruzunluk;
        }

        public override double AlanHesapla()
        {
            return Math.Pow(kenar, 2) * Math.Sqrt(3) / 4;
        }

        public override double CevreHesapla()
        {
            return kenar * 3;
        }

        public override void ciz()
        {
            if (DoluMu == true)
            {
                for (int i = 1; i < kenar; i++)
                {
                    for (int j = i; j < kenar; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(sembol);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                double icBosluk, disBosluk;
                icBosluk = -1;
                disBosluk = kenar - 1;
                for (int i = 1; i <= kenar - 1; i++)
                {
                    if (i != kenar)
                    {
                        for (int j = 1; j <= disBosluk; j++)
                            Console.Write(" ");
                        Console.Write(sembol);
                    }
                    if (i != 1)
                    {
                        for (int j = 1; j <= icBosluk; j++)
                            Console.Write(" ");
                        Console.Write(sembol);
                    }
                    icBosluk += 2;
                    disBosluk--;
                    Console.Write("\n");
                }
                icBosluk += 2;
                for (int i = 1; i <= icBosluk; i++)
                    Console.Write(sembol);
                Console.Write("\n");
            }
        }

        public override void OzellikYazdir()
        {
            Console.WriteLine(Zaman + "tarihinde olusturulan ucgen sınıfı-------->" + "kenar--->" + kenar + "Alani--->" + AlanHesapla() + "Cevresi--->" + CevreHesapla());
        }

    }
    class Dikdortgen : Sekiller
    {
        public double yukseklik { get; set; }
        public double genislik { get; set; }

        public Dikdortgen()
        {
        }
        public Dikdortgen(double yuksekligi, double genisligi)
        {
            yukseklik = yuksekligi;
            genislik = genisligi;
        }

        public override double AlanHesapla()
        {
            return yukseklik * genislik;
        }

        public override double CevreHesapla()
        {
            return (2 * yukseklik) + (2 * genislik);
        }

        public override void ciz()
        {
            if (DoluMu == false)
            {
                for (int i = 1; i <= yukseklik; i++)
                {
                    for (int j = 1; j <= genislik; j++)
                    {
                        if (i == 1 || i == yukseklik)
                            Console.Write(sembol);
                        else
                            if (j == 1 || j == genislik)
                            Console.Write(sembol);
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                for (int j = 1; j <= yukseklik; j++)
                {
                    Console.WriteLine("\n");
                    for (int i = 1; i <= genislik; i++)
                    {
                        Console.Write(" " + sembol + " ");
                    }
                }
                Console.ReadKey();
            }
        }

        public override void OzellikYazdir()
        {
            Console.WriteLine(Zaman + "tarihinde olusturulan dikdortgen sınıfı-------->" + "yukseklik--->" + yukseklik + "genislik--->" + genislik + "Alani--->" + AlanHesapla() + "Cevresi--->" + CevreHesapla());
        }
    }
    class EskenarDortgen : Dikdortgen
    {
        public double yukseklik { get; set; }
        public double genislik { get; set; }
        public EskenarDortgen()
        {
        }
        public EskenarDortgen(double yuksekligin, double genisligin)
        {
            genislik = genisligin;
            yukseklik = yuksekligin;
        }

        public override double AlanHesapla()
        {
            return genislik * yukseklik;
        }

        public override double CevreHesapla()
        {
            return 4 * genislik;
        }

        public override void ciz()
        {
            if (DoluMu == true)
            {
                for (int i = 0; i <= genislik; i++)
                {
                    for (int j = 0; j <= (genislik + 1) - i; j++)
                        Console.Write(" ");
                    for (int k = 0; k <= 2 * i - 2; k++)
                        Console.Write(sembol);
                    Console.WriteLine();
                }
                for (int m = 0; m <= genislik; m++)
                {
                    for (int n = 0; n <= m; n++)
                        Console.Write(" ");
                    for (int z = m * 2; z <= genislik * 2; z++)
                        Console.Write(sembol);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                double icBosluk, disBosluk;
                icBosluk = -1;
                disBosluk = genislik - 1;
                for (int i = 1; i <= genislik; i++)
                {
                    for (int j = 1; j <= disBosluk; j++)
                        Console.Write(" ");
                    Console.Write(sembol);
                    if (i != 1)
                    {
                        for (int j = 1; j <= icBosluk; j++)
                            Console.Write(" ");
                        Console.Write(sembol);
                    }
                    Console.Write("\n");
                    icBosluk += 2;
                    disBosluk--;
                }
                icBosluk -= 4;
                disBosluk = 1;
                for (int i = 1; i < genislik; i++)
                {
                    for (int j = 1; j <= disBosluk; j++)
                        Console.Write(" ");
                    Console.Write(sembol);
                    if (i != genislik - 1)
                    {
                        for (int j = 1; j <= icBosluk; j++)
                            Console.Write(" ");
                        Console.Write(sembol);
                    }
                    Console.Write("\n");
                    icBosluk -= 2;
                    disBosluk++;
                }
            }
        }

        public override void OzellikYazdir()
        {
            Console.WriteLine(Zaman + "tarihinde olusturulan dikdortgen sınıfında EskenarDortgenin -------->" + "yukseklik--->" + yukseklik + "genislik--->" + genislik + "Alani--->" + AlanHesapla() + "Cevresi--->" + CevreHesapla());
        }
    }
    class ParalelKenar : Sekiller
    {
        public bool Yon { get; set; }
        public double yukseklik { get; set; }
        public double genislik { get; set; }

        public ParalelKenar()
        {
        }
        public ParalelKenar(bool yon)
        {
            Yon = yon;
        }
        public ParalelKenar(double yuksekliginizi, double genisliginiz)
        {
            yukseklik = yuksekliginizi;
            genislik = genisliginiz;
        }
        public ParalelKenar(bool yon, double yuksekliginizi, double genisliginizi)
        {
            Yon = yon;
            yukseklik = yuksekliginizi;
            genislik = genisliginizi;
        }
        public override double AlanHesapla()
        {
            return genislik * yukseklik;
        }

        public override double CevreHesapla()
        {
            return (2 * genislik) + (2 * yukseklik);
        }

        public override void ciz() //false ssola egık true saga egik
        {
            if (DoluMu == true && Yon == true)
            {
                for (int i = 1; i <= yukseklik; i++)
                {
                    for (int j = 1; j <= yukseklik - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= genislik; j++)
                        if (i == 1 || i == yukseklik || j == 1 || j == genislik)
                            Console.Write(sembol);
                        else
                            Console.Write(sembol);
                    Console.Write("\n");
                }
            }
            else if (DoluMu == false && Yon == true)
            {
                for (int i = 1; i <= yukseklik; i++)
                {
                    for (int j = 1; j <= yukseklik - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= genislik; j++)
                        if (i == 1 || i == yukseklik || j == 1 || j == genislik)
                            Console.Write(sembol);
                        else
                            Console.Write(" ");
                    Console.Write("\n");
                }
            }
            else if (DoluMu == true && Yon == false)
            {
                for (int i = 0; i < yukseklik; i++)
                {
                    for (int j = 0; j < genislik; j++)
                        Console.Write(sembol);
                    Console.WriteLine();
                    for (int l = 0; l <= i; l++)
                        Console.Write("  ");
                }
                Console.ReadLine();
            }
            else if (DoluMu == false && Yon == false)
            {
                for (int i = 1; i <= yukseklik; i++)
                {
                    for (int j = 2; j <= i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= genislik; j++)
                        if (i == 1 || i == yukseklik || j == 1 || j == genislik)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    Console.Write("\n");
                }
            }

        }

        public override void OzellikYazdir()
        {
            Console.WriteLine(Zaman + "tarihinde olusturulan dikdortgen sınıfında ParalelKenarin -------->" + "yukseklik--->" + yukseklik + "genislik--->" + genislik + "Alani--->" + AlanHesapla() + "Cevresi--->" + CevreHesapla());
        }
    }
    class TEST
    {
        static void Main()
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            Ucgen ucgen = new Ucgen();
            ParalelKenar paralelkenar = new ParalelKenar();
            EskenarDortgen eskenardortgen = new EskenarDortgen();

            double sonuc;
            double girilen;
        etiket3:
            Console.Write("Olusturulacak Sekli Seciniz\n1-)Dikdortgen\n2-)Ucgen\n3-)EskenarDortgen\n4-)Paralelkenar\n5-)Cikis");
            girilen = double.Parse(Console.ReadLine());
            if (girilen == 1)
            {
                Console.Write("Dikdortgenin Genisligini Giriniz: ");
                dikdortgen.genislik = double.Parse(Console.ReadLine());
                Console.Write("Dikdortgenin Yuksekligini Giriniz ");
                dikdortgen.yukseklik = double.Parse(Console.ReadLine());

            etiket1:
                Console.Write("1-)Alan Hesapla\n2-)Cevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Uzunluk Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Bilgileri Yazdir\n9-)Ust Menu\n10-)Cikis");
                girilen = double.Parse(Console.ReadLine());
                if (girilen == 1)
                {
                    sonuc = dikdortgen.AlanHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 2)
                {
                    sonuc = dikdortgen.CevreHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 3)
                {
                    Console.Write("Cizilen Dikdortgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    dikdortgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    dikdortgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Secimlerinizi Degistirmek Istiyorsaniz ust menuye donun\nUst Menuye Donmek ıcin 1 tuslayin\nDevam etmek icin 2 tuslayin");
                    girilen = double.Parse(Console.ReadLine());
                    if (girilen == 1)
                    {
                        goto etiket1;
                    }
                    else
                    {
                        goto etiket2;
                    }
                etiket2:
                    dikdortgen.ciz();
                }
                else if (girilen == 4)
                {
                    Console.Write("Dikdortgene ait yeni genisligi giriniz:");
                    dikdortgen.genislik = double.Parse(Console.ReadLine());
                    Console.Write("Genislik Degisti Yeni Genislik ile isleminizi yapiniz\n");
                    goto etiket1;
                }
                else if (girilen == 5)
                {
                    Console.Write("Dikdortgene ait yeni uzunlugu giriniz:");
                    dikdortgen.yukseklik = double.Parse(Console.ReadLine());
                    Console.Write("Yukseklik Degisti Yeni yukseklik ile isleminizi yapiniz\n");
                    goto etiket1;
                }
                else if (girilen == 6)
                {
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    dikdortgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Karakter Degisti Yapilacak İslemi Seciniz\n");
                    goto etiket1;
                }
                else if (girilen == 7)
                {
                    Console.Write("Yeniden Seciniz Cizilen Dikdortgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    dikdortgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seciminiz Degisti yapmak istediginiz islemi seciniz\n");
                    goto etiket1;
                }
                else if (girilen == 8)
                {
                    dikdortgen.OzellikYazdir();
                }
                else if (girilen == 9)
                {
                    goto etiket3;
                }
                else
                {
                    Console.Write("Byee");
                    Environment.Exit(0);
                }
            }
            else if (girilen == 2)
            {
                Console.Write("Ucgenin Kenar Uzunlugunu Giriniz(Kenar Uzunlugunu Tek Sayi Giriniz Aksi Halde Islem Yapilamaz!!!):");
                ucgen.kenar = double.Parse(Console.ReadLine());
            etiket4:
                Console.Write("1-)Alan Hesapla\n2-)Cevre Hesapla\n3-)Ciz\n4-)Kenar Uzunluk Degistir\n5-)Karakter Degistir\n6-)Dolumu Degistir\n7-)Bilgileri Yazdir\n8-)Ust Menu\n9-)Cikis");
                girilen = double.Parse(Console.ReadLine());
                if (girilen == 1)
                {
                    sonuc = ucgen.AlanHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 2)
                {
                    sonuc = ucgen.CevreHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 3)
                {
                    Console.Write("Cizilen Ucgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    ucgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    ucgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Secimlerinizi Degistirmek Istiyorsaniz ust menuye donun\nUst Menuye Donmek ıcin 1 tuslayin\nDevam etmek icin 2 tuslayin");
                    girilen = double.Parse(Console.ReadLine());
                    if (girilen == 1)
                    {
                        goto etiket4;
                    }
                    else
                    {
                        goto etiket5;
                    }
                etiket5:
                    ucgen.ciz();
                }
                else if (girilen == 4)
                {
                    Console.Write("Ucgene ait yeni kenar uzunlugu giriniz:");
                    ucgen.kenar = double.Parse(Console.ReadLine());
                    Console.Write("Kenar Uzunlugu Degisti Yeni kenar uzunlugu ile isleminizi yapiniz\n");
                    goto etiket4;
                }
                else if (girilen == 5)
                {
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    ucgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Karakter Degisti Yapilacak İslemi Seciniz\n");
                    goto etiket4;
                }
                else if (girilen == 6)
                {
                    Console.Write("Yeniden Seciniz Cizilen Ucgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    ucgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seciminiz Degisti yapmak istediginiz islemi seciniz\n");
                    goto etiket4;
                }
                else if (girilen == 7)
                {
                    ucgen.OzellikYazdir();
                }
                else if (girilen == 8)
                {
                    goto etiket3;
                }
                else
                {
                    Console.Write("Byee");
                    Environment.Exit(0);
                }
            }
            else if (girilen == 3)
            {
                Console.Write("Genislik ve Yukseklik degerlerini Esit ve Tek sayi giriniz aksi halde islem yapilamaz!!!\n");
                Console.Write("EskenarDortgenin Genisligini Giriniz: ");
                eskenardortgen.genislik = double.Parse(Console.ReadLine());
                Console.Write("EskenarDortgenin Yuksekligini Giriniz ");
                eskenardortgen.yukseklik = double.Parse(Console.ReadLine());
            etiket6:
                Console.Write("1-)Alan Hesapla\n2-)Cevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Uzunluk Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Bilgileri Yazdir\n9-)Ust Menu\n10-)Cikis");
                girilen = double.Parse(Console.ReadLine());
                if (girilen == 1)
                {
                    sonuc = eskenardortgen.AlanHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 2)
                {
                    sonuc = eskenardortgen.CevreHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 3)
                {
                    Console.Write("Cizilen EskenarDortgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    eskenardortgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    eskenardortgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Secimlerinizi Degistirmek Istiyorsaniz ust menuye donun\nUst Menuye Donmek ıcin 1 tuslayin\nDevam etmek icin 2 tuslayin");
                    girilen = double.Parse(Console.ReadLine());
                    if (girilen == 1)
                    {
                        goto etiket6;
                    }
                    else
                    {
                        goto etiket7;
                    }
                etiket7:
                    eskenardortgen.ciz();
                }
                else if (girilen == 4)
                {
                    Console.Write("EskenarDortgene ait yeni genisligi giriniz:");
                    eskenardortgen.genislik = double.Parse(Console.ReadLine());
                    Console.Write("Genislik degisti yeni genislik ile isleminizi yapiniz\n");
                    goto etiket6;
                }
                else if (girilen == 5)
                {
                    Console.Write("EskenarDortgene ait yeni yuksekligi giriniz:");
                    eskenardortgen.yukseklik = double.Parse(Console.ReadLine());
                    Console.Write("Yukseklik degisti yeni yukseklik ile isleminizi yapiniz\n");
                    goto etiket6;
                }
                else if (girilen == 6)
                {
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    eskenardortgen.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Karakter Degisti Yapilacak İslemi Seciniz\n");
                    goto etiket6;
                }
                else if (girilen == 7)
                {
                    Console.Write("Yeniden Seciniz Cizilen EskenarDortgenin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    eskenardortgen.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seciminiz Degisti yapmak istediginiz islemi seciniz\n");
                    goto etiket6;
                }
                else if (girilen == 8)
                {
                    eskenardortgen.OzellikYazdir();
                }
                else if (girilen == 9)
                {
                    goto etiket3;
                }
                else
                {
                    Console.Write("Byee");
                    Environment.Exit(0);
                }
            }
            else if (girilen == 4)
            {
                Console.Write("Paralelkenarin Genisligini Giriniz: ");
                paralelkenar.genislik = double.Parse(Console.ReadLine());
                Console.Write("Paralelkenarin Yuksekligini Giriniz ");
                paralelkenar.yukseklik = double.Parse(Console.ReadLine());
            etiket9:
                Console.Write("1-)Alan Hesapla\n2-)Cevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Yukseklik Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Yon Degistir\n9-)Bilgileri Yazdir\n10-)Ust Menu\n11-)Cikis");
                girilen = double.Parse(Console.ReadLine());
                if (girilen == 1)
                {
                    sonuc = paralelkenar.AlanHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 2)
                {
                    sonuc = paralelkenar.CevreHesapla();
                    Console.WriteLine(sonuc);
                }
                else if (girilen == 3)
                {
                    Console.Write("Cizilen Paralelkenarin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    paralelkenar.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    paralelkenar.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Cizilen Paralelkenarin saga egik olmasını istiyorsanız true sola egik olması ıcın false yazınız");
                    paralelkenar.Yon = bool.Parse(Console.ReadLine());
                    Console.Write("Secimlerinizi Degistirmek Istiyorsaniz ust menuye donun\nUst Menuye Donmek ıcin 1 tuslayin\nDevam etmek icin 2 tuslayin");
                    girilen = double.Parse(Console.ReadLine());
                    if (girilen == 1)
                    {
                        goto etiket9;
                    }
                    else
                    {
                        goto etiket11;
                    }
                etiket11:
                    paralelkenar.ciz();
                }
                else if (girilen == 4)
                {
                    Console.Write("Paralelkenara ait yeni genisligi giriniz:");
                    paralelkenar.genislik = double.Parse(Console.ReadLine());
                    Console.Write("Genislik degisti yeni genislik ile isleminizi yapiniz\n");
                    goto etiket9;
                }
                else if (girilen == 5)
                {
                    Console.Write("Paralelkenara ait yeni yuksekligi giriniz:");
                    paralelkenar.yukseklik = double.Parse(Console.ReadLine());
                    Console.Write("Yukseklik degisti yeni yukseklik ile isleminizi yapiniz\n");
                    goto etiket9;
                }
                else if (girilen == 6)
                {
                    Console.Write("Seklin hangi karakterle cizilecegini giriniz");
                    paralelkenar.sembol = char.Parse(Console.ReadLine());
                    Console.Write("Karakter Degisti Yapilacak İslemi Seciniz\n");
                    goto etiket9;
                }
                else if (girilen == 7)
                {
                    Console.Write("Yeniden Seciniz Cizilen Paralelkenarin Icinin Dolu Olmasini Istiyorsaniz true, bos olmasini istiyorsaniz false yaziniz");
                    paralelkenar.DoluMu = bool.Parse(Console.ReadLine());
                    Console.Write("Seciminiz Degisti yapmak istediginiz islemi seciniz\n");
                    goto etiket9;
                }
                else if (girilen == 8)
                {
                    Console.Write("Paralelkenarin hangi yonde cizilecegini seciniz");
                    paralelkenar.Yon = bool.Parse(Console.ReadLine());
                    Console.Write("Seciminiz Degisti yapmak istediginiz islemi seciniz\n");
                    goto etiket9;
                }
                else if (girilen == 9)
                {
                    paralelkenar.OzellikYazdir();
                }
                else if (girilen == 10)
                {
                    goto etiket3;
                }
                else
                {
                    Console.Write("Byee");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Write("Byee");
                Environment.Exit(0);
            }
        }
    }
}
