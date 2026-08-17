using MyRow = PharmacySrenity.Product.ProductRow;

namespace PharmacySrenity.Product;

public interface IProductListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ProductListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IProductListHandler
{
}