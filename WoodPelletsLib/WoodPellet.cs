namespace WoodPelletsLib
{
    public class WoodPellet
    {
        public WoodPellet()
        {
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Price { get; set; }
        public int? Quality { get; set; }

        public void ValidateBrand()
        {
            if (Brand == null)
            {
                throw new ArgumentNullException("Der skal være et brand.");
            }
            if (Brand.Length < 3)
            {
                throw new ArgumentException("Brandet skal have mindst 3 karakterer.");
            }
        }

        public void ValidatePrice()
        {
            if (Price == null)
            {
                throw new ArgumentNullException("Prisen skal indeholde en værdi.");
            }
            if (Price <= 0)
            {
                throw new ArgumentException("Prisen kan ikke være negativ eller 0.");
            }
        }

        public void ValidateQuality()
        {
            if (Quality == null)
            {
                throw new ArgumentNullException("Kvaliteten skal indeholde en værdi.");
            }
            if (Quality < 1 || Quality > 5)
            {
                throw new ArgumentException("Kvaliteten skal have en værdi i intervallet 1-5.");
            }
        }

        public void Validate()
        {
            ValidateBrand();
            ValidatePrice();
            ValidateQuality();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Pris: {Price}, Kvalitet: {Quality}";
        }
    }
}