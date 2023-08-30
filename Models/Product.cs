namespace BambooBayEF.Models
{
    public class Product
    {
       
        public int ? ProductId { get; set; }
        
        public string ?ProductName { get; set; }

        public string ?ProductDescription { get; set; }

        public float? ProductPrice { get; set; }

        public int? productQuantity { get; set; }

    }
}
