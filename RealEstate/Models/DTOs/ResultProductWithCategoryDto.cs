﻿namespace RealEstate.Models.DTOs
{
    public class ResultProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string CategoryName{ get; set; }
    }
}
