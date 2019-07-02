using System;
using System.Collections.Generic;

namespace eCommerce
{
    class Urun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string Kategori { get; set; }
        public double kdvOrani { get; set; } = 1.18;
        public double Fiyat { get; set; }


        #region Login
        public bool Login()
        {
            string kullanıcıAdi = "kubranur", sifre = "123", k, s;
            Console.Write("Kullanıcı adı:"); k = Console.ReadLine();
            Console.Write("Şifre:"); s = Console.ReadLine();

            if (k == kullanıcıAdi && s == sifre)
            {
                Console.WriteLine("Giriş Başarılı\nDevam etmek için bir tuşa basın");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Giriş Başarısız\nDevam etmek için bir tuşa basın");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }

        #endregion

        #region Listele
        public void Listele(List<Urun> liste, string s)
        {
            string kategori = "";
            //Console.WriteLine("s : " + s);
            switch (s)
            {
                case "1": kategori = "Giyim"; break;
                case "2": kategori = "Ayakkabı"; break;
                case "3": kategori = "Elektronik"; break;
                case "4": kategori = "Kozmetik"; break;
                case "5": kategori = "Kitap"; break;
                case "6": kategori = "AnneBebek"; break;
                case "7": kategori = "EvYaşam"; break;
                case "8": kategori = "Spor"; break;
                case "9": kategori = "Saat"; break;
                //case "4": break;
                default: kategori = ""; Console.WriteLine("Hataa"); break;
            }
            if (liste.Count != 0)
            {
                Console.Write("[ID]\t[ADI]\t[FİYAT]\t[KTGRİ]");
                if (kategori == "Giyim")
                {
                    Console.WriteLine("\t[BEDEN]");
                }
                else if (kategori == "Ayakkabı")
                {
                    Console.WriteLine("\t[AYAK NO]");
                }
                else if (kategori == "Elektronik")
                {
                    Console.WriteLine("\t[CPU]\t[EKRAN]\t[RAM]");
                }
                else if (kategori== "Kozmetik")
                {
                    Console.WriteLine("\t[RENK]\t[STOK]\t[TÜR]");
                }
                else if (kategori == "Kitap")
                {
                    Console.WriteLine("\t[YAZAR]\t[SAYFA]\t[YAYINEVİ]");
                }
                else if (kategori == "AnneBebek")
                {
                    Console.WriteLine("\t[HACİM]\t[YAŞ]");
                }
                else if (kategori == "EvYaşam")
                {
                    Console.WriteLine("\t[ALAN]\t[STOK]");
                }
                else if (kategori == "Spor")
                {
                    Console.WriteLine("\t[CİNSİYET]\t[TÜR]");
                }
                else if (kategori == "Saat")
                {
                    Console.WriteLine("\t[CİNSİYET]\t[TÜR]\t[RENK]");
                }
                foreach (var item in liste)
                {
                    if (kategori == item.Kategori)
                    {
                        Console.Write("{0}\t{1}\t{2}\t{3}", item.Id, item.UrunAd, item.Fiyat, item.Kategori);

                        if (kategori == "Giyim")
                        {
                            Console.WriteLine("\t{0}", ((Giyim)item).Beden);
                        }
                        else if (kategori == "Ayakkabı")
                        {
                            Console.WriteLine("\t{0}", ((Ayakkabi)item).AyakkabiNo);
                        }
                        else if (kategori == "Elektronik")
                        {
                            Console.WriteLine("\t{0}", ((Elektronik)item).islemci);
                        }
                        else if (kategori == "Kozmetik")
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}",((Kozmetik)item).RenkTonu, ((Kozmetik)item).StokMiktar, ((Kozmetik)item).Tur);
                        }
                        else if (kategori == "Kitap")
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}", ((Kitap)item).Yazar, ((Kitap)item).SayfaSayisi, ((Kitap)item).YayinEvi);
                        }
                        else if (kategori == "AnneBebek")
                        {
                            Console.WriteLine("\t{0}\t{1}", ((AnneBebek)item).Hacim, ((AnneBebek)item).Yas);
                        }
                        else if (kategori == "EvYaşam")
                        {
                            Console.WriteLine("\t{0}\t{1}", ((EvYasam)item).Alan, ((EvYasam)item).StokMiktar);
                        }
                        else if (kategori == "Spor")
                        {
                            Console.WriteLine("\t[CİNSİYET]\t[TÜR]", ((Spor)item).Cinsiyet, ((Spor)item).Tur);
                        }
                        else if (kategori == "Saat")
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}", ((Saat)item).Cinsiyet, ((Saat)item).Tur,((Saat)item).Renk);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Liste boş");
            }
        }
        #endregion

        #region Admin Ürün Ekle
        public void UrunEkle(List<Urun> liste, int Id, string s)
        {
            Urun u;
            string kategori = "";

            switch (s)
            {
                case "1": kategori = "Giyim"; u = new Giyim(); Console.WriteLine("GİYİM NESNESİ ÜRETİLDİ"); break;
                case "2": kategori = "Ayakkabı"; u = new Ayakkabi(); Console.WriteLine("AYAKKABI NESNESİ ÜRETİLDİ"); break;
                case "3": kategori = "Elektronik"; u = new Elektronik(); Console.WriteLine("ELEKTRONİK NESNESİ ÜRETİLDİ"); break;
                case "4": kategori = "Kozmetik"; u = new Kozmetik(); Console.WriteLine("KOZMETİK NESNESİ ÜRETİLDİ"); break;
                case "5": kategori = "Kitap"; u = new Kitap(); Console.WriteLine("KİTAP NESNESİ ÜRETİLDİ"); break;
                case "6": kategori = "AnneBebek"; u = new AnneBebek(); Console.WriteLine("ANNEBEBEK NESNESİ ÜRETİLDİ"); break;
                case "7": kategori = "EvYasam"; u = new EvYasam(); Console.WriteLine("EVYAŞAM NESNESİ ÜRETİLDİ"); break;
                case "8": kategori = "Spor"; u = new Spor(); Console.WriteLine("SPOR NESNESİ ÜRETİLDİ"); break;
                case "9": kategori = "Saat"; u = new Saat(); Console.WriteLine("SAAT NESNESİ ÜRETİLDİ"); break;
                default: Console.WriteLine("Hata"); u = new Urun(); Console.WriteLine("ÜRÜN NESNESİ ÜRETİLDİ"); break;
            }

            u.Id = Id;
            u.kdvOrani = 1.18;
            u.Kategori = kategori;
            Console.WriteLine("Ürün adı:"); u.UrunAd = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatı:"); u.Fiyat = Convert.ToDouble(Console.ReadLine());

            if (kategori == "Giyim")
            {
                Console.WriteLine("Ürün Bedeni: "); ((Giyim)u).Beden = Console.ReadLine();
            }
            else if (kategori == "Ayakkabı")
            {
                Console.WriteLine("Ayak No: "); ((Ayakkabi)u).AyakkabiNo = Convert.ToInt16(Console.ReadLine());
            }
            else if (kategori == "Elektronik")
            {
                Console.WriteLine("İşlemci: "); ((Elektronik)u).islemci = Console.ReadLine();
                Console.WriteLine("RAM: "); ((Elektronik)u).RAM = Console.ReadLine();
                Console.WriteLine("Ekran Boyutu: "); ((Elektronik)u).ekranBoyutu = Console.ReadLine();
            }
            else if (kategori == "Kozmetik")
            {
                Console.WriteLine("Renk Tonu: "); ((Kozmetik)u).RenkTonu = Console.ReadLine();
                Console.WriteLine("Stok Miktarı: "); ((Kozmetik)u).StokMiktar = Console.ReadLine();
                Console.WriteLine("Kozmetik Türü: "); ((Kozmetik)u).Tur = Console.ReadLine();
            }
            else if (kategori == "Kitap")
            {
                Console.WriteLine("Yazar: "); ((Kitap)u).Yazar = Console.ReadLine();
                Console.WriteLine("Sayfa Sayısı: "); ((Kitap)u).SayfaSayisi = Console.ReadLine();
                Console.WriteLine("Yayın Evi: "); ((Kitap)u).YayinEvi = Console.ReadLine();
            }
            else if (kategori == "AnneBebek")
            {
                Console.WriteLine("Hacim: "); ((AnneBebek)u).Hacim = Console.ReadLine();
                Console.WriteLine("Yaş: "); ((AnneBebek)u).Yas = Console.ReadLine();
                
            }
            else if (kategori == "EvYaşam")
            {
                Console.WriteLine("\t[ALAN]\t[STOK]");
                Console.WriteLine("Alan: "); ((EvYasam)u).Alan = Console.ReadLine();
                Console.WriteLine("Stok Miktarı: "); ((EvYasam)u).StokMiktar = Console.ReadLine();
            }
            else if (kategori == "Spor")
            {
                Console.WriteLine("\t[CİNSİYET]\t[TÜR]");
                Console.WriteLine("Cinsiyet: "); ((Spor)u).Cinsiyet =Convert.ToChar( Console.ReadLine().ToUpper()[0]);
                Console.WriteLine("Tür: "); ((Spor)u).Tur = Console.ReadLine();
            }
            else if (kategori == "Saat")
            {
                Console.WriteLine("\t[CİNSİYET]\t[TÜR]\t[RENK]");
                Console.WriteLine("Cinsiyet: "); ((Saat)u).Cinsiyet = Convert.ToChar(Console.ReadLine().ToUpper()[0]);
                Console.WriteLine("Tür: "); ((Saat)u).Tur = Console.ReadLine();
                Console.WriteLine("Renk: "); ((Saat)u).Renk = Console.ReadLine();
            }
            

            Console.WriteLine("Ürün eklendi...");
            Console.Write("{0}\t{1}\t{2}", u.Id, u.UrunAd, u.Fiyat);

            if (kategori == "Giyim")
            {
                Console.WriteLine("\t{0}",((Giyim)u).Beden); 
            }
            else if (kategori == "Ayakkabı")
            {
                Console.WriteLine("\t{0}",((Ayakkabi)u).AyakkabiNo);  
            }
            else if (kategori == "Elektronik")
            {
                Console.WriteLine("\t{0}",((Elektronik)u).islemci); 
            }
            else if (kategori == "Kozmetik")
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", ((Kozmetik)u).RenkTonu, ((Kozmetik)u).StokMiktar, ((Kozmetik)u).Tur);
            }
            else if (kategori == "Kitap")
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", ((Kitap)u).Yazar, ((Kitap)u).SayfaSayisi, ((Kitap)u).YayinEvi);
            }
            else if (kategori == "AnneBebek")
            {
                Console.WriteLine("\t{0}\t{1}", ((AnneBebek)u).Hacim, ((AnneBebek)u).Yas);
            }
            else if (kategori == "EvYaşam")
            {
                Console.WriteLine("\t{0}\t{1}", ((EvYasam)u).Alan, ((EvYasam)u).StokMiktar);
            }
            else if (kategori == "Spor")
            {
                Console.WriteLine("\t[CİNSİYET]\t[TÜR]", ((Spor)u).Cinsiyet, ((Spor)u).Tur);
            }
            else if (kategori == "Saat")
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", ((Saat)u).Cinsiyet, ((Saat)u).Tur, ((Saat)u).Renk);
            }


            liste.Add(u);
            Console.ReadLine();
            Console.Clear();
        }

        internal void Listele(List<Urun> sepet)
        {
            double toplam = 0;
            double toplamKdvli = 0;
            double toplamKdvliKupon = 0;
            string kupon = "";
            foreach (var item in sepet)
            {
                kupon = "252627100";

                Console.WriteLine("Kuponunuz Var Mı?[E][H]");
                string secim = Console.ReadLine();
                if (secim == "E")
                {
                    Console.WriteLine("Kupun Kodunu Giriniz:");
                    string kuponKod = Console.ReadLine();
                    if (kupon == kuponKod)
                    {
                        Console.WriteLine("Kupon Doğru!");
                        
                        toplam += item.Fiyat;
                        toplamKdvli += item.Fiyat * item.kdvOrani;
                        toplamKdvliKupon+= (item.Fiyat - item.Fiyat * 0.20)* item.kdvOrani;
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", item.Id, item.Kategori, item.UrunAd, item.Fiyat, item.Fiyat * item.kdvOrani);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Kod...");
                    }
                }
                else if (secim == "H")
                {
                    toplam += item.Fiyat;
                    toplamKdvli += item.Fiyat * item.kdvOrani;
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", item.Id, item.Kategori, item.UrunAd, item.Fiyat, item.Fiyat * item.kdvOrani);
                }
            }

            Console.WriteLine("Toplam Fiyat: " + toplam);
            Console.WriteLine("Toplam KDVLİ Fiyat: " + toplamKdvli);
            Console.WriteLine("Toplam Kuponlu Fiyat: "+ toplamKdvliKupon);
        }
        #endregion

        #region Admin Ürün Sil
        public void UrunSil(List<Urun> liste, int id)
        {
            bool found = false;
            foreach (var item in liste)
            {
                if (item.Id == id)
                {
                    found = true;
                    liste.Remove(item);
                    Console.WriteLine("Ürün Silindi");
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("ÜRün bulunamadı");
            }

        }
        #endregion

        
        
    }
}
