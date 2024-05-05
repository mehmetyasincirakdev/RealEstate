namespace RealEstate.Models.DTOs.ProductDTOs
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public int ProductCategory { get; set; }
    }
}
