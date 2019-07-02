
using System;
using System.Collections.Generic;

namespace eCommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            bool login = false;
            string secim = "", secim2 = "", secim3 = "";
            int id = 0;
            Urun urun = new Urun();

            var urunListe = new List<Urun>();
            var sepet = new List<Urun>();

            #region MENU
            do
            {
                Console.WriteLine("[1] Giyim");
                Console.WriteLine("[2] Ayakkabı");
                Console.WriteLine("[3] Elektronik");
                Console.WriteLine("[4] Kozmetik");
                Console.WriteLine("[5] Kitap");
                Console.WriteLine("[6] AnneBebek");
                Console.WriteLine("[7] EvYaşam");
                Console.WriteLine("[8] Spor");
                Console.WriteLine("[9] Saat");
                Console.WriteLine("-----------------");
                Console.WriteLine("[S] Sepet");
                Console.WriteLine("-----------------");
                Console.WriteLine("[A] Admin Girişi");
                Console.WriteLine("-----------------");
                Console.WriteLine("[X] Çıkış");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        #region Giyim
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------GİYİM------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;
                    case "2":
                        #region Ayakkabı
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("----AYAKKABI----");
                            Console.WriteLine("----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    SepeteEkle(urunListe, sepet);
                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2 != "X");
                        #endregion
                        break;
                    case "3":
                        #region Elektronik
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("---ELEKTRONİK---");
                            Console.WriteLine("----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    SepeteEkle(urunListe, sepet);
                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2 != "X");
                        #endregion
                        break;
                    case "4":
                        #region Kozmetik
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------KOZMETİK------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;

                    case "5":
                        #region Kitap
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------KİTAP------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;

                    case "6":
                        #region AnneBebek
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------ANNEBEBEK------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;

                    case "7":
                        #region EvYaşam
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------EVYAŞAM------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;
                    case "8":
                        #region Spor
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------SPOR------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;

                    case "9":
                        #region Saat
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("------SAAT------");
                            Console.WriteLine("-----------------");
                            urun.Listele(urunListe, secim);
                            Console.WriteLine("-----------------");
                            Console.WriteLine("[S] Sepete Ekle");
                            Console.WriteLine("[X] Geri");
                            secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "S":
                                    {
                                        SepeteEkle(urunListe, sepet);
                                    }

                                    break;
                                case "X": Console.Clear(); break;

                                default: Console.WriteLine("Hata"); break;
                            }
                        } while (secim2.ToUpper() != "X");
                        #endregion
                        break;
                    case "S":
                        #region Sepet
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Sepette {0} ürün var", sepet.Count);
                                urun.Listele(sepet);
                                Console.WriteLine("---------SEPET---------");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("[1] ÖDE");
                                Console.WriteLine("[2] Sepeti Boşalt");
                                Console.WriteLine("[3] Sepetten Ürün Çıkar");
                                Console.WriteLine("[X] Geri");
                                secim2 = Console.ReadLine();
                                switch (secim2)
                                {
                                    case "1": Console.WriteLine("Ödendi"); sepet.Clear(); break;
                                    case "2": Console.WriteLine("Sepet boşaltıldı"); sepet.Clear(); break;
                                    case "3": SepettenCikar(urunListe,sepet);Console.WriteLine("Ürün çıkartıldı"); break;
                                    case "X": Console.Clear();break;
                                    default:
                                        break;
                                }
                            } while (secim2!="X");
                            


                        }
                        #endregion
                        break;
                    case "A":
                        #region admin
                        if (login == false)
                        {
                            login = urun.Login();
                        }
                        if (login)
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("[1] Ürün ekle");
                                Console.WriteLine("[2] Ürün Sil");
                                Console.WriteLine("[X] Geri");
                                secim2 = Console.ReadLine();
                                switch (secim2)
                                {
                                    case "1":
                                        do
                                        {
                                            #region ÜRÜN EKLE

                                            Console.Clear();
                                            Console.WriteLine("------EKLE------");
                                            Console.WriteLine("----------------");
                                            Console.WriteLine("[1] Giyim");
                                            Console.WriteLine("[2] Ayakkabı");
                                            Console.WriteLine("[3] Elektronik");
                                            Console.WriteLine("[4] Giyim");
                                            Console.WriteLine("[5] Ayakkabı");
                                            Console.WriteLine("[6] Elektronik");
                                            Console.WriteLine("[7] Giyim");
                                            Console.WriteLine("[8] Ayakkabı");
                                            Console.WriteLine("[9] Elektronik");
                                            Console.WriteLine("[X] GERİ");
                                            secim3 = Console.ReadLine();




                                            switch (secim3)
                                            {
                                                case "1": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "2": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "3": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "4": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "5": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "6": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "7": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "8": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "9": urun.UrunEkle(urunListe, id, secim3); id++;  break;
                                                case "X": Console.Clear(); break;
                                                default: Console.WriteLine("Hata"); break;
                                            }
                                            #endregion
                                        } while (secim3 != "X");

                                        break;
                                    case "2":
                                        {
                                            #region ÜRÜN SİL


                                            Console.WriteLine("Ürün ID: ");
                                            int urunid = Convert.ToInt16(Console.ReadLine());
                                            urun.UrunSil(urunListe, urunid);
                                            Console.ReadLine();
                                            #endregion
                                        }
                                        break;
                                    case "X": Console.Clear(); break;
                                    default: Console.WriteLine("Hata"); break;
                                }
                            } while (secim2 != "X");
                        }
                        #endregion

                        break;
                    case "X": Console.Clear(); break;
                    default:
                        Console.WriteLine("Hatalı seçim");
                        break;
                }

            } while (secim != "X");
            #endregion
        }
        #region SEPETE EKLE        
        private static void SepeteEkle(List<Urun> urunListe, List<Urun> sepet)
        {
            Console.WriteLine("Ürün ID Gir");
            int urunid = Convert.ToInt32(Console.ReadLine());
            foreach (var item in urunListe)
            {
                if (item.Id == urunid)
                {
                    sepet.Add(item);
                    Console.WriteLine(item.UrunAd + " sepete eklendi");
                    break;
                }
            }
        }
        #endregion

        #region SEPETTEN ÇIKAR        
        private static void SepettenCikar(List<Urun> urunListe, List<Urun> sepet)
        {
            Console.WriteLine("Ürün ID Gir");
            int urunid = Convert.ToInt32(Console.ReadLine());
            foreach (var item in urunListe)
            {
                if (item.Id == urunid)
                {
                    sepet.Remove(item);
                    Console.WriteLine(item.UrunAd + " sepetten çıkarıldı");
                    break;
                }
            }
        }
        #endregion
    }
}
