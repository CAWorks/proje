using BetaECommerce.Domain.Concrete.Catalog;

namespace BetaECommerce.DataAccess.Abstract.Catalog
{
    public interface IProductRepository : IRepository<Product>
    {

    }

    public interface IProductAttributeRepository : IRepository<ProductAttribute>
    {

    }

    public interface IProductPicture : IRepository<ProductPicture>
    {

    }
}
