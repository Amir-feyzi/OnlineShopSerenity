using MyRow = PharmacySrenity.Product.ProductRow;

namespace PharmacySrenity.Product;

public interface IProductDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProductDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProductDeleteHandler
{
}