using MyRow = PharmacySrenity.Product.ProductRow;

namespace PharmacySrenity.Product;

public interface IProductSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ProductSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IProductSaveHandler
{
}