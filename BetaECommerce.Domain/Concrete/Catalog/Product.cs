namespace BetaECommerce.Domain.Concrete.Catalog
{
    public class Product : BaseEntity
    {

        public int OrderMinimumQuantity { get; set; }
        public int OrderMaximumQuantity { get; set; }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }


        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProductCost { get; set; }


        public bool ShowOnHomePage { get; set; }
        public bool MarkAsNew { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool Published { get; set; }
    }


    public class ProductAttribute : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ProductPicture : BaseEntity
    {
        public int ProductId { get; set; }
        public int ImageId { get; set; }
    }
}
