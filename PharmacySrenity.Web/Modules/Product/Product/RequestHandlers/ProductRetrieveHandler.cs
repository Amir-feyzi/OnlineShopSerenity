using MyRow = PharmacySrenity.Product.ProductRow;

namespace PharmacySrenity.Product;

public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ProductRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IProductRetrieveHandler
{
}