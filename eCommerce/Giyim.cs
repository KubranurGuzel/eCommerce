namespace eCommerce
{
    class Giyim : Urun
    {
        public string Beden { get; set; }

        public Giyim()
        {
            Beden = "XS";
            kdvOrani = 1.08;
        }
    }
}
